using System;
using System.Windows.Forms;
using ClassManager.Models;
using ClassManager.Repositories;
using ClassManager.Views;

namespace ClassManager.Presenters
{
    public class LopPresenter
    {
        private readonly ILopView _view;
        private readonly ILopRepository _repository;

        public LopPresenter(ILopView view, ILopRepository repository)
        {
            _view = view;
            _repository = repository;
        }

        public void LoadData()
        {
            try
            {
                var list = _repository.GetAll();
                _view.DisplayLopList(list);
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi load dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddLop()
        {
            if (!ValidateInput()) return;

            string ma = _view.MaLop.Trim();
            string ten = _view.TenLop.Trim();

            try
            {
                if (_repository.IsMaLopExists(ma))
                {
                    _view.ShowMessage("Mã lớp này đã tồn tại trong hệ thống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var lop = new Lop { MaLop = ma, TenLop = ten };
                if (_repository.Add(lop))
                {
                    _view.ShowMessage("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    RefreshInput();
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi thêm lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateLop()
        {
            if (!ValidateInput()) return;

            string ma = _view.MaLop.Trim();
            string ten = _view.TenLop.Trim();

            try
            {
                var lop = new Lop { MaLop = ma, TenLop = ten };
                if (_repository.Update(lop))
                {
                    _view.ShowMessage("Cập nhật thông tin lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    RefreshInput();
                }
                else
                {
                    _view.ShowMessage("Không tìm thấy lớp cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteLop()
        {
            string ma = _view.MaLop.Trim();

            if (string.IsNullOrWhiteSpace(ma))
            {
                _view.ShowMessage("Vui lòng chọn lớp cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int soSinhVien = _repository.CountSinhVienByLop(ma);
                if (soSinhVien > 0)
                {
                    _view.ShowMessage($"Không thể xóa! Lớp [{ma}] đang có {soSinhVien} sinh viên.", "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (!_view.ConfirmAction($"Bạn có chắc chắn muốn xóa lớp [{ma}] không?", "Xác nhận xóa"))
                {
                    return;
                }

                if (_repository.Delete(ma))
                {
                    _view.ShowMessage("Xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    RefreshInput();
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi xóa lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchLop()
        {
            try
            {
                string keyword = _view.SearchKeyword.Trim();
                var results = _repository.Search(keyword);
                _view.DisplayLopList(results);
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshInput()
        {
            _view.ClearInput();
            _view.SetMaLopEnabled(true);
            _view.FocusMaLop();
        }

        public void SelectRow(string maLop, string tenLop)
        {
            _view.MaLop = maLop;
            _view.TenLop = tenLop;
            _view.SetMaLopEnabled(false);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(_view.MaLop))
            {
                _view.ShowMessage("Vui lòng nhập Mã lớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _view.FocusMaLop();
                return false;
            }

            if (string.IsNullOrWhiteSpace(_view.TenLop))
            {
                _view.ShowMessage("Vui lòng nhập Tên lớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _view.FocusTenLop();
                return false;
            }

            return true;
        }
    }
}