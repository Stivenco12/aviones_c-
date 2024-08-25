namespace avienes_guerra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.enemyone = new System.Windows.Forms.PictureBox();
            this.enemytwo = new System.Windows.Forms.PictureBox();
            this.enemytre = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.txtscore = new System.Windows.Forms.Label();
            this.gamerTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemyone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemytwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemytre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyone
            // 
            this.enemyone.Image = global::avienes_guerra.Properties.Resources.enemy;
            this.enemyone.Location = new System.Drawing.Point(48, 45);
            this.enemyone.Name = "enemyone";
            this.enemyone.Size = new System.Drawing.Size(100, 85);
            this.enemyone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyone.TabIndex = 0;
            this.enemyone.TabStop = false;
            // 
            // enemytwo
            // 
            this.enemytwo.Image = global::avienes_guerra.Properties.Resources.enemy;
            this.enemytwo.Location = new System.Drawing.Point(284, 45);
            this.enemytwo.Name = "enemytwo";
            this.enemytwo.Size = new System.Drawing.Size(100, 85);
            this.enemytwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemytwo.TabIndex = 1;
            this.enemytwo.TabStop = false;
            // 
            // enemytre
            // 
            this.enemytre.Image = global::avienes_guerra.Properties.Resources.enemy;
            this.enemytre.Location = new System.Drawing.Point(525, 45);
            this.enemytre.Name = "enemytre";
            this.enemytre.Size = new System.Drawing.Size(100, 85);
            this.enemytre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemytre.TabIndex = 2;
            this.enemytre.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Image = global::avienes_guerra.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(323, 447);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(7, 27);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bullet.TabIndex = 3;
            this.bullet.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::avienes_guerra.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(284, 548);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(110, 98);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // txtscore
            // 
            this.txtscore.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.Location = new System.Drawing.Point(12, 237);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(653, 183);
            this.txtscore.TabIndex = 5;
            this.txtscore.Text = "0";
            this.txtscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gamerTimer
            // 
            this.gamerTimer.Interval = 20;
            this.gamerTimer.Tick += new System.EventHandler(this.mainGamerTimerEvents);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 658);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemytre);
            this.Controls.Add(this.enemytwo);
            this.Controls.Add(this.enemyone);
            this.Controls.Add(this.txtscore);
            this.Name = "Form1";
            this.Text = "avioncito";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDowm);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.enemyone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemytwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemytre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox enemyone;
        private System.Windows.Forms.PictureBox enemytwo;
        private System.Windows.Forms.PictureBox enemytre;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.Timer gamerTimer;
    }
}

