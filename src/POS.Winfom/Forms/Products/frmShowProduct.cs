using System.ComponentModel;
using System.Data;
using System.Reflection;
using Mediator;
using POS.Application.Interface;
using POS.Application.Product.Qury;

namespace POW.Winfom.Forms.Products;
public partial class frmShowProduct : Form
{
    private readonly IMediator _mediator;
    DataTable dt;

    public frmShowProduct(IMediator mediator)
    {
        InitializeComponent();
        _mediator = mediator;
    }



    public static DataTable ToDataTable<T>(List<T> items)
    {
        DataTable dataTable = new DataTable(typeof(T).Name);
        //Get all the properties
        PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (PropertyInfo prop in Props)
        {
            //Setting column names as Property names
            dataTable.Columns.Add(prop.Name);
        }
        foreach (T item in items)
        {
            var values = new object[Props.Length];
            for (int i = 0; i < Props.Length; i++)
            {
                //inserting property values to datatable rows
                values[i] = Props[i].GetValue(item, null);
            }
            dataTable.Rows.Add(values);
        }
        //put a breakpoint here and check datatable
        return dataTable;
    }

    async void _RefrechProducts()
    {
        var data = await _mediator.Send(new GetAllProducts());
        dgvProducts.DataSource = data;
        dt = ToDataTable(data).DefaultView.ToTable(false,"ProductCode","Name","UnitPrice");

        dgvProducts.DataSource = dt;

        dgvProducts.RowHeadersVisible = true;
        dgvProducts.ColumnHeadersHeight = 50;
        if (dgvProducts.RowCount > 0)
        {

            dgvProducts.Columns[0].HeaderText = "كود الصنف";
            dgvProducts.Columns[1].HeaderText = "اسم الصنف";
            dgvProducts.Columns[2].HeaderText = "سعر الوحدة";

            dgvProducts.Columns[0].Width = 100;
            dgvProducts.Columns[1].Width = 200;
            dgvProducts.Columns[2].Width = 100;

        }
    }

    private void frmShowProduct_Load(object sender, EventArgs e)
    {

        txtSearch.Focus();
        _RefrechProducts();

    }

    private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var i = dgvProducts.CurrentRow.Cells[0].Value.ToString();
        var frm = new frmAddProduct(i, _mediator);
        frm.ShowDialog();
        _RefrechProducts();
    }


    private void btnAdd_Click(object sender, EventArgs e)
    {
        var frm = new frmAddProduct(_mediator);
        frm.ShowDialog();
        _RefrechProducts();
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtSearch.Text))
        {
            _RefrechProducts();
            return;
        }

        else if (cmbFilter.SelectedIndex == 1 && !String.IsNullOrEmpty(txtSearch.Text))
        {
            dt.DefaultView.RowFilter = $"{dgvProducts.Columns[1].HeaderText} LIKE \'%{txtSearch.Text.Trim()}%\'";
            dgvProducts.DataSource = dt;
        }

        else if (!String.IsNullOrEmpty(txtSearch.Text))
        {
            dt.DefaultView.RowFilter = $"{dgvProducts.Columns[0].HeaderText} LIKE \'%{txtSearch.Text.Trim()}%\'";
            dgvProducts.DataSource = dt;
        }

        }
}
