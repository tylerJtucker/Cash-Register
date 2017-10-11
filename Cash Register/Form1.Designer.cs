namespace Cash_Register
{
    partial class bapeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bapeForm));
            this.RifleLabel = new System.Windows.Forms.Label();
            this.riflesInput = new System.Windows.Forms.TextBox();
            this.pistolsLabel = new System.Windows.Forms.Label();
            this.pistolsInput = new System.Windows.Forms.TextBox();
            this.rpgLabel = new System.Windows.Forms.Label();
            this.rpgInput = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.reciptButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RifleLabel
            // 
            this.RifleLabel.AutoSize = true;
            this.RifleLabel.BackColor = System.Drawing.Color.Peru;
            this.RifleLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RifleLabel.Location = new System.Drawing.Point(56, 53);
            this.RifleLabel.Name = "RifleLabel";
            this.RifleLabel.Size = new System.Drawing.Size(118, 20);
            this.RifleLabel.TabIndex = 1;
            this.RifleLabel.Text = "Number Of Rifles";
            // 
            // riflesInput
            // 
            this.riflesInput.Location = new System.Drawing.Point(217, 53);
            this.riflesInput.Name = "riflesInput";
            this.riflesInput.Size = new System.Drawing.Size(43, 20);
            this.riflesInput.TabIndex = 2;
            // 
            // pistolsLabel
            // 
            this.pistolsLabel.AutoSize = true;
            this.pistolsLabel.BackColor = System.Drawing.Color.Peru;
            this.pistolsLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pistolsLabel.Location = new System.Drawing.Point(56, 107);
            this.pistolsLabel.Name = "pistolsLabel";
            this.pistolsLabel.Size = new System.Drawing.Size(125, 20);
            this.pistolsLabel.TabIndex = 3;
            this.pistolsLabel.Text = "Number Of Pistols";
            // 
            // pistolsInput
            // 
            this.pistolsInput.Location = new System.Drawing.Point(217, 107);
            this.pistolsInput.Name = "pistolsInput";
            this.pistolsInput.Size = new System.Drawing.Size(43, 20);
            this.pistolsInput.TabIndex = 4;
            // 
            // rpgLabel
            // 
            this.rpgLabel.AutoSize = true;
            this.rpgLabel.BackColor = System.Drawing.Color.Peru;
            this.rpgLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpgLabel.Location = new System.Drawing.Point(56, 156);
            this.rpgLabel.Name = "rpgLabel";
            this.rpgLabel.Size = new System.Drawing.Size(117, 20);
            this.rpgLabel.TabIndex = 5;
            this.rpgLabel.Text = "Number Of RPG\'s";
            // 
            // rpgInput
            // 
            this.rpgInput.Location = new System.Drawing.Point(217, 156);
            this.rpgInput.Name = "rpgInput";
            this.rpgInput.Size = new System.Drawing.Size(43, 20);
            this.rpgInput.TabIndex = 6;
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.Transparent;
            this.totalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.ForeColor = System.Drawing.Color.White;
            this.totalButton.Location = new System.Drawing.Point(60, 197);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(200, 31);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.Color.Peru;
            this.subtotalLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(56, 260);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(68, 20);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.Color.Peru;
            this.taxLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(56, 307);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(29, 20);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Peru;
            this.totalLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(56, 351);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(41, 20);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.BackColor = System.Drawing.Color.Peru;
            this.subtotalOutput.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(154, 260);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(0, 20);
            this.subtotalOutput.TabIndex = 11;
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.BackColor = System.Drawing.Color.Peru;
            this.taxOutput.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(154, 307);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 20);
            this.taxOutput.TabIndex = 12;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.BackColor = System.Drawing.Color.Peru;
            this.totalOutput.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(154, 351);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 20);
            this.totalOutput.TabIndex = 13;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Transparent;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(60, 449);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(200, 31);
            this.changeButton.TabIndex = 14;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Black;
            this.line.Location = new System.Drawing.Point(56, 387);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(213, 10);
            this.line.TabIndex = 15;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.BackColor = System.Drawing.Color.Peru;
            this.tenderedLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(56, 414);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(69, 20);
            this.tenderedLabel.TabIndex = 16;
            this.tenderedLabel.Text = "Tendered";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.BackColor = System.Drawing.Color.Peru;
            this.changeOutput.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(181, 494);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 20);
            this.changeOutput.TabIndex = 17;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(158, 414);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(102, 20);
            this.tenderedInput.TabIndex = 18;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.Peru;
            this.changeLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(56, 494);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(58, 20);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change";
            // 
            // reciptButton
            // 
            this.reciptButton.BackColor = System.Drawing.Color.Transparent;
            this.reciptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.reciptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciptButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptButton.ForeColor = System.Drawing.Color.White;
            this.reciptButton.Location = new System.Drawing.Point(354, 435);
            this.reciptButton.Name = "reciptButton";
            this.reciptButton.Size = new System.Drawing.Size(200, 31);
            this.reciptButton.TabIndex = 20;
            this.reciptButton.Text = "Print Recipt";
            this.reciptButton.UseVisualStyleBackColor = false;
            this.reciptButton.Click += new System.EventHandler(this.reciptButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Transparent;
            this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Location = new System.Drawing.Point(354, 480);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(200, 31);
            this.newButton.TabIndex = 21;
            this.newButton.Text = "New Order";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.BackColor = System.Drawing.Color.Transparent;
            this.errorMessage.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorMessage.Location = new System.Drawing.Point(56, 9);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 20);
            this.errorMessage.TabIndex = 22;
            this.errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bapeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 523);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.reciptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.line);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.rpgInput);
            this.Controls.Add(this.rpgLabel);
            this.Controls.Add(this.pistolsInput);
            this.Controls.Add(this.pistolsLabel);
            this.Controls.Add(this.riflesInput);
            this.Controls.Add(this.RifleLabel);
            this.Name = "bapeForm";
            this.Text = "Bape Cash";
            this.Deactivate += new System.EventHandler(this.bapeForm_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RifleLabel;
        private System.Windows.Forms.TextBox riflesInput;
        private System.Windows.Forms.Label pistolsLabel;
        private System.Windows.Forms.TextBox pistolsInput;
        private System.Windows.Forms.Label rpgLabel;
        private System.Windows.Forms.TextBox rpgInput;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button reciptButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label errorMessage;
    }
}

