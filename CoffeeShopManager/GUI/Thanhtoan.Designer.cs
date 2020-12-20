
namespace GUI
{
    partial class Thanhtoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thanhtoan));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotalstart = new System.Windows.Forms.Label();
            this.lblCusGive = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMoneycus = new System.Windows.Forms.TextBox();
            this.txtExcess = new System.Windows.Forms.TextBox();
            this.btnSaveEnd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCopyPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(129, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Receipts";
            // 
            // lblTotalstart
            // 
            this.lblTotalstart.AutoSize = true;
            this.lblTotalstart.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalstart.Location = new System.Drawing.Point(22, 90);
            this.lblTotalstart.Name = "lblTotalstart";
            this.lblTotalstart.Size = new System.Drawing.Size(77, 30);
            this.lblTotalstart.TabIndex = 1;
            this.lblTotalstart.Text = "Total:";
            // 
            // lblCusGive
            // 
            this.lblCusGive.AutoSize = true;
            this.lblCusGive.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusGive.Location = new System.Drawing.Point(22, 140);
            this.lblCusGive.Name = "lblCusGive";
            this.lblCusGive.Size = new System.Drawing.Size(170, 30);
            this.lblCusGive.TabIndex = 2;
            this.lblCusGive.Text = "Money\'s Cus:";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(22, 220);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(165, 30);
            this.lblFinish.TabIndex = 3;
            this.lblFinish.Text = "Excess Cash:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(27, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 15);
            this.panel1.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(269, 90);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 5;
            // 
            // txtMoneycus
            // 
            this.txtMoneycus.Location = new System.Drawing.Point(269, 140);
            this.txtMoneycus.Name = "txtMoneycus";
            this.txtMoneycus.Size = new System.Drawing.Size(100, 22);
            this.txtMoneycus.TabIndex = 6;
            this.txtMoneycus.TextChanged += new System.EventHandler(this.txtMoneycus_TextChanged);
            // 
            // txtExcess
            // 
            this.txtExcess.Location = new System.Drawing.Point(269, 228);
            this.txtExcess.Name = "txtExcess";
            this.txtExcess.Size = new System.Drawing.Size(100, 22);
            this.txtExcess.TabIndex = 7;
            // 
            // btnSaveEnd
            // 
            this.btnSaveEnd.Location = new System.Drawing.Point(85, 279);
            this.btnSaveEnd.Name = "btnSaveEnd";
            this.btnSaveEnd.Size = new System.Drawing.Size(102, 37);
            this.btnSaveEnd.TabIndex = 8;
            this.btnSaveEnd.Text = "Save end";
            this.btnSaveEnd.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(218, 279);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 37);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Cancel";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // txtCopyPrice
            // 
            this.txtCopyPrice.Location = new System.Drawing.Point(294, 12);
            this.txtCopyPrice.Name = "txtCopyPrice";
            this.txtCopyPrice.Size = new System.Drawing.Size(100, 22);
            this.txtCopyPrice.TabIndex = 10;
            this.txtCopyPrice.Visible = false;
            // 
            // Thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 328);
            this.Controls.Add(this.txtCopyPrice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveEnd);
            this.Controls.Add(this.txtExcess);
            this.Controls.Add(this.txtMoneycus);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblCusGive);
            this.Controls.Add(this.lblTotalstart);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Thanhtoan";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotalstart;
        private System.Windows.Forms.Label lblCusGive;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtMoneycus;
        private System.Windows.Forms.TextBox txtExcess;
        private System.Windows.Forms.Button btnSaveEnd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txtCopyPrice;
    }
}