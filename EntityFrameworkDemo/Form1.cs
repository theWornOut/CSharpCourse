using System;
using System.Windows.Forms;

namespace EntityFrameworkDemo
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

        private void SearchProducts(string key)
        {
            //dgvProducts.DataSource = _productDal.GetAll().Where(x => x.Name.ToLower().Contains(key.ToLower())).ToList();
            dgvProducts.DataSource = _productDal.GetByName(key);
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
            MessageBox.Show("Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                _productDal.Update(new Product
                {
                    Id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value),
                    Name = txtNameUpdate.Text,
                    UnitPrice = Convert.ToDecimal(txtUnitPriceUpdate.Text),
                    StockAmount = Convert.ToInt32(txtStockAmountUpdate.Text)
                });
            }
            LoadProducts();
            MessageBox.Show("Updated!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
                _productDal.Delete(new Product
                {
                    Id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value)
                });
            LoadProducts();
            MessageBox.Show("Deleted!");
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txtSearch.Text);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            _productDal.GetById(1);
        }
    }
}