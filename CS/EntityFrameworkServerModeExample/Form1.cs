using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using System;

namespace EntityFrameworkServerModeExample
{
    public partial class Form1 : XtraForm
    {
        EntityServerModeSource entityServerModeSource;
        bool serverMode = false;
        public Form1()
        {
            InitializeComponent();
            entityServerModeSource = new EntityServerModeSource
            {
                ElementType = typeof(EntityInvoice),
                KeyExpression = "OrderId"
            };
            NWEntities context = new NWEntities();
            context.Database.Log = Console.Write;
            entityServerModeSource.QueryableSource = context.EntityInvoices;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nWDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.nWDataSet.Invoices);
            SetPivotGridDataSource();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            serverMode = ((ToggleSwitch)sender).IsOn;
            SetPivotGridDataSource();
        }

        private void SetPivotGridDataSource()
        {
            if (serverMode)
                pivotGridControl1.DataSource = entityServerModeSource;
            else
                pivotGridControl1.DataSource = invoicesBindingSource;
        }
    }
}
