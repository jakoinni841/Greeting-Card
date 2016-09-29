namespace WindowsFormsApplication1
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.greeting = new System.Windows.Forms.Label();
            this.design = new System.Windows.Forms.Label();
            this.design2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Tekton Pro Ext", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.ForeColor = System.Drawing.Color.Maroon;
            this.greeting.Location = new System.Drawing.Point(128, 30);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(155, 45);
            this.greeting.TabIndex = 0;
            this.greeting.Text = "Hello!!!!";
            // 
            // design
            // 
            this.design.AutoSize = true;
            this.design.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.design.ForeColor = System.Drawing.Color.Maroon;
            this.design.Location = new System.Drawing.Point(-97, 9);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(621, 21);
            this.design.TabIndex = 1;
            this.design.Text = "-----------------------------------------------";
            // 
            // design2
            // 
            this.design2.AutoSize = true;
            this.design2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.design2.ForeColor = System.Drawing.Color.Maroon;
            this.design2.Location = new System.Drawing.Point(-117, 287);
            this.design2.Name = "design2";
            this.design2.Size = new System.Drawing.Size(621, 21);
            this.design2.TabIndex = 2;
            this.design2.Text = "-----------------------------------------------";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(396, 317);
            this.Controls.Add(this.design2);
            this.Controls.Add(this.design);
            this.Controls.Add(this.greeting);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window";
            this.Text = "Greeting Card";
            this.Click += new System.EventHandler(this.Window_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Label design;
        private System.Windows.Forms.Label design2;
    }
}

