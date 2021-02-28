namespace XO.App
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXPlayer = new System.Windows.Forms.TextBox();
            this.txtOPlayer = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnPlayWithComputer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player X Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(322, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player O Name:";
            // 
            // txtXPlayer
            // 
            this.txtXPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtXPlayer.Location = new System.Drawing.Point(10, 42);
            this.txtXPlayer.Multiline = true;
            this.txtXPlayer.Name = "txtXPlayer";
            this.txtXPlayer.Size = new System.Drawing.Size(240, 55);
            this.txtXPlayer.TabIndex = 2;
            // 
            // txtOPlayer
            // 
            this.txtOPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtOPlayer.Location = new System.Drawing.Point(324, 42);
            this.txtOPlayer.Multiline = true;
            this.txtOPlayer.Name = "txtOPlayer";
            this.txtOPlayer.Size = new System.Drawing.Size(240, 55);
            this.txtOPlayer.TabIndex = 3;
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSub.Location = new System.Drawing.Point(36, 123);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(240, 80);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "ثبت";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlayWithComputer
            // 
            this.btnPlayWithComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPlayWithComputer.Location = new System.Drawing.Point(293, 123);
            this.btnPlayWithComputer.Name = "btnPlayWithComputer";
            this.btnPlayWithComputer.Size = new System.Drawing.Size(240, 80);
            this.btnPlayWithComputer.TabIndex = 5;
            this.btnPlayWithComputer.Text = "بازی با کامپیوتر";
            this.btnPlayWithComputer.UseVisualStyleBackColor = true;
            this.btnPlayWithComputer.Click += new System.EventHandler(this.btnPlayWithComputer_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 232);
            this.Controls.Add(this.btnPlayWithComputer);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.txtOPlayer);
            this.Controls.Add(this.txtXPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXPlayer;
        private System.Windows.Forms.TextBox txtOPlayer;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnPlayWithComputer;
    }
}