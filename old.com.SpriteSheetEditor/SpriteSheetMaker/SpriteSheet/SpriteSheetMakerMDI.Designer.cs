namespace SpriteSheetMaker
{
    partial class SpriteSheetMakerMDI : WPFCustomForm
    {

    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpriteSheetMakerMDI));
            this.EditorMenu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileExportImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileExportAtlas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileExportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileAssemble = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuImages = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImageBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImageSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuImageInsertImageAndSlice = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImageInsertImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImageDeleteImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSlices = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSlicesAddSlice = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSlicesRemoveSlice = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSlicesRenameSlice = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSlicesMoveSlice = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSlicesRedimSlice = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsDefault1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsDefault2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsDefault3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsDefault4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.MneuSettingsGet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSettingsBountariesSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsBoundariesAlpha = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsBoundariesDominant = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsBoundariesCustomColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsAtlasPrefixName = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsSlicingMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsSlicingGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsSlicingRowsAndCols = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsSlicingFindBlanks = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSettingsOutputResolution = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsWidthOutput1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsWidthOutput2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenutSettingsWidthOutput3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsWidthOutput4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsWithOutputSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSettingsWithOutputCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsOutputParams = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsOutputParamsLuminosity = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsOutputParamsContrast = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsOutputParamsTint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpOpenHelper = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorTools = new System.Windows.Forms.ToolStrip();
            this.IconFileNew = new System.Windows.Forms.ToolStripButton();
            this.IconFileOpen = new System.Windows.Forms.ToolStripButton();
            this.IconFileSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.IconHelp = new System.Windows.Forms.ToolStripButton();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.ListingContainer = new System.Windows.Forms.Panel();
            this.ListingPanel = new System.Windows.Forms.SplitContainer();
            this.lblSlicesListTitle = new System.Windows.Forms.Label();
            this.lblImagesListTitle = new System.Windows.Forms.Label();
            this.EditorMenu.SuspendLayout();
            this.EditorTools.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.ListingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListingPanel)).BeginInit();
            this.ListingPanel.Panel1.SuspendLayout();
            this.ListingPanel.Panel2.SuspendLayout();
            this.ListingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorMenu
            // 
            this.EditorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuEdit,
            this.MenuImages,
            this.MenuSlices,
            this.MenuSettings,
            this.MenuHelp});
            this.EditorMenu.Location = new System.Drawing.Point(0, 0);
            this.EditorMenu.Name = "EditorMenu";
            this.EditorMenu.Size = new System.Drawing.Size(725, 24);
            this.EditorMenu.TabIndex = 0;
            this.EditorMenu.Text = "MenuStrip";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileNew,
            this.MenuFileOpen,
            this.MenuFileSeparator1,
            this.MenuFileSave,
            this.MenuFileSaveAs,
            this.MenuFileSeparator2,
            this.MenuFileExportImage,
            this.MenuFileExportAtlas,
            this.MenuFileExportAll,
            this.MenuFileSeparator3,
            this.MenuFileAssemble,
            this.MenuFileSeparator4,
            this.MenuFileQuit});
            this.MenuFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(81, 20);
            this.MenuFile.Text = "&Sprite Sheet";
            this.MenuFile.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // MenuFileNew
            // 
            this.MenuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("MenuFileNew.Image")));
            this.MenuFileNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuFileNew.Name = "MenuFileNew";
            this.MenuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuFileNew.Size = new System.Drawing.Size(220, 22);
            this.MenuFileNew.Text = "&Nouveau";
            this.MenuFileNew.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("MenuFileOpen.Image")));
            this.MenuFileOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuFileOpen.Size = new System.Drawing.Size(220, 22);
            this.MenuFileOpen.Text = "&Ouvrir";
            this.MenuFileOpen.Click += new System.EventHandler(this.OpenFile);
            // 
            // MenuFileSeparator1
            // 
            this.MenuFileSeparator1.Name = "MenuFileSeparator1";
            this.MenuFileSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // MenuFileSave
            // 
            this.MenuFileSave.Enabled = false;
            this.MenuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("MenuFileSave.Image")));
            this.MenuFileSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuFileSave.Name = "MenuFileSave";
            this.MenuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuFileSave.Size = new System.Drawing.Size(220, 22);
            this.MenuFileSave.Text = "&Enregistrer";
            // 
            // MenuFileSaveAs
            // 
            this.MenuFileSaveAs.Enabled = false;
            this.MenuFileSaveAs.Name = "MenuFileSaveAs";
            this.MenuFileSaveAs.Size = new System.Drawing.Size(220, 22);
            this.MenuFileSaveAs.Text = "Enregistrer &sous";
            this.MenuFileSaveAs.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // MenuFileSeparator2
            // 
            this.MenuFileSeparator2.Name = "MenuFileSeparator2";
            this.MenuFileSeparator2.Size = new System.Drawing.Size(217, 6);
            // 
            // MenuFileExportImage
            // 
            this.MenuFileExportImage.Enabled = false;
            this.MenuFileExportImage.Name = "MenuFileExportImage";
            this.MenuFileExportImage.Size = new System.Drawing.Size(220, 22);
            this.MenuFileExportImage.Text = "Exporter &Image";
            // 
            // MenuFileExportAtlas
            // 
            this.MenuFileExportAtlas.Enabled = false;
            this.MenuFileExportAtlas.Name = "MenuFileExportAtlas";
            this.MenuFileExportAtlas.Size = new System.Drawing.Size(220, 22);
            this.MenuFileExportAtlas.Text = "Exporter &Atlas";
            // 
            // MenuFileExportAll
            // 
            this.MenuFileExportAll.Enabled = false;
            this.MenuFileExportAll.Name = "MenuFileExportAll";
            this.MenuFileExportAll.Size = new System.Drawing.Size(220, 22);
            this.MenuFileExportAll.Text = "Exporter &Tout";
            // 
            // MenuFileSeparator3
            // 
            this.MenuFileSeparator3.Name = "MenuFileSeparator3";
            this.MenuFileSeparator3.Size = new System.Drawing.Size(217, 6);
            // 
            // MenuFileAssemble
            // 
            this.MenuFileAssemble.Enabled = false;
            this.MenuFileAssemble.Name = "MenuFileAssemble";
            this.MenuFileAssemble.Size = new System.Drawing.Size(220, 22);
            this.MenuFileAssemble.Text = "Assem&blage du Sprite Sheet";
            // 
            // MenuFileSeparator4
            // 
            this.MenuFileSeparator4.Name = "MenuFileSeparator4";
            this.MenuFileSeparator4.Size = new System.Drawing.Size(217, 6);
            this.MenuFileSeparator4.Click += new System.EventHandler(this.toolStripSeparator5_Click);
            // 
            // MenuFileQuit
            // 
            this.MenuFileQuit.Name = "MenuFileQuit";
            this.MenuFileQuit.Size = new System.Drawing.Size(220, 22);
            this.MenuFileQuit.Text = "&Quitter";
            this.MenuFileQuit.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // MenuEdit
            // 
            this.MenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEditUndo,
            this.MenuEditRedo,
            this.MenuEditHistory,
            this.MenuEditSeparator1,
            this.MenuEditCut,
            this.MenuEditCopy,
            this.MenuEditPaste,
            this.MenuEditSeparator2});
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(56, 20);
            this.MenuEdit.Text = "&Edition";
            // 
            // MenuEditUndo
            // 
            this.MenuEditUndo.Enabled = false;
            this.MenuEditUndo.Image = ((System.Drawing.Image)(resources.GetObject("MenuEditUndo.Image")));
            this.MenuEditUndo.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuEditUndo.Name = "MenuEditUndo";
            this.MenuEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MenuEditUndo.Size = new System.Drawing.Size(157, 22);
            this.MenuEditUndo.Text = "&Annuler";
            // 
            // MenuEditRedo
            // 
            this.MenuEditRedo.Enabled = false;
            this.MenuEditRedo.Image = ((System.Drawing.Image)(resources.GetObject("MenuEditRedo.Image")));
            this.MenuEditRedo.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuEditRedo.Name = "MenuEditRedo";
            this.MenuEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.MenuEditRedo.Size = new System.Drawing.Size(157, 22);
            this.MenuEditRedo.Text = "&Rétablir";
            // 
            // MenuEditHistory
            // 
            this.MenuEditHistory.Enabled = false;
            this.MenuEditHistory.Name = "MenuEditHistory";
            this.MenuEditHistory.Size = new System.Drawing.Size(157, 22);
            this.MenuEditHistory.Text = "Historique";
            // 
            // MenuEditSeparator1
            // 
            this.MenuEditSeparator1.Name = "MenuEditSeparator1";
            this.MenuEditSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // MenuEditCut
            // 
            this.MenuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("MenuEditCut.Image")));
            this.MenuEditCut.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuEditCut.Name = "MenuEditCut";
            this.MenuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MenuEditCut.Size = new System.Drawing.Size(157, 22);
            this.MenuEditCut.Text = "&Couper";
            this.MenuEditCut.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // MenuEditCopy
            // 
            this.MenuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("MenuEditCopy.Image")));
            this.MenuEditCopy.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuEditCopy.Name = "MenuEditCopy";
            this.MenuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuEditCopy.Size = new System.Drawing.Size(157, 22);
            this.MenuEditCopy.Text = "&Copier";
            this.MenuEditCopy.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // MenuEditPaste
            // 
            this.MenuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("MenuEditPaste.Image")));
            this.MenuEditPaste.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuEditPaste.Name = "MenuEditPaste";
            this.MenuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MenuEditPaste.Size = new System.Drawing.Size(157, 22);
            this.MenuEditPaste.Text = "&Coller";
            this.MenuEditPaste.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // MenuEditSeparator2
            // 
            this.MenuEditSeparator2.Name = "MenuEditSeparator2";
            this.MenuEditSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // MenuImages
            // 
            this.MenuImages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuImageBackground,
            this.MenuImageSeparator1,
            this.MenuImageInsertImageAndSlice,
            this.MenuImageInsertImage,
            this.MenuImageDeleteImage});
            this.MenuImages.Enabled = false;
            this.MenuImages.Name = "MenuImages";
            this.MenuImages.Size = new System.Drawing.Size(57, 20);
            this.MenuImages.Text = "&Images";
            // 
            // MenuImageBackground
            // 
            this.MenuImageBackground.Name = "MenuImageBackground";
            this.MenuImageBackground.Size = new System.Drawing.Size(204, 22);
            this.MenuImageBackground.Text = "Image de &Fond";
            // 
            // MenuImageSeparator1
            // 
            this.MenuImageSeparator1.Name = "MenuImageSeparator1";
            this.MenuImageSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // MenuImageInsertImageAndSlice
            // 
            this.MenuImageInsertImageAndSlice.Name = "MenuImageInsertImageAndSlice";
            this.MenuImageInsertImageAndSlice.Size = new System.Drawing.Size(204, 22);
            this.MenuImageInsertImageAndSlice.Text = "&Insérer image et tranche ";
            // 
            // MenuImageInsertImage
            // 
            this.MenuImageInsertImage.Name = "MenuImageInsertImage";
            this.MenuImageInsertImage.Size = new System.Drawing.Size(204, 22);
            this.MenuImageInsertImage.Text = "&Ajouter une image";
            // 
            // MenuImageDeleteImage
            // 
            this.MenuImageDeleteImage.Name = "MenuImageDeleteImage";
            this.MenuImageDeleteImage.Size = new System.Drawing.Size(204, 22);
            this.MenuImageDeleteImage.Text = "&Supprimer une image";
            // 
            // MenuSlices
            // 
            this.MenuSlices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSlicesAddSlice,
            this.MenuSlicesRemoveSlice,
            this.MenuSlicesRenameSlice,
            this.MenuSlicesMoveSlice,
            this.MenuSlicesRedimSlice});
            this.MenuSlices.Enabled = false;
            this.MenuSlices.Name = "MenuSlices";
            this.MenuSlices.Size = new System.Drawing.Size(66, 20);
            this.MenuSlices.Text = "&Tranches";
            this.MenuSlices.Click += new System.EventHandler(this.découpesToolStripMenuItem1_Click);
            // 
            // MenuSlicesAddSlice
            // 
            this.MenuSlicesAddSlice.Name = "MenuSlicesAddSlice";
            this.MenuSlicesAddSlice.Size = new System.Drawing.Size(215, 22);
            this.MenuSlicesAddSlice.Text = "&Ajouter une tranche";
            // 
            // MenuSlicesRemoveSlice
            // 
            this.MenuSlicesRemoveSlice.Enabled = false;
            this.MenuSlicesRemoveSlice.Name = "MenuSlicesRemoveSlice";
            this.MenuSlicesRemoveSlice.Size = new System.Drawing.Size(215, 22);
            this.MenuSlicesRemoveSlice.Text = "&Supprimer la tranche";
            // 
            // MenuSlicesRenameSlice
            // 
            this.MenuSlicesRenameSlice.Enabled = false;
            this.MenuSlicesRenameSlice.Name = "MenuSlicesRenameSlice";
            this.MenuSlicesRenameSlice.Size = new System.Drawing.Size(215, 22);
            this.MenuSlicesRenameSlice.Text = "Re&nommer la tranche";
            // 
            // MenuSlicesMoveSlice
            // 
            this.MenuSlicesMoveSlice.Enabled = false;
            this.MenuSlicesMoveSlice.Name = "MenuSlicesMoveSlice";
            this.MenuSlicesMoveSlice.Size = new System.Drawing.Size(215, 22);
            this.MenuSlicesMoveSlice.Text = "&Repositionner la tranche";
            // 
            // MenuSlicesRedimSlice
            // 
            this.MenuSlicesRedimSlice.Enabled = false;
            this.MenuSlicesRedimSlice.Name = "MenuSlicesRedimSlice";
            this.MenuSlicesRedimSlice.Size = new System.Drawing.Size(215, 22);
            this.MenuSlicesRedimSlice.Text = "Re&dimensionner la tranche";
            // 
            // MenuSettings
            // 
            this.MenuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettingsDefault,
            this.MenuSettingsImport,
            this.MneuSettingsGet,
            this.MenuSettingsSeparator1,
            this.MenuSettingsBountariesSelect,
            this.MenuSettingsAtlasPrefixName,
            this.MenuSettingsSlicingMethod,
            this.MenuSettingsSeparator2,
            this.MenuSettingsOutputResolution,
            this.MenuSettingsOutputParams});
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new System.Drawing.Size(78, 20);
            this.MenuSettings.Text = "&Paramètres";
            // 
            // MenuSettingsDefault
            // 
            this.MenuSettingsDefault.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettingsDefault1,
            this.MenuSettingsDefault2,
            this.MenuSettingsDefault3,
            this.MenuSettingsDefault4});
            this.MenuSettingsDefault.Name = "MenuSettingsDefault";
            this.MenuSettingsDefault.Size = new System.Drawing.Size(247, 22);
            this.MenuSettingsDefault.Text = "&Paramètres par Défaut";
            // 
            // MenuSettingsDefault1
            // 
            this.MenuSettingsDefault1.Name = "MenuSettingsDefault1";
            this.MenuSettingsDefault1.Size = new System.Drawing.Size(193, 22);
            this.MenuSettingsDefault1.Text = "(&1) 512x512 standard";
            // 
            // MenuSettingsDefault2
            // 
            this.MenuSettingsDefault2.Name = "MenuSettingsDefault2";
            this.MenuSettingsDefault2.Size = new System.Drawing.Size(193, 22);
            this.MenuSettingsDefault2.Text = "(&2) 1024x1024 standard";
            // 
            // MenuSettingsDefault3
            // 
            this.MenuSettingsDefault3.Name = "MenuSettingsDefault3";
            this.MenuSettingsDefault3.Size = new System.Drawing.Size(193, 22);
            this.MenuSettingsDefault3.Text = "(&3) 2048x2048 standard";
            // 
            // MenuSettingsDefault4
            // 
            this.MenuSettingsDefault4.Name = "MenuSettingsDefault4";
            this.MenuSettingsDefault4.Size = new System.Drawing.Size(193, 22);
            this.MenuSettingsDefault4.Text = "(&4) 4096x4096 4K map";
            // 
            // MenuSettingsImport
            // 
            this.MenuSettingsImport.Name = "MenuSettingsImport";
            this.MenuSettingsImport.Size = new System.Drawing.Size(247, 22);
            this.MenuSettingsImport.Text = "&Importer paramètres";
            this.MenuSettingsImport.Click += new System.EventHandler(this.coucheTransparenceAlphaToolStripMenuItem_Click);
            // 
            // MneuSettingsGet
            // 
            this.MneuSettingsGet.Name = "MneuSettingsGet";
            this.MneuSettingsGet.Size = new System.Drawing.Size(247, 22);
            this.MneuSettingsGet.Text = "&Sauvegarder nouveau";
            // 
            // MenuSettingsSeparator1
            // 
            this.MenuSettingsSeparator1.Name = "MenuSettingsSeparator1";
            this.MenuSettingsSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // MenuSettingsBountariesSelect
            // 
            this.MenuSettingsBountariesSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettingsBoundariesAlpha,
            this.MenuSettingsBoundariesDominant,
            this.MenuSettingsBoundariesCustomColor});
            this.MenuSettingsBountariesSelect.Name = "MenuSettingsBountariesSelect";
            this.MenuSettingsBountariesSelect.Size = new System.Drawing.Size(247, 22);
            this.MenuSettingsBountariesSelect.Text = "&Couleur de référence pour l\'Atlas";
            // 
            // MenuSettingsBoundariesAlpha
            // 
            this.MenuSettingsBoundariesAlpha.Name = "MenuSettingsBoundariesAlpha";
            this.MenuSettingsBoundariesAlpha.Size = new System.Drawing.Size(191, 22);
            this.MenuSettingsBoundariesAlpha.Text = "&Alpha";
            // 
            // MenuSettingsBoundariesDominant
            // 
            this.MenuSettingsBoundariesDominant.Name = "MenuSettingsBoundariesDominant";
            this.MenuSettingsBoundariesDominant.Size = new System.Drawing.Size(191, 22);
            this.MenuSettingsBoundariesDominant.Text = "&Couleur Dominante";
            // 
            // MenuSettingsBoundariesCustomColor
            // 
            this.MenuSettingsBoundariesCustomColor.Name = "MenuSettingsBoundariesCustomColor";
            this.MenuSettingsBoundariesCustomColor.Size = new System.Drawing.Size(191, 22);
            this.MenuSettingsBoundariesCustomColor.Text = "&Couleur Personnalisée";
            // 
            // MenuSettingsAtlasPrefixName
            // 
            this.MenuSettingsAtlasPrefixName.Name = "MenuSettingsAtlasPrefixName";
            this.MenuSettingsAtlasPrefixName.Size = new System.Drawing.Size(247, 22);
            this.MenuSettingsAtlasPrefixName.Text = "Préfixe de l\'&Atlas ";
            // 
            // MenuSettingsSlicingMethod
            // 
            this.MenuSettingsSlicingMethod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettingsSlicingGrid,
            this.MenuSettingsSlicingRowsAndCols,
            this.MenuSettingsSlicingFindBlanks});
            this.MenuSettingsSlicingMethod.Name = "MenuSettingsSlicingMethod";
            this.MenuSettingsSlicingMethod.Size = new System.Drawing.Size(247, 22);
            this.MenuSettingsSlicingMethod.Text = "Dé&coupage auto";
            // 
            // MenuSettingsSlicingGrid
            // 
            this.MenuSettingsSlicingGrid.Name = "MenuSettingsSlicingGrid";
            this.MenuSettingsSlicingGrid.Size = new System.Drawing.Size(178, 22);
            this.MenuSettingsSlicingGrid.Text = "&Grille";
            // 
            // MenuSettingsSlicingRowsAndCols
            // 
            this.MenuSettingsSlicingRowsAndCols.Name = "MenuSettingsSlicingRowsAndCols";
            this.MenuSettingsSlicingRowsAndCols.Size = new System.Drawing.Size(178, 22);
            this.MenuSettingsSlicingRowsAndCols.Text = "&Lignes et colones";
            // 
            // MenuSettingsSlicingFindBlanks
            // 
            this.MenuSettingsSlicingFindBlanks.Name = "MenuSettingsSlicingFindBlanks";
            this.MenuSettingsSlicingFindBlanks.Size = new System.Drawing.Size(178, 22);
            this.MenuSettingsSlicingFindBlanks.Text = "&Recherche de bords";
            // 
            // MenuSettingsSeparator2
            // 
            this.MenuSettingsSeparator2.Name = "MenuSettingsSeparator2";
            this.MenuSettingsSeparator2.Size = new System.Drawing.Size(244, 6);
            // 
            // MenuSettingsOutputResolution
            // 
            this.MenuSettingsOutputResolution.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettingsWidthOutput1,
            this.MenuSettingsWidthOutput2,
            this.MenutSettingsWidthOutput3,
            this.MenuSettingsWidthOutput4,
            this.MenuSettingsWithOutputSeparator,
            this.MenuSettingsWithOutputCustom});
            this.MenuSettingsOutputResolution.Name = "MenuSettingsOutputResolution";
            this.MenuSettingsOutputResolution.Size = new System.Drawing.Size(247, 22);
            this.MenuSettingsOutputResolution.Text = "Résolution de &Sortie";
            // 
            // MenuSettingsWidthOutput1
            // 
            this.MenuSettingsWidthOutput1.Name = "MenuSettingsWidthOutput1";
            this.MenuSettingsWidthOutput1.Size = new System.Drawing.Size(163, 22);
            this.MenuSettingsWidthOutput1.Text = "(&1) 512 de large";
            // 
            // MenuSettingsWidthOutput2
            // 
            this.MenuSettingsWidthOutput2.Name = "MenuSettingsWidthOutput2";
            this.MenuSettingsWidthOutput2.Size = new System.Drawing.Size(163, 22);
            this.MenuSettingsWidthOutput2.Text = "(&2) 1024 de large";
            // 
            // MenutSettingsWidthOutput3
            // 
            this.MenutSettingsWidthOutput3.Name = "MenutSettingsWidthOutput3";
            this.MenutSettingsWidthOutput3.Size = new System.Drawing.Size(163, 22);
            this.MenutSettingsWidthOutput3.Text = "(&3) 2048 de large";
            // 
            // MenuSettingsWidthOutput4
            // 
            this.MenuSettingsWidthOutput4.Name = "MenuSettingsWidthOutput4";
            this.MenuSettingsWidthOutput4.Size = new System.Drawing.Size(163, 22);
            this.MenuSettingsWidthOutput4.Text = "(&4) 4096 de large";
            // 
            // MenuSettingsWithOutputSeparator
            // 
            this.MenuSettingsWithOutputSeparator.Name = "MenuSettingsWithOutputSeparator";
            this.MenuSettingsWithOutputSeparator.Size = new System.Drawing.Size(160, 6);
            // 
            // MenuSettingsWithOutputCustom
            // 
            this.MenuSettingsWithOutputCustom.Name = "MenuSettingsWithOutputCustom";
            this.MenuSettingsWithOutputCustom.Size = new System.Drawing.Size(163, 22);
            this.MenuSettingsWithOutputCustom.Text = "(&5) Personnalisée";
            // 
            // MenuSettingsOutputParams
            // 
            this.MenuSettingsOutputParams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettingsOutputParamsLuminosity,
            this.MenuSettingsOutputParamsContrast,
            this.MenuSettingsOutputParamsTint});
            this.MenuSettingsOutputParams.Name = "MenuSettingsOutputParams";
            this.MenuSettingsOutputParams.Size = new System.Drawing.Size(247, 22);
            this.MenuSettingsOutputParams.Text = "&Réglages de l\'image de sortie";
            this.MenuSettingsOutputParams.Click += new System.EventHandler(this.réglagesDeLimageDeSortieToolStripMenuItem_Click);
            // 
            // MenuSettingsOutputParamsLuminosity
            // 
            this.MenuSettingsOutputParamsLuminosity.Name = "MenuSettingsOutputParamsLuminosity";
            this.MenuSettingsOutputParamsLuminosity.Size = new System.Drawing.Size(133, 22);
            this.MenuSettingsOutputParamsLuminosity.Text = "&Luminosité";
            // 
            // MenuSettingsOutputParamsContrast
            // 
            this.MenuSettingsOutputParamsContrast.Name = "MenuSettingsOutputParamsContrast";
            this.MenuSettingsOutputParamsContrast.Size = new System.Drawing.Size(133, 22);
            this.MenuSettingsOutputParamsContrast.Text = "&Contraste";
            // 
            // MenuSettingsOutputParamsTint
            // 
            this.MenuSettingsOutputParamsTint.Name = "MenuSettingsOutputParamsTint";
            this.MenuSettingsOutputParamsTint.Size = new System.Drawing.Size(133, 22);
            this.MenuSettingsOutputParamsTint.Text = "&Teinte";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelpOpenHelper,
            this.MenuHelpAbout});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(24, 20);
            this.MenuHelp.Text = "?";
            this.MenuHelp.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // MenuHelpOpenHelper
            // 
            this.MenuHelpOpenHelper.Name = "MenuHelpOpenHelper";
            this.MenuHelpOpenHelper.Size = new System.Drawing.Size(147, 22);
            this.MenuHelpOpenHelper.Text = "Aide";
            // 
            // MenuHelpAbout
            // 
            this.MenuHelpAbout.Name = "MenuHelpAbout";
            this.MenuHelpAbout.Size = new System.Drawing.Size(147, 22);
            this.MenuHelpAbout.Text = "A propos de...";
            // 
            // EditorTools
            // 
            this.EditorTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconFileNew,
            this.IconFileOpen,
            this.IconFileSave,
            this.toolStripSeparator1,
            this.IconHelp});
            this.EditorTools.Location = new System.Drawing.Point(0, 24);
            this.EditorTools.Name = "EditorTools";
            this.EditorTools.Size = new System.Drawing.Size(725, 25);
            this.EditorTools.TabIndex = 1;
            this.EditorTools.Text = "ToolStrip";
            // 
            // IconFileNew
            // 
            this.IconFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IconFileNew.Image = ((System.Drawing.Image)(resources.GetObject("IconFileNew.Image")));
            this.IconFileNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.IconFileNew.Name = "IconFileNew";
            this.IconFileNew.Size = new System.Drawing.Size(23, 22);
            this.IconFileNew.Text = "Nouveau";
            this.IconFileNew.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // IconFileOpen
            // 
            this.IconFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IconFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("IconFileOpen.Image")));
            this.IconFileOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.IconFileOpen.Name = "IconFileOpen";
            this.IconFileOpen.Size = new System.Drawing.Size(23, 22);
            this.IconFileOpen.Text = "Ouvrir";
            this.IconFileOpen.Click += new System.EventHandler(this.OpenFile);
            // 
            // IconFileSave
            // 
            this.IconFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IconFileSave.Image = ((System.Drawing.Image)(resources.GetObject("IconFileSave.Image")));
            this.IconFileSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.IconFileSave.Name = "IconFileSave";
            this.IconFileSave.Size = new System.Drawing.Size(23, 22);
            this.IconFileSave.Text = "Enregistrer";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // IconHelp
            // 
            this.IconHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IconHelp.Image = ((System.Drawing.Image)(resources.GetObject("IconHelp.Image")));
            this.IconHelp.ImageTransparentColor = System.Drawing.Color.Black;
            this.IconHelp.Name = "IconHelp";
            this.IconHelp.Size = new System.Drawing.Size(23, 22);
            this.IconHelp.Text = "Aide";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusBar});
            this.StatusBar.Location = new System.Drawing.Point(0, 492);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(725, 22);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "StatusStrip";
            this.StatusBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.EditorStatusBar_ItemClicked);
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(27, 17);
            this.lblStatusBar.Text = "État";
            // 
            // ToolTips
            // 
            this.ToolTips.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_Popup);
            // 
            // ListingContainer
            // 
            this.ListingContainer.Controls.Add(this.ListingPanel);
            this.ListingContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListingContainer.Location = new System.Drawing.Point(550, 49);
            this.ListingContainer.Name = "ListingContainer";
            this.ListingContainer.Size = new System.Drawing.Size(175, 443);
            this.ListingContainer.TabIndex = 6;
            // 
            // ListingPanel
            // 
            this.ListingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListingPanel.Location = new System.Drawing.Point(0, 0);
            this.ListingPanel.Name = "ListingPanel";
            this.ListingPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ListingPanel.Panel1
            // 
            this.ListingPanel.Panel1.Controls.Add(this.lblSlicesListTitle);
            this.ListingPanel.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // ListingPanel.Panel2
            // 
            this.ListingPanel.Panel2.Controls.Add(this.lblImagesListTitle);
            this.ListingPanel.Size = new System.Drawing.Size(175, 443);
            this.ListingPanel.SplitterDistance = 58;
            this.ListingPanel.TabIndex = 0;
            // 
            // lblSlicesListTitle
            // 
            this.lblSlicesListTitle.AutoSize = true;
            this.lblSlicesListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlicesListTitle.Location = new System.Drawing.Point(3, 0);
            this.lblSlicesListTitle.Name = "lblSlicesListTitle";
            this.lblSlicesListTitle.Size = new System.Drawing.Size(59, 20);
            this.lblSlicesListTitle.TabIndex = 0;
            this.lblSlicesListTitle.Text = "Slices :";
            // 
            // lblImagesListTitle
            // 
            this.lblImagesListTitle.AutoSize = true;
            this.lblImagesListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagesListTitle.Location = new System.Drawing.Point(3, 0);
            this.lblImagesListTitle.Name = "lblImagesListTitle";
            this.lblImagesListTitle.Size = new System.Drawing.Size(70, 20);
            this.lblImagesListTitle.TabIndex = 1;
            this.lblImagesListTitle.Text = "Images :";
            // 
            // SpriteSheetMakerMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 514);
            this.Controls.Add(this.ListingContainer);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.EditorTools);
            this.Controls.Add(this.EditorMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.EditorMenu;
            this.Name = "SpriteSheetMakerMDI";
            this.Text = "Sprite Sheet Maker";
            this.Load += new System.EventHandler(this.SpriteSheetMakerMDI_Load);
            this.EditorMenu.ResumeLayout(false);
            this.EditorMenu.PerformLayout();
            this.EditorTools.ResumeLayout(false);
            this.EditorTools.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ListingContainer.ResumeLayout(false);
            this.ListingPanel.Panel1.ResumeLayout(false);
            this.ListingPanel.Panel1.PerformLayout();
            this.ListingPanel.Panel2.ResumeLayout(false);
            this.ListingPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListingPanel)).EndInit();
            this.ListingPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip EditorMenu;
        private System.Windows.Forms.ToolStrip EditorTools;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator1;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator2;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator4;
        private System.Windows.Forms.ToolStripSeparator MenuEditSeparator1;
        private System.Windows.Forms.ToolStripSeparator MenuEditSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusBar;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuFileNew;
        private System.Windows.Forms.ToolStripMenuItem MenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuFileSave;
        private System.Windows.Forms.ToolStripMenuItem MenuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuFileQuit;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuEditRedo;
        private System.Windows.Forms.ToolStripMenuItem MenuEditCut;
        private System.Windows.Forms.ToolStripMenuItem MenuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuEditPaste;
        private System.Windows.Forms.ToolStripButton IconFileNew;
        private System.Windows.Forms.ToolStripButton IconFileOpen;
        private System.Windows.Forms.ToolStripButton IconFileSave;
        private System.Windows.Forms.ToolStripButton IconHelp;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.ToolStripMenuItem MenuImages;
        private System.Windows.Forms.ToolStripMenuItem MenuImageBackground;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExportAll;
        private System.Windows.Forms.ToolStripMenuItem MenuSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsImport;
        private System.Windows.Forms.ToolStripMenuItem MneuSettingsGet;
        private System.Windows.Forms.ToolStripSeparator MenuSettingsSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsBountariesSelect;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsBoundariesAlpha;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsBoundariesDominant;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsBoundariesCustomColor;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsAtlasPrefixName;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsSlicingMethod;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsSlicingGrid;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsSlicingRowsAndCols;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsSlicingFindBlanks;
        private System.Windows.Forms.ToolStripSeparator MenuSettingsSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsOutputResolution;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsOutputParams;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsOutputParamsLuminosity;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsOutputParamsContrast;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsOutputParamsTint;
        private System.Windows.Forms.ToolStripMenuItem MenuSlices;
        private System.Windows.Forms.ToolStripMenuItem MenuSlicesAddSlice;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExportImage;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExportAtlas;
        private System.Windows.Forms.ToolStripMenuItem MenuSlicesRemoveSlice;
        private System.Windows.Forms.ToolStripMenuItem MenuSlicesRenameSlice;
        private System.Windows.Forms.ToolStripMenuItem MenuSlicesMoveSlice;
        private System.Windows.Forms.ToolStripMenuItem MenuSlicesRedimSlice;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuFileAssemble;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator MenuImageSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuImageInsertImageAndSlice;
        private System.Windows.Forms.ToolStripMenuItem MenuImageInsertImage;
        private System.Windows.Forms.ToolStripMenuItem MenuImageDeleteImage;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpOpenHelper;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpAbout;

        private System.Windows.Forms.Panel ListingContainer;
        private System.Windows.Forms.SplitContainer ListingPanel;
        private System.Windows.Forms.Label lblSlicesListTitle;
        private System.Windows.Forms.Label lblImagesListTitle;
        private System.Windows.Forms.ToolStripMenuItem MenuEditUndo;
        private System.Windows.Forms.ToolStripMenuItem MenuEditHistory;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsDefault;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsDefault1;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsDefault2;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsDefault3;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsDefault4;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsWidthOutput1;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsWidthOutput2;
        private System.Windows.Forms.ToolStripMenuItem MenutSettingsWidthOutput3;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsWidthOutput4;
        private System.Windows.Forms.ToolStripSeparator MenuSettingsWithOutputSeparator;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsWithOutputCustom;
    }
}



