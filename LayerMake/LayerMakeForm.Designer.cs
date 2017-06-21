namespace LayerMake
{
    partial class LayerMakeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayerMakeForm));
            this.dataStateListBox = new System.Windows.Forms.ListBox();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.moreCatButton = new System.Windows.Forms.Button();
            this.dataStateLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.entityTypeLabel = new System.Windows.Forms.Label();
            this.entityTypeListBox = new System.Windows.Forms.ListBox();
            this.entityDescLabel = new System.Windows.Forms.Label();
            this.moreEntButton = new System.Windows.Forms.Button();
            this.entityDescListBox = new System.Windows.Forms.ListBox();
            this.layersListBox = new System.Windows.Forms.ListBox();
            this.layersLabel = new System.Windows.Forms.Label();
            this.layerLabel = new System.Windows.Forms.Label();
            this.layerTextBox = new System.Windows.Forms.TextBox();
            this.ltypeButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.makeButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dataStateListBox
            // 
            this.dataStateListBox.FormattingEnabled = true;
            this.dataStateListBox.Items.AddRange(new object[] {
            "A\tAs-built",
            "D\tDrawing",
            "F\tFuture",
            "P\tProposed",
            "W\tWorking",
            "X\tExisting"});
            this.dataStateListBox.Location = new System.Drawing.Point(12, 42);
            this.dataStateListBox.Name = "dataStateListBox";
            this.dataStateListBox.Size = new System.Drawing.Size(190, 82);
            this.dataStateListBox.TabIndex = 2;
            this.dataStateListBox.SelectedIndexChanged += new System.EventHandler(this.dataStateListBox_SelectedIndexChanged);
            // 
            // categoryListBox
            // 
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.Items.AddRange(new object[] {
            "AM\tAmenities ",
            "BG\tBuilding ",
            "CA\tCable T.V. ",
            "DT\tDetention ",
            "EL\tElectrical/Power ",
            "EN\tEngineering ",
            "EC\tErosion Control ",
            "FO\tFiber Optic Cable ",
            "GA\tGas ",
            "GI\tGeneral Information ",
            "GF\tGolf Course ",
            "GR\tGrading ",
            "IN\tInsert ",
            "IR\tIrrigation ",
            "LL\tLot Lines/ROW/Boundary ",
            "RD\tRoad ",
            "SS\tSanitary Sewer ",
            "SH\tSheet ",
            "SD\tStorm Drain ",
            "SC\tSurvey Control ",
            "TE\tTelephone ",
            "TP\tTopography ",
            "TF\tTopographic Features ",
            "UT\tUtility",
            "WT\tWater"});
            this.categoryListBox.Location = new System.Drawing.Point(232, 42);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(190, 95);
            this.categoryListBox.TabIndex = 2;
            this.categoryListBox.SelectedIndexChanged += new System.EventHandler(this.categoryListBox_SelectedIndexChanged);
            // 
            // moreCatButton
            // 
            this.moreCatButton.Location = new System.Drawing.Point(347, 12);
            this.moreCatButton.Name = "moreCatButton";
            this.moreCatButton.Size = new System.Drawing.Size(75, 23);
            this.moreCatButton.TabIndex = 3;
            this.moreCatButton.Text = "More...";
            this.moreCatButton.UseVisualStyleBackColor = true;
            this.moreCatButton.Click += new System.EventHandler(this.moreCatButton_Click);
            // 
            // dataStateLabel
            // 
            this.dataStateLabel.AutoSize = true;
            this.dataStateLabel.Location = new System.Drawing.Point(12, 17);
            this.dataStateLabel.Name = "dataStateLabel";
            this.dataStateLabel.Size = new System.Drawing.Size(58, 13);
            this.dataStateLabel.TabIndex = 4;
            this.dataStateLabel.Text = "Data State";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(232, 17);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 5;
            this.categoryLabel.Text = "Category";
            // 
            // entityTypeLabel
            // 
            this.entityTypeLabel.AutoSize = true;
            this.entityTypeLabel.Location = new System.Drawing.Point(12, 148);
            this.entityTypeLabel.Name = "entityTypeLabel";
            this.entityTypeLabel.Size = new System.Drawing.Size(60, 13);
            this.entityTypeLabel.TabIndex = 8;
            this.entityTypeLabel.Text = "Entity Type";
            // 
            // entityTypeListBox
            // 
            this.entityTypeListBox.FormattingEnabled = true;
            this.entityTypeListBox.Items.AddRange(new object[] {
            "D\tDimensions",
            "H\tHatch",
            "L\tLine",
            "P\tPoint",
            "S\tSymbol",
            "T\tText",
            "O\tCivil 3D Object",
            "E\tCivil 3D Label"});
            this.entityTypeListBox.Location = new System.Drawing.Point(12, 173);
            this.entityTypeListBox.Name = "entityTypeListBox";
            this.entityTypeListBox.Size = new System.Drawing.Size(190, 108);
            this.entityTypeListBox.TabIndex = 6;
            this.entityTypeListBox.SelectedIndexChanged += new System.EventHandler(this.entityTypeListBox_SelectedIndexChanged);
            // 
            // entityDescLabel
            // 
            this.entityDescLabel.AutoSize = true;
            this.entityDescLabel.Location = new System.Drawing.Point(232, 148);
            this.entityDescLabel.Name = "entityDescLabel";
            this.entityDescLabel.Size = new System.Drawing.Size(89, 13);
            this.entityDescLabel.TabIndex = 10;
            this.entityDescLabel.Text = "Entity Descriptors";
            // 
            // moreEntButton
            // 
            this.moreEntButton.Location = new System.Drawing.Point(347, 143);
            this.moreEntButton.Name = "moreEntButton";
            this.moreEntButton.Size = new System.Drawing.Size(75, 23);
            this.moreEntButton.TabIndex = 9;
            this.moreEntButton.Text = "More...";
            this.moreEntButton.UseVisualStyleBackColor = true;
            this.moreEntButton.Click += new System.EventHandler(this.moreEntButton_Click);
            // 
            // entityDescListBox
            // 
            this.entityDescListBox.FormattingEnabled = true;
            this.entityDescListBox.Items.AddRange(new object[] {
            "Z\tFiller Character ",
            "ABN\tAbandoned ",
            "ACC\tAccess ",
            "ADD\tAddress ",
            "ADS\tAdvanced Drainage Systems ",
            "AIR\tAir (Valve) ",
            "ALD\tAlder ",
            "ALG\tAlignment ",
            "APW\tAmerican Public Works Association ",
            "AST\tAmerican Society for Testing Material ",
            "ANC\tAnchor ",
            "ANG\tAngle ",
            "ANO\tAnnotate ",
            "APT\tApartment ",
            "APL\tApple ",
            "APP\tApproval ",
            "ARE\tArea ",
            "AR\tArrow ",
            "AC\tAsbestos Cement ",
            "ASP\tAsphalt ",
            "ATB\tAsphalt Treated Base ",
            "ACV\tAutomatic Control Value ",
            "AVB\tAutomatic Vacuum Breaker ",
            "AV\tCombination Air & Vacuum Relief Valve ",
            "BCK\tBack ",
            "BLV\tBall Valve ",
            "BNK\tBank ",
            "BBW\tBarbed Wire ",
            "BAR\tBarrier ",
            "BSN\tBasin ",
            "BBH\tBasket Ball Hoop ",
            "BRG\tBearing ",
            "BOC\tBeginning of Curb ",
            "BM\tBenchmark ",
            "BRM\tBerm ",
            "BW\tBike Way ",
            "BIO\tBioswale ",
            "BLK\tBlock ",
            "BO\tBlow Off ",
            "BOL\tBollard ",
            "BDR\tBorder ",
            "BOR\tBoring ",
            "BOT\tBottom ",
            "BDY\tBoundary ",
            "BX\tBox ",
            "BRK\tBreak ",
            "BL\tBreak Line ",
            "BK\tBrick ",
            "BRD\tBridge ",
            "BRU\tBrush ",
            "BUF\tBuffer ",
            "BG\tBuilding ",
            "BSL\tBuilding Setback Line ",
            "BLK\tBulkhead ",
            "BUR\tBuried ",
            "BV\tButterfly Valve ",
            "CAN\tCanopy ",
            "CBL\tCable ",
            "CAL\tCaliper ",
            "CPT\tCarport ",
            "CRT\tCart ",
            "CST\tCast Iron ",
            "CAT\tCatch ",
            "CB\tCatch Basin ",
            "CED\tCedar ",
            "CEL\tCell ",
            "CTR\tCenter ",
            "CL\tCenterline ",
            "CTF\tCertification ",
            "CLK\tChain Link ",
            "CHN\tChannel ",
            "CKD\tCheckdam ",
            "CHY\tCherry ",
            "CO\tClean Out",
            "CLR\tClearance ",
            "CLG\tClearing ",
            "CP\tClip ",
            "CLD\tCloud ",
            "CLP\tClump/Cluster ",
            "CC\tConcrete ",
            "CDO\tCondo ",
            "CD\tConduit ",
            "CON\tConifer ",
            "CNS\tConstruction ",
            "CNT\tContinuous ",
            "CN\tContour ",
            "CTL\tControl ",
            "TIC\tCoordinate, or Grid Mark ",
            "COR\tCorner ",
            "CM\tCorrugated Metal ",
            "CRK\tCreek ",
            "CR\tCross ",
            "CRS\tCrossing ",
            "CV\tCulvert ",
            "CG\tCurb and Gutter ",
            "CI\tCurb Inlet ",
            "CU\tCurb ",
            "CUT\tCut ",
            "DAT\tDatum ",
            "DAY\tDaylight ",
            "DEA\tDead ",
            "DEC\tDeciduous ",
            "DCK\tDeck ",
            "DEP\tDepression",
            "DSC\tDescriptor",
            "DES\tDesign ",
            "DJ\tDesignjet Plotter ",
            "D\tDetail ",
            "DT\tDetention ",
            "DIA\tDiameter ",
            "DIM\tDimension ",
            "DIR\tDirection ",
            "DRT\tDirt ",
            "DSP\tDispersion ",
            "DST\tDistance ",
            "DCH\tDitch ",
            "DDC\tDouble Detector Check ",
            "DRN\tDrain ",
            "DW\tDrive or Driveway ",
            "DRP\tDrop ",
            "DU\tDuct ",
            "DI\tDuctile Iron",
            "DMP\tDumpster ",
            "EAR\tEarthwork ",
            "ESM\tEasement ",
            "E\tEast ",
            "EC\tEdge of\tClearing ",
            "EP\tEdge of Pavement ",
            "EDG\tEdge ",
            "ELV\tElevation ",
            "EPS\tEllipse ",
            "ENC\tEnclosure ",
            "END\tEnd ",
            "ENG\tEngineer ",
            "ENT\tEntrance ",
            "ERR\tError ",
            "EXC\tExcavation ",
            "EXN\tException ",
            "EXP\tExpansion ",
            "EXT\tExtruded ",
            "FOC\tFace of\tCurb ",
            "FAC\tFacility ",
            "FWY\tFairway ",
            "FNC\tFence ",
            "FLD\tField ",
            "FIG\tFigure ",
            "F\tFill ",
            "FIL\tFilter ",
            "FF\tFinished Floor ",
            "FG\tFinished Grade ",
            "FIR\tFir ",
            "FR\tFire ",
            "FLG\tFlag ",
            "FLP\tFloodplain ",
            "FLT\tFlat ",
            "FLR\tFloor ",
            "FL\tFlow Line ",
            "FCS\tFlow Control Structure ",
            "FOG\tFog Line ",
            "FM\tForce Main ",
            "FOU\tFoundation ",
            "FUT\tFuture ",
            "GAO\tGabion ",
            "GLV\tGalvanize/Galvanized (Pipe) ",
            "GAR\tGarage ",
            "GT\tGate ",
            "GAB\tGazebo ",
            "GEN\tGeneral ",
            "GPS\tGlobal Positioning System ",
            "GRD\tGrade ",
            "GRS\tGrass ",
            "GVL\tGravel ",
            "GR\tGrid ",
            "GND\tGround ",
            "GDR\tGuard Rail ",
            "GTR\tGutter ",
            "GUY\tGuy ",
            "HH\tHandhole ",
            "HAN\tHandicap ",
            "HAZ\tHazard ",
            "HDG\tHedge ",
            "HEM\tHemlock ",
            "HID\tHidden ",
            "HP\tHigh Pressure ",
            "HOR\tHorizontal ",
            "HSE\tHouse ",
            "HUB\tHub ",
            "HYD\tHydrant ",
            "HGL\tHydraulic Grade Line ",
            "INL\tInlet ",
            "INC\tInterceptor ",
            "INR\tIntermediate ",
            "ITR\tIntermittent ",
            "INT\tIntersection ",
            "IE\tInvert Elevation\t",
            "IRN\tIron ",
            "IPC\tIron Pin & Cap\t",
            "IR\tIrrigation ",
            "ISL\tIsland ",
            "JT\tJoint ",
            "JU\tJunction ",
            "KEY\tKey ",
            "LAK\tLake ",
            "LDS\tLandscaping ",
            "LED\tLead ",
            "LE\tLeader ",
            "LT\tLeft ",
            "LEG\tLegal Description ",
            "LGN\tLegend ",
            "LVS\tLevel Spreader ",
            "LS\tLift Station",
            "LI\tLight ",
            "LIM\tLimit ",
            "L\tLine ",
            "LF\tLineal Foot ",
            "LOT\tLots ",
            "LU\tLuminaire ",
            "MDR\tMadrona ",
            "MA\tMail ",
            "MN\tMain ",
            "MJR\tMajor ",
            "MH\tManhole ",
            "MPL\tMaple ",
            "MGN\tMargin ",
            "MKR\tMarker ",
            "MAR\tMarking ",
            "MAX\tMaximum ",
            "MEC\tMechanical ",
            "MED\tMedian ",
            "MTR\tMeter ",
            "MIN\tMinimum ",
            "MNR\tMinor ",
            "MIS\tMiscellaneous ",
            "MIT\tMitigation ",
            "MNT\tMonitoring ",
            "MIC\tMonument in Case ",
            "MON\tMonument ",
            "MPH\tMorphology ",
            "MLT\tMultiple ",
            "NM\tName ",
            "NGV\tNational Geodetic Vertical Datum 1929 ",
            "NGS\tNational Geodetic Survey ",
            "NGP\tNative Growth Protection Easement ",
            "NC\tNeighborhood Collector ",
            "NOD\tNode ",
            "NOR\tNormal ",
            "NAV\tNorth American Vertical Datum 1988 ",
            "N\tNorth ",
            "NOT\tNote(s) ",
            "NJ\tNovajet Plotter ",
            "NUM\tNumber ",
            "OAK\tOak (Tree) ",
            "OCE\tOcean ",
            "OFS\tOffsite ",
            "OLD\tOld ",
            "ORC\tOrchard ",
            "OTF\tOutfall ",
            "OVF\tOverflow ",
            "OH\tOverhead ",
            "OWN\tOwner ",
            "PS\tPacsoft ",
            "PAD\tPad ",
            "PLM\tPalm ",
            "PAR\tParcel ",
            "PRK\tPark ",
            "PKC\tParking ",
            "PTH\tPath ",
            "PAV\tPavement ",
            "PEL\tPedestal ",
            "PED\tPedestrian ",
            "PRF\tPerforated ",
            "PHS\tPhase ",
            "PIN\tPine ",
            "PI\tPipe ",
            "PK\tPK Nail ",
            "PE\tPlain End ",
            "P\tPlan ",
            "PLA\tPlanter ",
            "PLT\tPlat ",
            "PLG\tPlayground ",
            "PLU\tPlug ",
            "PTI\tPoint of Intersection ",
            "PTC\tPoint of Tangency ",
            "PRC\tPoint of Reverse Curve ",
            "POC\tPoint on Curve ",
            "PNT\tPoint ",
            "PCC\tPoint of Compound Curve ",
            "PTC\tPoint of Curvature ",
            "POL\tPole ",
            "PVC\tPolyvinyl Chloride (Pipe) ",
            "PND\tPond ",
            "POO\tPool ",
            "PST\tPost ",
            "PSI\tPounds per Square Inch ",
            "LB\tPounds ",
            "PRV\tPressure Reducing (Valve) ",
            "PRI\tPrimary ",
            "PVT\tPrivate ",
            "PR\tProfile ",
            "PRJ\tProjection ",
            "PL\tProperty Line ",
            "PMP\tPump ",
            "QTY\tQuantity ",
            "QRY\tQuarry ",
            "RA\tRadius ",
            "RR\tRailroad ",
            "RMP\tRamp ",
            "RGE\tRange ",
            "RVN\tRavine ",
            "RED\tReducer ",
            "REG\tRegulator ",
            "REL\tRelocate ",
            "RET\tRetaining (Wall)",
            "RT\tRetention ",
            "REV\tRevision/Revised ",
            "RDG\tRidge ",
            "RI\tRight ",
            "ROW\tRight-of-way",
            "RPP\tRip-rap ",
            "RSR\tRiser ",
            "RIV\tRiver ",
            "RD\tRoad ",
            "RK\tRock ",
            "RCK\tRockery ",
            "ROL\tRolled ",
            "RF\tRoof ",
            "RUF\tRough ",
            "X\tScale ",
            "SCL\tScale ",
            "SEC\tSection ",
            "STR\tSection-Township-Range ",
            "SED\tSediment ",
            "SA\tSensitive Area ",
            "SVC\tService ",
            "SLF\tShelf (as in Detention Ponds) ",
            "SHR\tShore ",
            "SDR\tShoulder ",
            "SWK\tSidewalk ",
            "SGT\tSight ",
            "SGN\tSign ",
            "SGL\tSignal ",
            "SLV\tSleeve ",
            "SL\tSlope ",
            "STP\tSoil Test Pit ",
            "S\tSouth ",
            "SPC\tSpecification (s)\t",
            "SPL\tSpillway ",
            "SPT\tSpot ",
            "SP\tSprinkler ",
            "SPR\tSpruce ",
            "SQ\tSquare ",
            "STP\tStamp ",
            "STA\tStation ",
            "STL\tSteel ",
            "SPS\tSteps ",
            "STN\tStone ",
            "SBR\tStop Bar ",
            "STO\tStorage ",
            "STM\tStream ",
            "ST\tStreet ",
            "STI\tStriping ",
            "STC\tStructural/Structure ",
            "STB\tStub ",
            "SUB\tSubdivision ",
            "SUR\tSurface ",
            "SVY\tSurvey ",
            "SWL\tSwale ",
            "SWA\tSwamp ",
            "SWI\tSwitch ",
            "TAC\tTack ",
            "TNK\tTank ",
            "TPR\tTaper ",
            "TEE\tTee ",
            "TLM\tTelemetry ",
            "TPL\tTemplate ",
            "TMP\tTemporary ",
            "TIC\tTick ",
            "TDF\tTideflat ",
            "TTL\tTitle ",
            "TOE\tToe ",
            "TOP\tTop ",
            "TOC\tTop of Curb ",
            "TWR\tTower ",
            "TWP\tTownship ",
            "TRA\tTract ",
            "TRL\tTrail ",
            "TLR\tTrailer ",
            "TRN\tTransformers ",
            "TRS\tTransition ",
            "TRP\tTrap ",
            "TRV\tTraverse ",
            "TRE\tTree ",
            "TCH\tTrench ",
            "TRI\tTriple ",
            "TWN\tTwin ",
            "T1\tType 1 ",
            "T2\tType 2 ",
            "TYP\tTypical ",
            "UDG\tUnderground ",
            "UND\tUndisturbed ",
            "UT\tUtilities ",
            "VLV\tValve ",
            "VLT\tVault ",
            "VEG\tVegetation ",
            "VNT\tVent ",
            "VC\tVertical Curve ",
            "VER\tVertical ",
            "VIC\tVicinity ",
            "VP\tViewport ",
            "VOL\tVolume ",
            "WK\tWalk ",
            "WAL\tWall ",
            "DOT\tWash. State Department of Transportation ",
            "WDT\tWater Drop Track ",
            "DOH\tWashington State Department of Health ",
            "WQP\tWater Quality Pond ",
            "WS\tWater Surface ",
            "WEL\tWell ",
            "W\tWest ",
            "WL\tWet Land ",
            "WP\tWet Pond ",
            "WHC\tWheelchair ",
            "WST\tWheelstop",
            "WDW\tWindow\t",
            "WIR\tWire ",
            "WOD\tWood ",
            "YD\tYard ",
            "ZON\tZoning"});
            this.entityDescListBox.Location = new System.Drawing.Point(232, 199);
            this.entityDescListBox.Name = "entityDescListBox";
            this.entityDescListBox.Size = new System.Drawing.Size(190, 82);
            this.entityDescListBox.TabIndex = 11;
            this.entityDescListBox.SelectedIndexChanged += new System.EventHandler(this.entityDescListBox_SelectedIndexChanged);
            // 
            // layersListBox
            // 
            this.layersListBox.FormattingEnabled = true;
            this.layersListBox.Location = new System.Drawing.Point(12, 316);
            this.layersListBox.Name = "layersListBox";
            this.layersListBox.Size = new System.Drawing.Size(410, 69);
            this.layersListBox.TabIndex = 12;
            this.layersListBox.SelectedIndexChanged += new System.EventHandler(this.layersListBox_SelectedIndexChanged);
            // 
            // layersLabel
            // 
            this.layersLabel.AutoSize = true;
            this.layersLabel.Location = new System.Drawing.Point(12, 298);
            this.layersLabel.Name = "layersLabel";
            this.layersLabel.Size = new System.Drawing.Size(63, 13);
            this.layersLabel.TabIndex = 13;
            this.layersLabel.Text = "New Layers";
            // 
            // layerLabel
            // 
            this.layerLabel.AutoSize = true;
            this.layerLabel.Location = new System.Drawing.Point(12, 399);
            this.layerLabel.Name = "layerLabel";
            this.layerLabel.Size = new System.Drawing.Size(61, 13);
            this.layerLabel.TabIndex = 14;
            this.layerLabel.Text = "New Layer:";
            // 
            // layerTextBox
            // 
            this.layerTextBox.Location = new System.Drawing.Point(80, 399);
            this.layerTextBox.Name = "layerTextBox";
            this.layerTextBox.Size = new System.Drawing.Size(342, 20);
            this.layerTextBox.TabIndex = 15;
            this.layerTextBox.Text = "F-AM-D-ZZZZZZZZZZ";
            this.layerTextBox.Leave += new System.EventHandler(this.layerTextBox_Leave);
            // 
            // ltypeButton
            // 
            this.ltypeButton.Enabled = false;
            this.ltypeButton.Location = new System.Drawing.Point(346, 425);
            this.ltypeButton.Name = "ltypeButton";
            this.ltypeButton.Size = new System.Drawing.Size(75, 23);
            this.ltypeButton.TabIndex = 16;
            this.ltypeButton.Text = "L-Type";
            this.ltypeButton.UseVisualStyleBackColor = true;
            this.ltypeButton.Click += new System.EventHandler(this.ltypeButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Enabled = false;
            this.colorButton.Location = new System.Drawing.Point(234, 425);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 17;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(123, 425);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // makeButton
            // 
            this.makeButton.Location = new System.Drawing.Point(12, 425);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(75, 23);
            this.makeButton.TabIndex = 19;
            this.makeButton.Text = "Make";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(123, 476);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(235, 476);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(232, 176);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ZZZ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(300, 176);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ZZZ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(369, 176);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 17);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ZZZZ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // LayerMakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.makeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.ltypeButton);
            this.Controls.Add(this.layerTextBox);
            this.Controls.Add(this.layerLabel);
            this.Controls.Add(this.layersLabel);
            this.Controls.Add(this.layersListBox);
            this.Controls.Add(this.entityDescListBox);
            this.Controls.Add(this.entityDescLabel);
            this.Controls.Add(this.moreEntButton);
            this.Controls.Add(this.entityTypeLabel);
            this.Controls.Add(this.entityTypeListBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.dataStateLabel);
            this.Controls.Add(this.moreCatButton);
            this.Controls.Add(this.categoryListBox);
            this.Controls.Add(this.dataStateListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LayerMakeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Layer Make";
            this.Load += new System.EventHandler(this.LayerMakeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dataStateListBox;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.Button moreCatButton;
        private System.Windows.Forms.Label dataStateLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label entityTypeLabel;
        private System.Windows.Forms.ListBox entityTypeListBox;
        private System.Windows.Forms.Label entityDescLabel;
        private System.Windows.Forms.Button moreEntButton;
        private System.Windows.Forms.ListBox entityDescListBox;
        private System.Windows.Forms.ListBox layersListBox;
        private System.Windows.Forms.Label layersLabel;
        private System.Windows.Forms.Label layerLabel;
        private System.Windows.Forms.TextBox layerTextBox;
        private System.Windows.Forms.Button ltypeButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button makeButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

