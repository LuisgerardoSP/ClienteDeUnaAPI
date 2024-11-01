namespace VisorTerremotos
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            cID = new DataGridViewTextBoxColumn();
            cMag = new DataGridViewTextBoxColumn();
            cPlace = new DataGridViewTextBoxColumn();
            cTime = new DataGridViewTextBoxColumn();
            cUpdate = new DataGridViewTextBoxColumn();
            cTz = new DataGridViewTextBoxColumn();
            cUrl = new DataGridViewTextBoxColumn();
            cDetail = new DataGridViewTextBoxColumn();
            cFelt = new DataGridViewTextBoxColumn();
            cCdi = new DataGridViewTextBoxColumn();
            cMmi = new DataGridViewTextBoxColumn();
            cAlert = new DataGridViewTextBoxColumn();
            cStatus = new DataGridViewTextBoxColumn();
            CTsunami = new DataGridViewTextBoxColumn();
            cSig = new DataGridViewTextBoxColumn();
            cNet = new DataGridViewTextBoxColumn();
            cCode = new DataGridViewTextBoxColumn();
            cIds = new DataGridViewTextBoxColumn();
            cSources = new DataGridViewTextBoxColumn();
            cTypes = new DataGridViewTextBoxColumn();
            cNst = new DataGridViewTextBoxColumn();
            cDmin = new DataGridViewTextBoxColumn();
            cRms = new DataGridViewTextBoxColumn();
            cGap = new DataGridViewTextBoxColumn();
            cMagType = new DataGridViewTextBoxColumn();
            cType = new DataGridViewTextBoxColumn();
            cTittle = new DataGridViewTextBoxColumn();
            BtnSolicitarInformacion = new Button();
            nu1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nu1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cID, cMag, cPlace, cTime, cUpdate, cTz, cUrl, cDetail, cFelt, cCdi, cMmi, cAlert, cStatus, CTsunami, cSig, cNet, cCode, cIds, cSources, cTypes, cNst, cDmin, cRms, cGap, cMagType, cType, cTittle });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(735, 269);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cID
            // 
            cID.HeaderText = "ID";
            cID.Name = "cID";
            // 
            // cMag
            // 
            cMag.HeaderText = "Mag";
            cMag.Name = "cMag";
            // 
            // cPlace
            // 
            cPlace.HeaderText = "Place";
            cPlace.Name = "cPlace";
            // 
            // cTime
            // 
            cTime.HeaderText = "Time";
            cTime.Name = "cTime";
            // 
            // cUpdate
            // 
            cUpdate.HeaderText = "Update";
            cUpdate.Name = "cUpdate";
            // 
            // cTz
            // 
            cTz.HeaderText = "Tz";
            cTz.Name = "cTz";
            // 
            // cUrl
            // 
            cUrl.HeaderText = "Url";
            cUrl.Name = "cUrl";
            // 
            // cDetail
            // 
            cDetail.HeaderText = "Detail";
            cDetail.Name = "cDetail";
            // 
            // cFelt
            // 
            cFelt.HeaderText = "Column1";
            cFelt.Name = "cFelt";
            // 
            // cCdi
            // 
            cCdi.HeaderText = "Cdi";
            cCdi.Name = "cCdi";
            // 
            // cMmi
            // 
            cMmi.HeaderText = "Mmi";
            cMmi.Name = "cMmi";
            // 
            // cAlert
            // 
            cAlert.HeaderText = "Alert";
            cAlert.Name = "cAlert";
            // 
            // cStatus
            // 
            cStatus.HeaderText = "Status";
            cStatus.Name = "cStatus";
            // 
            // CTsunami
            // 
            CTsunami.HeaderText = "Tsunami";
            CTsunami.Name = "CTsunami";
            // 
            // cSig
            // 
            cSig.HeaderText = "Sig";
            cSig.Name = "cSig";
            // 
            // cNet
            // 
            cNet.HeaderText = "Net";
            cNet.Name = "cNet";
            // 
            // cCode
            // 
            cCode.HeaderText = "Code";
            cCode.Name = "cCode";
            // 
            // cIds
            // 
            cIds.HeaderText = "Ids";
            cIds.Name = "cIds";
            // 
            // cSources
            // 
            cSources.HeaderText = "Sources";
            cSources.Name = "cSources";
            // 
            // cTypes
            // 
            cTypes.HeaderText = "Types";
            cTypes.Name = "cTypes";
            // 
            // cNst
            // 
            cNst.HeaderText = "Nst";
            cNst.Name = "cNst";
            // 
            // cDmin
            // 
            cDmin.HeaderText = "Dmin";
            cDmin.Name = "cDmin";
            // 
            // cRms
            // 
            cRms.HeaderText = "Rms";
            cRms.Name = "cRms";
            // 
            // cGap
            // 
            cGap.HeaderText = "Gap";
            cGap.Name = "cGap";
            // 
            // cMagType
            // 
            cMagType.HeaderText = "MagType";
            cMagType.Name = "cMagType";
            // 
            // cType
            // 
            cType.HeaderText = "Type";
            cType.Name = "cType";
            // 
            // cTittle
            // 
            cTittle.HeaderText = "Tittle";
            cTittle.Name = "cTittle";
            // 
            // BtnSolicitarInformacion
            // 
            BtnSolicitarInformacion.Location = new Point(12, 302);
            BtnSolicitarInformacion.Name = "BtnSolicitarInformacion";
            BtnSolicitarInformacion.Size = new Size(110, 42);
            BtnSolicitarInformacion.TabIndex = 1;
            BtnSolicitarInformacion.Text = "Solicitar Información";
            BtnSolicitarInformacion.UseVisualStyleBackColor = true;
            BtnSolicitarInformacion.Click += button1_Click;
            // 
            // nu1
            // 
            nu1.Location = new Point(12, 362);
            nu1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nu1.Name = "nu1";
            nu1.Size = new Size(120, 23);
            nu1.TabIndex = 2;
            nu1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nu1);
            Controls.Add(BtnSolicitarInformacion);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nu1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtnSolicitarInformacion;
        private DataGridViewTextBoxColumn cID;
        private DataGridViewTextBoxColumn cMag;
        private DataGridViewTextBoxColumn cPlace;
        private DataGridViewTextBoxColumn cTime;
        private DataGridViewTextBoxColumn cUpdate;
        private DataGridViewTextBoxColumn cTz;
        private DataGridViewTextBoxColumn cUrl;
        private DataGridViewTextBoxColumn cDetail;
        private DataGridViewTextBoxColumn cFelt;
        private DataGridViewTextBoxColumn cCdi;
        private DataGridViewTextBoxColumn cMmi;
        private DataGridViewTextBoxColumn cAlert;
        private DataGridViewTextBoxColumn cStatus;
        private DataGridViewTextBoxColumn CTsunami;
        private DataGridViewTextBoxColumn cSig;
        private DataGridViewTextBoxColumn cNet;
        private DataGridViewTextBoxColumn cCode;
        private DataGridViewTextBoxColumn cIds;
        private DataGridViewTextBoxColumn cSources;
        private DataGridViewTextBoxColumn cTypes;
        private DataGridViewTextBoxColumn cNst;
        private DataGridViewTextBoxColumn cDmin;
        private DataGridViewTextBoxColumn cRms;
        private DataGridViewTextBoxColumn cGap;
        private DataGridViewTextBoxColumn cMagType;
        private DataGridViewTextBoxColumn cType;
        private DataGridViewTextBoxColumn cTittle;
        private NumericUpDown nu1;
    }
}
