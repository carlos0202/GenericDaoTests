namespace GenericDaoTests
{
    partial class FrmGDAOTests
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
            this.rtbQuery = new System.Windows.Forms.RichTextBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblQuery = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.rtbDirections = new System.Windows.Forms.RichTextBox();
            this.rtbValues = new System.Windows.Forms.RichTextBox();
            this.lblValues = new System.Windows.Forms.Label();
            this.IsDirections = new System.Windows.Forms.RadioButton();
            this.IsParameterNames = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rtbQuery
            // 
            this.rtbQuery.Location = new System.Drawing.Point(12, 42);
            this.rtbQuery.Name = "rtbQuery";
            this.rtbQuery.Size = new System.Drawing.Size(450, 72);
            this.rtbQuery.TabIndex = 0;
            this.rtbQuery.Text = "";
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(12, 338);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(450, 167);
            this.rtbResult.TabIndex = 1;
            this.rtbResult.Text = "";
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(374, 278);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(88, 31);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Verificar";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(374, 511);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 31);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Borrar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuery.Location = new System.Drawing.Point(8, 20);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(439, 19);
            this.lblQuery.TabIndex = 4;
            this.lblQuery.Text = "Inserte el query parametrizado. (Use @ para los parametros)";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(9, 316);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(84, 19);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Resultado:";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.Location = new System.Drawing.Point(9, 126);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(432, 19);
            this.lblDirections.TabIndex = 6;
            this.lblDirections.Text = "Inserte direcciones de parametros o nombres( delim. con ,)";
            // 
            // rtbDirections
            // 
            this.rtbDirections.Location = new System.Drawing.Point(12, 148);
            this.rtbDirections.Name = "rtbDirections";
            this.rtbDirections.Size = new System.Drawing.Size(450, 39);
            this.rtbDirections.TabIndex = 7;
            this.rtbDirections.Text = "";
            // 
            // rtbValues
            // 
            this.rtbValues.Location = new System.Drawing.Point(12, 223);
            this.rtbValues.Name = "rtbValues";
            this.rtbValues.Size = new System.Drawing.Size(450, 39);
            this.rtbValues.TabIndex = 9;
            this.rtbValues.Text = "";
            // 
            // lblValues
            // 
            this.lblValues.AutoSize = true;
            this.lblValues.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValues.Location = new System.Drawing.Point(8, 201);
            this.lblValues.Name = "lblValues";
            this.lblValues.Size = new System.Drawing.Size(405, 19);
            this.lblValues.TabIndex = 8;
            this.lblValues.Text = "Inserte los valores de los parametros (delimitados con ,)";
            // 
            // IsDirections
            // 
            this.IsDirections.AutoSize = true;
            this.IsDirections.Checked = true;
            this.IsDirections.Location = new System.Drawing.Point(36, 278);
            this.IsDirections.Name = "IsDirections";
            this.IsDirections.Size = new System.Drawing.Size(81, 17);
            this.IsDirections.TabIndex = 10;
            this.IsDirections.TabStop = true;
            this.IsDirections.Text = "Direcciones";
            this.IsDirections.UseVisualStyleBackColor = true;
            // 
            // IsParameterNames
            // 
            this.IsParameterNames.AutoSize = true;
            this.IsParameterNames.Location = new System.Drawing.Point(128, 278);
            this.IsParameterNames.Name = "IsParameterNames";
            this.IsParameterNames.Size = new System.Drawing.Size(78, 17);
            this.IsParameterNames.TabIndex = 11;
            this.IsParameterNames.TabStop = true;
            this.IsParameterNames.Text = "Parametros";
            this.IsParameterNames.UseVisualStyleBackColor = true;
            // 
            // FrmGDAOTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 550);
            this.Controls.Add(this.IsParameterNames);
            this.Controls.Add(this.IsDirections);
            this.Controls.Add(this.rtbValues);
            this.Controls.Add(this.lblValues);
            this.Controls.Add(this.rtbDirections);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.rtbQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmGDAOTests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generic DAO Tests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbQuery;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.RichTextBox rtbDirections;
        private System.Windows.Forms.RichTextBox rtbValues;
        private System.Windows.Forms.Label lblValues;
        private System.Windows.Forms.RadioButton IsDirections;
        private System.Windows.Forms.RadioButton IsParameterNames;
    }
}

