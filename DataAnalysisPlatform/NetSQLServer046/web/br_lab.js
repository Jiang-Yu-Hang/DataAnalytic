/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:56:15.89
*/
gx.evt.autoSkip = false;
gx.define('br_lab', false, function () {
   this.ServerClass =  "br_lab" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV12BR_LabID=gx.fn.getIntegerValue("vBR_LABID",',') ;
      this.AV10Insert_BR_EncounterID=gx.fn.getIntegerValue("vINSERT_BR_ENCOUNTERID",',') ;
      this.A474BR_Lab_SpecimenSource_Code=gx.fn.getControlValue("BR_LAB_SPECIMENSOURCE_CODE") ;
      this.A475BR_Lab_ResultQual_Code=gx.fn.getControlValue("BR_LAB_RESULTQUAL_CODE") ;
      this.A476BR_Lab_AbnInd_Code=gx.fn.getControlValue("BR_LAB_ABNIND_CODE") ;
      this.AV16tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.A224BR_Lab_SampleID=gx.fn.getControlValue("BR_LAB_SAMPLEID") ;
      this.A103BR_Lab_TestCode=gx.fn.getControlValue("BR_LAB_TESTCODE") ;
      this.A430BR_SampleId=gx.fn.getIntegerValue("BR_SAMPLEID",',') ;
      this.A85BR_Information_ID=gx.fn.getIntegerValue("BR_INFORMATION_ID",',') ;
      this.AV17Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV8TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_labid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_LABID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_lab_testname=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_LAB_TESTNAME");
         this.AnyError  = 0;
         if ( ((''==this.A104BR_Lab_TestName)) )
         {
            try {
               gxballoon.setError("椤圭洰鍚嶇О鏄繀椤诲～鍐欑殑銆?);
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_lab_specimensource=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_LAB_SPECIMENSOURCE");
         this.AnyError  = 0;
         try {
            gx.fn.setCtrlProperty("vVSOURCE","Visible", (this.A106BR_Lab_SpecimenSource=="鍏跺畠") );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A106BR_Lab_SpecimenSource == "鍏跺畠" ) ) )
            {
               gx.fn.setCtrlProperty("VSOURCE_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A106BR_Lab_SpecimenSource == "鍏跺畠" )
               {
                  gx.fn.setCtrlProperty("VSOURCE_CELL","Class", "RequiredDataContentCell" );
               }
            }
         }
         catch(e){}

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Vsource=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVSOURCE");
         this.AnyError  = 0;
         if ( ( ( this.A106BR_Lab_SpecimenSource == "鍏跺畠" ) ) && ((''==this.AV15vSource)) )
         {
            try {
               gxballoon.setError("鍏跺畠鏍囨湰绉嶇被鏄繀濉殑");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_lab_specimendate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_LAB_SPECIMENDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A105BR_Lab_SpecimenDate)==0) || new gx.date.gxdate( this.A105BR_Lab_SpecimenDate ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }
         if ( (new gx.date.gxdate('').compare(this.A105BR_Lab_SpecimenDate)==0) )
         {
            try {
               gxballoon.setError("閲囨牱鏃堕棿鏄繀椤诲～鍐欑殑銆?);
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_lab_receivingtime=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_LAB_RECEIVINGTIME");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A264BR_Lab_ReceivingTime)==0) || new gx.date.gxdate( this.A264BR_Lab_ReceivingTime ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_lab_reporttime=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_LAB_REPORTTIME");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A265BR_Lab_ReportTime)==0) || new gx.date.gxdate( this.A265BR_Lab_ReportTime ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_lab_resultqual=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_LAB_RESULTQUAL");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_lab_abnind=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_LAB_ABNIND");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_encounterid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_encounterid",["gx.num.urlDecimal(gx.O.A19BR_EncounterID,\',\',\'.\')", "gx.num.urlDecimal(gx.O.A85BR_Information_ID,\',\',\'.\')", "gx.O.A36BR_Information_PatientNo"],["A85BR_Information_ID", "A36BR_Information_PatientNo"]);
      return true;
   }
   this.s112_client=function()
   {
      gx.fn.setCtrlProperty("vVSOURCE","Visible", false );
      gx.fn.setCtrlProperty("VSOURCE_CELL","Class", "Invisible" );
   };
   this.e120g2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130g17_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140g17_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,65,66,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162,163,164,165,166,167,168,169,170,171,172,173,174,175,176,177,178,179,180];
   this.GXLastCtrlId =180;
   this.DVPANEL_TABLEATTRIBUTESContainer = gx.uc.getNew(this, 16, 0, "BootstrapPanel", "DVPANEL_TABLEATTRIBUTESContainer", "Dvpanel_tableattributes", "DVPANEL_TABLEATTRIBUTES");
   var DVPANEL_TABLEATTRIBUTESContainer = this.DVPANEL_TABLEATTRIBUTESContainer;
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Class", "Class", "", "char");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Width", "Width", "100%", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Height", "Height", "100", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Cls", "Cls", "PanelCard_BaseColor", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "瀹為獙瀹ゆ鏌?, "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Collapsible", "Collapsible", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("IconPosition", "Iconposition", "left", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Visible", "Visible", true, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_TABLEATTRIBUTESContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"TABLECONTENT",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};
   GXValidFnc[18]={ id: 18, fld:"LAYOUT_TABLEATTRIBUTES",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"TABLEATTRIBUTES",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEBR_LAB_TESTNAME",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_LAB_TESTNAME", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_lab_testname,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_TESTNAME",gxz:"Z104BR_Lab_TestName",gxold:"O104BR_Lab_TestName",gxvar:"A104BR_Lab_TestName",ucs:[],op:[29],ip:[29],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A104BR_Lab_TestName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z104BR_Lab_TestName=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_TESTNAME",gx.O.A104BR_Lab_TestName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A104BR_Lab_TestName=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_TESTNAME")},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLEBR_LAB_TESTENGNAME",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"TEXTBLOCKBR_LAB_TESTENGNAME", format:0,grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_TESTENGNAME",gxz:"Z261BR_Lab_TestEngName",gxold:"O261BR_Lab_TestEngName",gxvar:"A261BR_Lab_TestEngName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A261BR_Lab_TestEngName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z261BR_Lab_TestEngName=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_TESTENGNAME",gx.O.A261BR_Lab_TestEngName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A261BR_Lab_TestEngName=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_TESTENGNAME")},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"UNNAMEDTABLEBR_LAB_AGE",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"TEXTBLOCKBR_LAB_AGE", format:0,grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_AGE",gxz:"Z262BR_Lab_Age",gxold:"O262BR_Lab_Age",gxvar:"A262BR_Lab_Age",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A262BR_Lab_Age=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z262BR_Lab_Age=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_LAB_AGE",gx.O.A262BR_Lab_Age,0)},c2v:function(){if(this.val()!==undefined)gx.O.A262BR_Lab_Age=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_LAB_AGE",',')},nac:gx.falseFn};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"UNNAMEDTABLEBR_LAB_DIAG",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"TEXTBLOCKBR_LAB_DIAG", format:0,grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_DIAG",gxz:"Z263BR_Lab_Diag",gxold:"O263BR_Lab_Diag",gxvar:"A263BR_Lab_Diag",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A263BR_Lab_Diag=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z263BR_Lab_Diag=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_DIAG",gx.O.A263BR_Lab_Diag,0)},c2v:function(){if(this.val()!==undefined)gx.O.A263BR_Lab_Diag=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_DIAG")},nac:gx.falseFn};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"TABLESPLITTEDBR_LAB_SPECIMENSOURCE",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"TEXTBLOCKBR_LAB_SPECIMENSOURCE", format:0,grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"TABLEMERGEDBR_LAB_SPECIMENSOURCE",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_lab_specimensource,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_SPECIMENSOURCE",gxz:"Z106BR_Lab_SpecimenSource",gxold:"O106BR_Lab_SpecimenSource",gxvar:"A106BR_Lab_SpecimenSource",ucs:[],op:[],ip:[66],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A106BR_Lab_SpecimenSource=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z106BR_Lab_SpecimenSource=Value},v2c:function(){gx.fn.setComboBoxValue("BR_LAB_SPECIMENSOURCE",gx.O.A106BR_Lab_SpecimenSource)},c2v:function(){if(this.val()!==undefined)gx.O.A106BR_Lab_SpecimenSource=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_SPECIMENSOURCE")},nac:gx.falseFn};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vsource,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVSOURCE",gxz:"ZV15vSource",gxold:"OV15vSource",gxvar:"AV15vSource",ucs:[],op:[69,66],ip:[69,66],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15vSource=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV15vSource=Value},v2c:function(){gx.fn.setControlValue("vVSOURCE",gx.O.AV15vSource,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15vSource=this.val()},val:function(){return gx.fn.getControlValue("vVSOURCE")},nac:gx.falseFn};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"UNNAMEDTABLEBR_LAB_SPECIMENDATE",grid:0};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id: 74, fld:"TEXTBLOCKBR_LAB_SPECIMENDATE", format:0,grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id:77 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_lab_specimendate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_SPECIMENDATE",gxz:"Z105BR_Lab_SpecimenDate",gxold:"O105BR_Lab_SpecimenDate",gxvar:"A105BR_Lab_SpecimenDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[77],ip:[77],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A105BR_Lab_SpecimenDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z105BR_Lab_SpecimenDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_LAB_SPECIMENDATE",gx.O.A105BR_Lab_SpecimenDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A105BR_Lab_SpecimenDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("BR_LAB_SPECIMENDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 77 , function() {
   });
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id: 80, fld:"UNNAMEDTABLEBR_LAB_RECEIVINGTIME",grid:0};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"",grid:0};
   GXValidFnc[83]={ id: 83, fld:"TEXTBLOCKBR_LAB_RECEIVINGTIME", format:0,grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id: 85, fld:"",grid:0};
   GXValidFnc[86]={ id:86 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_lab_receivingtime,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_RECEIVINGTIME",gxz:"Z264BR_Lab_ReceivingTime",gxold:"O264BR_Lab_ReceivingTime",gxvar:"A264BR_Lab_ReceivingTime",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[86],ip:[86],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A264BR_Lab_ReceivingTime=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z264BR_Lab_ReceivingTime=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_LAB_RECEIVINGTIME",gx.O.A264BR_Lab_ReceivingTime,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A264BR_Lab_ReceivingTime=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("BR_LAB_RECEIVINGTIME")},nac:gx.falseFn};
   this.declareDomainHdlr( 86 , function() {
   });
   GXValidFnc[87]={ id: 87, fld:"",grid:0};
   GXValidFnc[88]={ id: 88, fld:"UNNAMEDTABLEBR_LAB_REPORTTIME",grid:0};
   GXValidFnc[89]={ id: 89, fld:"",grid:0};
   GXValidFnc[90]={ id: 90, fld:"",grid:0};
   GXValidFnc[91]={ id: 91, fld:"TEXTBLOCKBR_LAB_REPORTTIME", format:0,grid:0};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id: 93, fld:"",grid:0};
   GXValidFnc[94]={ id:94 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_lab_reporttime,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_REPORTTIME",gxz:"Z265BR_Lab_ReportTime",gxold:"O265BR_Lab_ReportTime",gxvar:"A265BR_Lab_ReportTime",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[94],ip:[94],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A265BR_Lab_ReportTime=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z265BR_Lab_ReportTime=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_LAB_REPORTTIME",gx.O.A265BR_Lab_ReportTime,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A265BR_Lab_ReportTime=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("BR_LAB_REPORTTIME")},nac:gx.falseFn};
   this.declareDomainHdlr( 94 , function() {
   });
   GXValidFnc[95]={ id: 95, fld:"",grid:0};
   GXValidFnc[96]={ id: 96, fld:"",grid:0};
   GXValidFnc[97]={ id: 97, fld:"UNNAMEDTABLEBR_LAB_RESULTQUAL",grid:0};
   GXValidFnc[98]={ id: 98, fld:"",grid:0};
   GXValidFnc[99]={ id: 99, fld:"",grid:0};
   GXValidFnc[100]={ id: 100, fld:"TEXTBLOCKBR_LAB_RESULTQUAL", format:0,grid:0};
   GXValidFnc[101]={ id: 101, fld:"",grid:0};
   GXValidFnc[102]={ id: 102, fld:"",grid:0};
   GXValidFnc[103]={ id:103 ,lvl:0,type:"svchar",len:500,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_lab_resultqual,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_RESULTQUAL",gxz:"Z109BR_Lab_ResultQual",gxold:"O109BR_Lab_ResultQual",gxvar:"A109BR_Lab_ResultQual",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A109BR_Lab_ResultQual=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z109BR_Lab_ResultQual=Value},v2c:function(){gx.fn.setComboBoxValue("BR_LAB_RESULTQUAL",gx.O.A109BR_Lab_ResultQual)},c2v:function(){if(this.val()!==undefined)gx.O.A109BR_Lab_ResultQual=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_RESULTQUAL")},nac:gx.falseFn};
   GXValidFnc[104]={ id: 104, fld:"",grid:0};
   GXValidFnc[105]={ id: 105, fld:"",grid:0};
   GXValidFnc[106]={ id: 106, fld:"UNNAMEDTABLEBR_LAB_RESULTUNIT",grid:0};
   GXValidFnc[107]={ id: 107, fld:"",grid:0};
   GXValidFnc[108]={ id: 108, fld:"",grid:0};
   GXValidFnc[109]={ id: 109, fld:"TEXTBLOCKBR_LAB_RESULTUNIT", format:0,grid:0};
   GXValidFnc[110]={ id: 110, fld:"",grid:0};
   GXValidFnc[111]={ id: 111, fld:"",grid:0};
   GXValidFnc[112]={ id:112 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_RESULTUNIT",gxz:"Z111BR_Lab_ResultUnit",gxold:"O111BR_Lab_ResultUnit",gxvar:"A111BR_Lab_ResultUnit",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A111BR_Lab_ResultUnit=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z111BR_Lab_ResultUnit=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_RESULTUNIT",gx.O.A111BR_Lab_ResultUnit,0)},c2v:function(){if(this.val()!==undefined)gx.O.A111BR_Lab_ResultUnit=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_RESULTUNIT")},nac:gx.falseFn};
   GXValidFnc[113]={ id: 113, fld:"",grid:0};
   GXValidFnc[114]={ id: 114, fld:"UNNAMEDTABLEBR_LAB_ABNIND",grid:0};
   GXValidFnc[115]={ id: 115, fld:"",grid:0};
   GXValidFnc[116]={ id: 116, fld:"",grid:0};
   GXValidFnc[117]={ id: 117, fld:"TEXTBLOCKBR_LAB_ABNIND", format:0,grid:0};
   GXValidFnc[118]={ id: 118, fld:"",grid:0};
   GXValidFnc[119]={ id: 119, fld:"",grid:0};
   GXValidFnc[120]={ id:120 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_lab_abnind,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_ABNIND",gxz:"Z112BR_Lab_AbnInd",gxold:"O112BR_Lab_AbnInd",gxvar:"A112BR_Lab_AbnInd",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A112BR_Lab_AbnInd=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z112BR_Lab_AbnInd=Value},v2c:function(){gx.fn.setComboBoxValue("BR_LAB_ABNIND",gx.O.A112BR_Lab_AbnInd)},c2v:function(){if(this.val()!==undefined)gx.O.A112BR_Lab_AbnInd=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_ABNIND")},nac:gx.falseFn};
   GXValidFnc[121]={ id: 121, fld:"",grid:0};
   GXValidFnc[122]={ id: 122, fld:"",grid:0};
   GXValidFnc[123]={ id: 123, fld:"UNNAMEDTABLEBR_LAB_NORMRANGELOW",grid:0};
   GXValidFnc[124]={ id: 124, fld:"",grid:0};
   GXValidFnc[125]={ id: 125, fld:"",grid:0};
   GXValidFnc[126]={ id: 126, fld:"TEXTBLOCKBR_LAB_NORMRANGELOW", format:0,grid:0};
   GXValidFnc[127]={ id: 127, fld:"",grid:0};
   GXValidFnc[128]={ id: 128, fld:"",grid:0};
   GXValidFnc[129]={ id:129 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_NORMRANGELOW",gxz:"Z113BR_Lab_NormRangeLow",gxold:"O113BR_Lab_NormRangeLow",gxvar:"A113BR_Lab_NormRangeLow",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A113BR_Lab_NormRangeLow=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z113BR_Lab_NormRangeLow=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_NORMRANGELOW",gx.O.A113BR_Lab_NormRangeLow,0)},c2v:function(){if(this.val()!==undefined)gx.O.A113BR_Lab_NormRangeLow=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_NORMRANGELOW")},nac:gx.falseFn};
   GXValidFnc[130]={ id: 130, fld:"",grid:0};
   GXValidFnc[131]={ id: 131, fld:"",grid:0};
   GXValidFnc[132]={ id: 132, fld:"UNNAMEDTABLEBR_LAB_TESTMETHOD",grid:0};
   GXValidFnc[133]={ id: 133, fld:"",grid:0};
   GXValidFnc[134]={ id: 134, fld:"",grid:0};
   GXValidFnc[135]={ id: 135, fld:"TEXTBLOCKBR_LAB_TESTMETHOD", format:0,grid:0};
   GXValidFnc[136]={ id: 136, fld:"",grid:0};
   GXValidFnc[137]={ id: 137, fld:"",grid:0};
   GXValidFnc[138]={ id:138 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_TESTMETHOD",gxz:"Z115BR_Lab_TestMethod",gxold:"O115BR_Lab_TestMethod",gxvar:"A115BR_Lab_TestMethod",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A115BR_Lab_TestMethod=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z115BR_Lab_TestMethod=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_TESTMETHOD",gx.O.A115BR_Lab_TestMethod,0)},c2v:function(){if(this.val()!==undefined)gx.O.A115BR_Lab_TestMethod=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_TESTMETHOD")},nac:gx.falseFn};
   GXValidFnc[139]={ id: 139, fld:"",grid:0};
   GXValidFnc[140]={ id: 140, fld:"UNNAMEDTABLEBR_LAB_INSTRUMENTCODE",grid:0};
   GXValidFnc[141]={ id: 141, fld:"",grid:0};
   GXValidFnc[142]={ id: 142, fld:"",grid:0};
   GXValidFnc[143]={ id: 143, fld:"TEXTBLOCKBR_LAB_INSTRUMENTCODE", format:0,grid:0};
   GXValidFnc[144]={ id: 144, fld:"",grid:0};
   GXValidFnc[145]={ id: 145, fld:"",grid:0};
   GXValidFnc[146]={ id:146 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_INSTRUMENTCODE",gxz:"Z118BR_Lab_InstrumentCode",gxold:"O118BR_Lab_InstrumentCode",gxvar:"A118BR_Lab_InstrumentCode",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A118BR_Lab_InstrumentCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z118BR_Lab_InstrumentCode=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_INSTRUMENTCODE",gx.O.A118BR_Lab_InstrumentCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.A118BR_Lab_InstrumentCode=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_INSTRUMENTCODE")},nac:gx.falseFn};
   GXValidFnc[147]={ id: 147, fld:"",grid:0};
   GXValidFnc[148]={ id: 148, fld:"",grid:0};
   GXValidFnc[149]={ id: 149, fld:"UNNAMEDTABLEBR_LAB_INSTRUMENTNAME",grid:0};
   GXValidFnc[150]={ id: 150, fld:"",grid:0};
   GXValidFnc[151]={ id: 151, fld:"",grid:0};
   GXValidFnc[152]={ id: 152, fld:"TEXTBLOCKBR_LAB_INSTRUMENTNAME", format:0,grid:0};
   GXValidFnc[153]={ id: 153, fld:"",grid:0};
   GXValidFnc[154]={ id: 154, fld:"",grid:0};
   GXValidFnc[155]={ id:155 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_INSTRUMENTNAME",gxz:"Z117BR_Lab_InstrumentName",gxold:"O117BR_Lab_InstrumentName",gxvar:"A117BR_Lab_InstrumentName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A117BR_Lab_InstrumentName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z117BR_Lab_InstrumentName=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_INSTRUMENTNAME",gx.O.A117BR_Lab_InstrumentName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A117BR_Lab_InstrumentName=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_INSTRUMENTNAME")},nac:gx.falseFn};
   GXValidFnc[156]={ id: 156, fld:"",grid:0};
   GXValidFnc[157]={ id: 157, fld:"UNNAMEDTABLEBR_LAB_RESULTNUM",grid:0};
   GXValidFnc[158]={ id: 158, fld:"",grid:0};
   GXValidFnc[159]={ id: 159, fld:"",grid:0};
   GXValidFnc[160]={ id: 160, fld:"TEXTBLOCKBR_LAB_RESULTNUM", format:0,grid:0};
   GXValidFnc[161]={ id: 161, fld:"",grid:0};
   GXValidFnc[162]={ id: 162, fld:"",grid:0};
   GXValidFnc[163]={ id:163 ,lvl:0,type:"svchar",len:500,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_RESULTNUM",gxz:"Z110BR_Lab_ResultNum",gxold:"O110BR_Lab_ResultNum",gxvar:"A110BR_Lab_ResultNum",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A110BR_Lab_ResultNum=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z110BR_Lab_ResultNum=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_RESULTNUM",gx.O.A110BR_Lab_ResultNum,0)},c2v:function(){if(this.val()!==undefined)gx.O.A110BR_Lab_ResultNum=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_RESULTNUM")},nac:gx.falseFn};
   GXValidFnc[164]={ id: 164, fld:"",grid:0};
   GXValidFnc[165]={ id: 165, fld:"",grid:0};
   GXValidFnc[166]={ id: 166, fld:"",grid:0};
   GXValidFnc[167]={ id: 167, fld:"",grid:0};
   GXValidFnc[168]={ id: 168, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[169]={ id: 169, fld:"",grid:0};
   GXValidFnc[170]={ id: 170, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[171]={ id: 171, fld:"",grid:0};
   GXValidFnc[172]={ id: 172, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[173]={ id: 173, fld:"",grid:0};
   GXValidFnc[174]={ id: 174, fld:"",grid:0};
   GXValidFnc[175]={ id: 175, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[176]={ id:176 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_labid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LABID",gxz:"Z101BR_LabID",gxold:"O101BR_LabID",gxvar:"A101BR_LabID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A101BR_LabID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z101BR_LabID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_LABID",gx.O.A101BR_LabID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A101BR_LabID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_LABID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 176 , function() {
   });
   GXValidFnc[177]={ id:177 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[178],ip:[178,177],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV10Insert_BR_EncounterID))}};
   this.declareDomainHdlr( 177 , function() {
   });
   GXValidFnc[178]={ id:178 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A36BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z36BR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_PATIENTNO",gx.O.A36BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A36BR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[179]={ id:179 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_TESTID",gxz:"Z102BR_Lab_TestID",gxold:"O102BR_Lab_TestID",gxvar:"A102BR_Lab_TestID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A102BR_Lab_TestID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z102BR_Lab_TestID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_LAB_TESTID",gx.O.A102BR_Lab_TestID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A102BR_Lab_TestID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_LAB_TESTID",',')},nac:gx.falseFn};
   GXValidFnc[180]={ id:180 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_NORMRANGEHIGH",gxz:"Z114BR_Lab_NormRangeHigh",gxold:"O114BR_Lab_NormRangeHigh",gxvar:"A114BR_Lab_NormRangeHigh",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A114BR_Lab_NormRangeHigh=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z114BR_Lab_NormRangeHigh=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_NORMRANGEHIGH",gx.O.A114BR_Lab_NormRangeHigh,0)},c2v:function(){if(this.val()!==undefined)gx.O.A114BR_Lab_NormRangeHigh=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_NORMRANGEHIGH")},nac:gx.falseFn};
   this.A104BR_Lab_TestName = "" ;
   this.Z104BR_Lab_TestName = "" ;
   this.O104BR_Lab_TestName = "" ;
   this.A261BR_Lab_TestEngName = "" ;
   this.Z261BR_Lab_TestEngName = "" ;
   this.O261BR_Lab_TestEngName = "" ;
   this.A262BR_Lab_Age = 0 ;
   this.Z262BR_Lab_Age = 0 ;
   this.O262BR_Lab_Age = 0 ;
   this.A263BR_Lab_Diag = "" ;
   this.Z263BR_Lab_Diag = "" ;
   this.O263BR_Lab_Diag = "" ;
   this.A106BR_Lab_SpecimenSource = "" ;
   this.Z106BR_Lab_SpecimenSource = "" ;
   this.O106BR_Lab_SpecimenSource = "" ;
   this.AV15vSource = "" ;
   this.ZV15vSource = "" ;
   this.OV15vSource = "" ;
   this.A105BR_Lab_SpecimenDate = gx.date.nullDate() ;
   this.Z105BR_Lab_SpecimenDate = gx.date.nullDate() ;
   this.O105BR_Lab_SpecimenDate = gx.date.nullDate() ;
   this.A264BR_Lab_ReceivingTime = gx.date.nullDate() ;
   this.Z264BR_Lab_ReceivingTime = gx.date.nullDate() ;
   this.O264BR_Lab_ReceivingTime = gx.date.nullDate() ;
   this.A265BR_Lab_ReportTime = gx.date.nullDate() ;
   this.Z265BR_Lab_ReportTime = gx.date.nullDate() ;
   this.O265BR_Lab_ReportTime = gx.date.nullDate() ;
   this.A109BR_Lab_ResultQual = "" ;
   this.Z109BR_Lab_ResultQual = "" ;
   this.O109BR_Lab_ResultQual = "" ;
   this.A111BR_Lab_ResultUnit = "" ;
   this.Z111BR_Lab_ResultUnit = "" ;
   this.O111BR_Lab_ResultUnit = "" ;
   this.A112BR_Lab_AbnInd = "" ;
   this.Z112BR_Lab_AbnInd = "" ;
   this.O112BR_Lab_AbnInd = "" ;
   this.A113BR_Lab_NormRangeLow = "" ;
   this.Z113BR_Lab_NormRangeLow = "" ;
   this.O113BR_Lab_NormRangeLow = "" ;
   this.A115BR_Lab_TestMethod = "" ;
   this.Z115BR_Lab_TestMethod = "" ;
   this.O115BR_Lab_TestMethod = "" ;
   this.A118BR_Lab_InstrumentCode = "" ;
   this.Z118BR_Lab_InstrumentCode = "" ;
   this.O118BR_Lab_InstrumentCode = "" ;
   this.A117BR_Lab_InstrumentName = "" ;
   this.Z117BR_Lab_InstrumentName = "" ;
   this.O117BR_Lab_InstrumentName = "" ;
   this.A110BR_Lab_ResultNum = "" ;
   this.Z110BR_Lab_ResultNum = "" ;
   this.O110BR_Lab_ResultNum = "" ;
   this.A101BR_LabID = 0 ;
   this.Z101BR_LabID = 0 ;
   this.O101BR_LabID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.Z36BR_Information_PatientNo = "" ;
   this.O36BR_Information_PatientNo = "" ;
   this.A102BR_Lab_TestID = 0 ;
   this.Z102BR_Lab_TestID = 0 ;
   this.O102BR_Lab_TestID = 0 ;
   this.A114BR_Lab_NormRangeHigh = "" ;
   this.Z114BR_Lab_NormRangeHigh = "" ;
   this.O114BR_Lab_NormRangeHigh = "" ;
   this.A85BR_Information_ID = 0 ;
   this.AV16tCurrentCode = "" ;
   this.AV7WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV13IsAuthorized = false ;
   this.AV17Pgmname = "" ;
   this.AV8TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV18GXV1 = 0 ;
   this.AV10Insert_BR_EncounterID = 0 ;
   this.AV11TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV12BR_LabID = 0 ;
   this.AV9WebSession = {} ;
   this.A101BR_LabID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.AV15vSource = "" ;
   this.A474BR_Lab_SpecimenSource_Code = "" ;
   this.A475BR_Lab_ResultQual_Code = "" ;
   this.A476BR_Lab_AbnInd_Code = "" ;
   this.A36BR_Information_PatientNo = "" ;
   this.A224BR_Lab_SampleID = "" ;
   this.A102BR_Lab_TestID = 0 ;
   this.A103BR_Lab_TestCode = "" ;
   this.A104BR_Lab_TestName = "" ;
   this.A261BR_Lab_TestEngName = "" ;
   this.A262BR_Lab_Age = 0 ;
   this.A263BR_Lab_Diag = "" ;
   this.A105BR_Lab_SpecimenDate = gx.date.nullDate() ;
   this.A264BR_Lab_ReceivingTime = gx.date.nullDate() ;
   this.A265BR_Lab_ReportTime = gx.date.nullDate() ;
   this.A106BR_Lab_SpecimenSource = "" ;
   this.A109BR_Lab_ResultQual = "" ;
   this.A110BR_Lab_ResultNum = "" ;
   this.A111BR_Lab_ResultUnit = "" ;
   this.A112BR_Lab_AbnInd = "" ;
   this.A113BR_Lab_NormRangeLow = "" ;
   this.A114BR_Lab_NormRangeHigh = "" ;
   this.A115BR_Lab_TestMethod = "" ;
   this.A117BR_Lab_InstrumentName = "" ;
   this.A118BR_Lab_InstrumentCode = "" ;
   this.A430BR_SampleId = 0 ;
   this.Gx_mode = "" ;
   this.Events = {"e120g2_client": ["AFTER TRN", true] ,"e130g17_client": ["ENTER", true] ,"e140g17_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_LabID',fld:'vBR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_LabID',fld:'vBR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A101BR_LabID',fld:'BR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV16tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A224BR_Lab_SampleID',fld:'BR_LAB_SAMPLEID',pic:''},{av:'A103BR_Lab_TestCode',fld:'BR_LAB_TESTCODE',pic:''},{av:'A430BR_SampleId',fld:'BR_SAMPLEID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV17Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV16tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV7WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV13IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV18GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV11TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_LABID","Visible")',ctrl:'BR_LABID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Visible")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_LAB_TESTID","Visible")',ctrl:'BR_LAB_TESTID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_LAB_NORMRANGEHIGH","Visible")',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vVSOURCE","Visible")',ctrl:'vVSOURCE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("VSOURCE_CELL","Class")',ctrl:'VSOURCE_CELL',prop:'Class'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV12BR_LabID", "vBR_LABID", 0, "int", 18, 0);
   this.setVCMap("AV10Insert_BR_EncounterID", "vINSERT_BR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("A474BR_Lab_SpecimenSource_Code", "BR_LAB_SPECIMENSOURCE_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A475BR_Lab_ResultQual_Code", "BR_LAB_RESULTQUAL_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A476BR_Lab_AbnInd_Code", "BR_LAB_ABNIND_CODE", 0, "svchar", 40, 0);
   this.setVCMap("AV16tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("A224BR_Lab_SampleID", "BR_LAB_SAMPLEID", 0, "svchar", 100, 0);
   this.setVCMap("A103BR_Lab_TestCode", "BR_LAB_TESTCODE", 0, "svchar", 40, 0);
   this.setVCMap("A430BR_SampleId", "BR_SAMPLEID", 0, "int", 18, 0);
   this.setVCMap("A85BR_Information_ID", "BR_INFORMATION_ID", 0, "int", 18, 0);
   this.setVCMap("AV17Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV8TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_lab);
