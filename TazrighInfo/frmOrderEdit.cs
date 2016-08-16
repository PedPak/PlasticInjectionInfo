using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmOrderEdit : Form
    {
        public long IdEdit;
        Order Ord = null;

        public frmOrderEdit()
        {
            InitializeComponent();
            IdEdit = 0;
        }
         

        private void chkAllowEdit_CheckedChanged(object sender, EventArgs e)
        {
            ReadOnlyforAll(!chkAllowEdit.Checked);
        }

        private void ReadOnlyforAll(bool Logic)
        {
            txtProductionCode.ReadOnly = Logic;
            txtNumberofOrder.ReadOnly = Logic;
            txtColor.ReadOnly = Logic;
            txtColorAmount.ReadOnly = Logic;
            txtColorOwner.ReadOnly = Logic;
            txtMaterialAmount.ReadOnly = Logic;
            txtMaterialOwner.ReadOnly = Logic;
            txtStartDate.ReadOnly = Logic;
            txtEndDate.ReadOnly = Logic;
            txtDeliverDate.ReadOnly = Logic;
            txtStartCounter.ReadOnly = Logic;
            txtStopCounter.ReadOnly = Logic;
            txtwastedNumber.ReadOnly = Logic;
            txtWaistedWeight.ReadOnly = Logic;
            txtWaistedPercent.ReadOnly = Logic;
            txtCoinageNumber.ReadOnly = Logic;
            txtTotalProductWeight.ReadOnly = Logic;
            txtExperimentLevel.ReadOnly = Logic;
            txtPurser.ReadOnly = Logic;
            txtOperatorName.ReadOnly = Logic;
            txtComments.ReadOnly = Logic;

            chkCastFormatDelivered.Enabled = !Logic;
        }

        private void frmOrderEdit_Load(object sender, EventArgs e)
        {           
            Ord = new Order();
            Ord.Id = IdEdit;

            if (!Ord.GetOne()) { MessageBox.Show(Ord.ErrorMessage); return; };

            Customer Cs = new Customer(); Cs.Id = Ord.CustomerCode;  if (!Cs.GetOne()) { MessageBox.Show(Cs.ErrorMessage); return; };
            Product Pr = new Product(); Pr.Id = Ord.ProductCode;  if (!Pr.GetOne()) { MessageBox.Show(Pr.ErrorMessage); return; };
            
            txtProduct.Text = Pr.Name;
            txtCustomer.Text = Cs.Name+" "+Cs.Family;
            chkCastFormatDelivered.Checked = Ord.CastFormatDelivered;
            
            txtProductionCode.Text=Ord.ProductionCode.ToString();

            txtNumberofOrder.Text = Ord.NumberofOrder.ToString();
            txtMaterialAmount.Text = Ord.MaterialAmount.ToString();
            txtColor.Text=Ord.Color;
            txtColorAmount.Text = Ord.ColorAmount.ToString();
            txtColorOwner.Text=Ord.ColorOwner;
            txtMaterialOwner.Text=Ord.MaterialOwner;
            txtOrderDate.Text=Ord.OrderDate ;
            txtOrderTime.Text=Ord.OrderTime ;
            txtStartDate.Text=Ord.StartDate ;
            txtEndDate.Text=Ord.EndDate;
            txtStartCounter.Text= Ord.StartCounter.ToString();
            txtStopCounter.Text= Ord.StopCounter.ToString();
            txtDeliverDate.Text=Ord.DeliverDate  ;
            txtwastedNumber.Text = Ord.wastedNumber.ToString();
            txtWaistedWeight.Text = Ord.WaistedWeight.ToString();
            txtWaistedPercent.Text= Ord.WaistedPercent.ToString();
            txtTotalProductWeight.Text= Ord.TotalProductWeight.ToString();
            txtCoinageNumber.Text= Ord.CoinageNumber.ToString();
            txtExperimentLevel.Text=Ord.ExperimentLevel  ;
            txtOperatorName.Text=Ord.OperatorName  ;
            txtComments.Text=Ord.Comments ;
            txtPurser.Text=Ord.Purser  ;              
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آيا مايل به ذخيره تغييرات هستيد", "ذخيره سازي", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                //Ord.ProductCode = Convert.ToInt64(txtProduct.Text);
                //Ord.CustomerCode = Convert.ToInt64(txtCustomer.Text);
                Ord.CastFormatDelivered = chkCastFormatDelivered.Checked;


                long.TryParse(txtProductionCode.Text, out Ord.ProductionCode);
                int.TryParse(txtNumberofOrder.Text, out Ord.NumberofOrder);
                Single.TryParse(txtMaterialAmount.Text, out Ord.MaterialAmount);
                Ord.Color = txtColor.Text;
                Single.TryParse(txtColorAmount.Text, out Ord.ColorAmount);
                Ord.ColorOwner = txtColorOwner.Text;
                Ord.MaterialOwner = txtMaterialOwner.Text;
               // Ord.OrderDate = txtOrderDate.Text;
                //Ord.OrderTime = txtOrderTime.Text;
                Ord.StartDate = txtStartDate.Text;
                Ord.EndDate = txtEndDate.Text;
                long.TryParse(txtStartCounter.Text, out Ord.StartCounter);
                long.TryParse(txtStopCounter.Text, out Ord.StopCounter);
                Ord.DeliverDate = txtDeliverDate.Text;
                int.TryParse(txtwastedNumber.Text, out Ord.wastedNumber);
                Single.TryParse(txtWaistedWeight.Text, out Ord.WaistedWeight);
                Single.TryParse(txtWaistedPercent.Text, out Ord.WaistedPercent);
                Single.TryParse(txtTotalProductWeight.Text, out Ord.TotalProductWeight);
                long.TryParse(txtCoinageNumber.Text, out Ord.CoinageNumber);
                Ord.ExperimentLevel = txtExperimentLevel.Text;
                Ord.OperatorName = txtOperatorName.Text;
                Ord.Comments = txtComments.Text;
                Ord.Purser = txtPurser.Text;  

                if (!Ord.Update()) { MessageBox.Show(Ord.ErrorMessage); return; };

                this.Close();
            }    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آيا مايل به حذف ركورد هستيد", "حذف", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (!Ord.DeleteById()) { MessageBox.Show(Ord.ErrorMessage); return; };
                this.Close();
            }
        }       
       
    }
}
