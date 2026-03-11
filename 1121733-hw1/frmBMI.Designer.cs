namespace _1121733_hw1
{
    partial class frmBMI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpInput = new GroupBox();
            btnRun = new Button();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            lblWeight = new Label();
            lblHeight = new Label();
            grpOutput = new GroupBox();
            lblResult = new Label();
            lblBMI = new Label();
            grpInput.SuspendLayout();
            grpOutput.SuspendLayout();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnRun);
            grpInput.Controls.Add(txtWeight);
            grpInput.Controls.Add(txtHeight);
            grpInput.Controls.Add(lblWeight);
            grpInput.Controls.Add(lblHeight);
            grpInput.Location = new Point(39, 45);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(368, 100);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "輸入";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(244, 22);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(101, 58);
            btnRun.TabIndex = 2;
            btnRun.Text = "計算";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // txtWeight
            // 
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Location = new Point(111, 57);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(85, 23);
            txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            txtHeight.BorderStyle = BorderStyle.FixedSingle;
            txtHeight.Location = new Point(111, 22);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(85, 23);
            txtHeight.TabIndex = 2;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(22, 65);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(53, 15);
            lblWeight.TabIndex = 1;
            lblWeight.Text = "體重(kg)";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(22, 28);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(56, 15);
            lblHeight.TabIndex = 0;
            lblHeight.Text = "身高(cm)";
            // 
            // grpOutput
            // 
            grpOutput.Controls.Add(lblResult);
            grpOutput.Controls.Add(lblBMI);
            grpOutput.Location = new Point(39, 199);
            grpOutput.Name = "grpOutput";
            grpOutput.Size = new Size(284, 100);
            grpOutput.TabIndex = 1;
            grpOutput.TabStop = false;
            grpOutput.Text = "計算結果";
            grpOutput.Enter += grpOutput_Enter;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.ImageAlign = ContentAlignment.TopCenter;
            lblResult.Location = new Point(137, 57);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(109, 15);
            lblResult.TabIndex = 3;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.UseWaitCursor = true;
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Location = new Point(22, 57);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(109, 15);
            lblBMI.TabIndex = 2;
            lblBMI.Text = "身體質量指數(BMI)";
            // 
            // frmBMI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpOutput);
            Controls.Add(grpInput);
            Name = "frmBMI";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BMI計算機";
            Load += frmBMI_Load;
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            grpOutput.ResumeLayout(false);
            grpOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInput;
        private GroupBox grpOutput;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblBMI;
        private Button btnRun;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private Label lblResult;
    }
}
