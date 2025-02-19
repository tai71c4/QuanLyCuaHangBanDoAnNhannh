using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace FastFoodOrder
{
    public partial class OrderForm : Form
    {
        private List<MenuItem> menu;
        private List<OrderItem> orderItems = new List<OrderItem>();
        private PrintDocument printDocument = new PrintDocument();
        private decimal discount = 0;
        private decimal vatRate = 0.1m;

        // Danh sách mã giảm giá hợp lệ
        private Dictionary<string, decimal> discountCodes = new Dictionary<string, decimal>
        {
            { "SALE10", 0.10m },  // Giảm 10%
            { "SALE20", 0.20m },  // Giảm 20%
            { "SALE30", 0.30m },  // Giảm 30%
            { "SALEVL", 0.99m }   // Giảm VL%
        };

        public OrderForm()
        {
            InitializeComponent();
            LoadMenuItems();
            printDocument.PrintPage += new PrintPageEventHandler(PrintReceipt);
            txtSearch.TextChanged += TxtSearch_TextChanged;
            txtDiscountCode.TextChanged += TxtDiscountCode_TextChanged; // Bắt sự kiện nhập mã giảm giá
        }

        private void LoadMenuItems()
        {
            menu = new List<MenuItem>
            {
                new MenuItem("B001", "Burger Gà", 50000),
                new MenuItem("B002", "Burger Bò", 55000),
                new MenuItem("D001", "Coca Cola", 15000),
                new MenuItem("D002", "Pepsi", 15000),
                new MenuItem("D003", "Trà Sữa Trân Châu", 40000),
                new MenuItem("D004", "Sinh Tố Bơ", 45000),
                new MenuItem("B003", "Burger Cá", 52000),
                new MenuItem("B004", "Burger Phô Mai", 58000),
                new MenuItem("S001", "Khoai Tây Chiên", 30000),
                new MenuItem("S002", "Gà Rán", 60000),
                new MenuItem("S003", "Hot Dog", 40000),
                new MenuItem("S004", "Pizza Phô Mai", 120000),
                new MenuItem("S005", "Mì Ý Sốt Bò Bằm", 90000)
            };
            dgvMenu.DataSource = menu;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            dgvMenu.DataSource = menu.Where(m => m.Name.ToLower().Contains(searchText) || m.Code.ToLower().Contains(searchText)).ToList();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                var selectedRow = dgvMenu.SelectedRows[0];
                var itemCode = selectedRow.Cells["Code"].Value.ToString();
                var itemName = selectedRow.Cells["Name"].Value.ToString();
                var itemPrice = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

                var existingItem = orderItems.FirstOrDefault(i => i.Code == itemCode);
                if (existingItem != null)
                    existingItem.Quantity++;
                else
                    orderItems.Add(new OrderItem(itemCode, itemName, itemPrice, 1));

                RefreshOrderList();
            }
        }

        private void RefreshOrderList()
        {
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = orderItems;
            lblTotal.Text = $"Tổng tiền: {CalculateFinalTotal():N0} VND(đã bao gồm phí VAT)";
        }

        private decimal CalculateTotal()
        {
            return orderItems.Sum(item => item.Price * item.Quantity);
        }

        private decimal CalculateFinalTotal()
        {
            decimal total = CalculateTotal();
            total -= total * discount; // Trừ giảm giá
            total += total * vatRate;  // Thêm VAT
            return total;
        }

        private void TxtDiscountCode_TextChanged(object sender, EventArgs e)
        {
            string enteredCode = txtDiscountCode.Text.Trim().ToUpper();

            if (discountCodes.ContainsKey(enteredCode))
            {
                discount = discountCodes[enteredCode];
                lblDiscountStatus.Text = $"Mã hợp lệ! Giảm {discount * 100}%";
            }
            else
            {
                discount = 0;
                lblDiscountStatus.Text = "Mã không hợp lệ!";
            }

            RefreshOrderList(); // Cập nhật lại tổng tiền
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog { Document = printDocument };
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void PrintReceipt(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12);
            float y = 20;
            g.DrawString("HÓA ĐƠN THANH TOÁN", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 80, y);
            y += 40;
            foreach (var item in orderItems)
            {
                g.DrawString($"{item.Name} x {item.Quantity} - {item.Price * item.Quantity:N0} VND", font, Brushes.Black, 20, y);
                y += 30;
            }
            y += 20;
            g.DrawString($"Tổng tiền: {CalculateTotal():N0} VND", font, Brushes.Black, 20, y);
            y += 30;
            g.DrawString($"Giảm giá: {discount * 100:N0}%", font, Brushes.Black, 20, y);
            y += 30;
            g.DrawString($"VAT: {vatRate * 100:N0}%", font, Brushes.Black, 20, y);
            y += 30;
            g.DrawString($"Thành tiền: {CalculateFinalTotal():N0} VND", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 20, y);
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }

    public class MenuItem
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public MenuItem(string code, string name, decimal price) => (Code, Name, Price) = (code, name, price);
    }

    public class OrderItem : MenuItem
    {
        public int Quantity { get; set; }
        public OrderItem(string code, string name, decimal price, int quantity) : base(code, name, price) => Quantity = quantity;
    }
}
