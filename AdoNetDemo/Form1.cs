using System;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = txtName.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                StockAmount = Convert.ToInt32(txtStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Added!");
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                txtIdUpdate.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
                txtNameUpdate.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
                txtUnitPriceUpdate.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
                txtStockAmountUpdate.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value),
                    Name = txtNameUpdate.Text,
                    UnitPrice = Convert.ToDecimal(txtUnitPriceUpdate.Text),
                    StockAmount = Convert.ToInt32(txtStockAmountUpdate.Text)
                };
                _productDal.Update(product);
            }
            LoadProducts();
            MessageBox.Show("Updated!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);
                _productDal.Delete(id);
            }
            LoadProducts();
            MessageBox.Show("Deleted!");
        }
    }
}