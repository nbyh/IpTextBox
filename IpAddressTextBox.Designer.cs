namespace IpTextBox
{
    partial class IpAddressTextBox
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Box4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Box3 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Box4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Box3);
            this.panel1.Controls.Add(this.Box2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Box1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(100, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 18);
            this.panel1.TabIndex = 0;
            this.panel1.EnabledChanged += new System.EventHandler(this.panel1_EnabledChanged);
            // 
            // Box4
            // 
            this.Box4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box4.Location = new System.Drawing.Point(83, 0);
            this.Box4.MaxLength = 3;
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(20, 14);
            this.Box4.TabIndex = 4;
            this.Box4.TabStop = false;
            this.Box4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Box4.Enter += new System.EventHandler(this.Box_Enter);
            this.Box4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box4_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(8, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = ".";
            this.label3.EnabledChanged += new System.EventHandler(this.label_EnabledChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(77, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(8, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            this.label2.EnabledChanged += new System.EventHandler(this.label_EnabledChanged);
            // 
            // Box3
            // 
            this.Box3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box3.Location = new System.Drawing.Point(57, 0);
            this.Box3.MaxLength = 3;
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(20, 14);
            this.Box3.TabIndex = 3;
            this.Box3.TabStop = false;
            this.Box3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Box3.Enter += new System.EventHandler(this.Box_Enter);
            this.Box3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box3_KeyPress);
            // 
            // Box2
            // 
            this.Box2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box2.Location = new System.Drawing.Point(29, 0);
            this.Box2.MaxLength = 3;
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(20, 14);
            this.Box2.TabIndex = 2;
            this.Box2.TabStop = false;
            this.Box2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Box2.Enter += new System.EventHandler(this.Box_Enter);
            this.Box2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box2_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = ".";
            this.label1.EnabledChanged += new System.EventHandler(this.label_EnabledChanged);
            // 
            // Box1
            // 
            this.Box1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box1.Location = new System.Drawing.Point(1, 0);
            this.Box1.MaxLength = 3;
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(20, 14);
            this.Box1.TabIndex = 1;
            this.Box1.TabStop = false;
            this.Box1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Box1.Enter += new System.EventHandler(this.Box_Enter);
            this.Box1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box1_KeyPress);
            // 
            // IpAddressTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(106, 18);
            this.MinimumSize = new System.Drawing.Size(106, 18);
            this.Name = "IpAddressTextBox";
            this.Size = new System.Drawing.Size(106, 18);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The box1
        /// </summary>
        private System.Windows.Forms.TextBox Box1;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The box2
        /// </summary>
        private System.Windows.Forms.TextBox Box2;
        /// <summary>
        /// The box3
        /// </summary>
        private System.Windows.Forms.TextBox Box3;
        //private System.Windows.Forms.TextBox Box4;
        /// <summary>
        /// The label2
        /// </summary>
        private System.Windows.Forms.Label label2;
        /// <summary>
        /// The label3
        /// </summary>
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// The tool tip1
        /// </summary>
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox Box4;
    }
}
