/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:37:59.31
*/
gx.evt.autoSkip = false;
gx.define('br_medicalimaging', false, function () {
   this.ServerClass =  "br_medicalimaging" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7BR_MedicalImagingID=gx.fn.getIntegerValue("vBR_MEDICALIMAGINGID",',') ;
      this.AV13Insert_BR_EncounterID=gx.fn.getIntegerValue("vINSERT_BR_ENCOUNTERID",',') ;
      this.A484BR_MedicalImaging_ImageName_Code=gx.fn.getControlValue("BR_MEDICALIMAGING_IMAGENAME_CODE") ;
      this.A485BR_MedicalImaging_ImageHosp_Code=gx.fn.getControlValue("BR_MEDICALIMAGING_IMAGEHOSP_CODE") ;
      this.AV18tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.A486BR_MedicalImaging_ImageLoc_Code=gx.fn.getControlValue("BR_MEDICALIMAGING_IMAGELOC_CODE") ;
      this.A334BR_MedicalImaging_ImageHtml=gx.fn.getControlValue("BR_MEDICALIMAGING_IMAGEHTML") ;
      this.A85BR_Information_ID=gx.fn.getIntegerValue("BR_INFORMATION_ID",',') ;
      this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_medicalimagingid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICALIMAGINGID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_medicalimaging_no=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICALIMAGING_NO");
         this.AnyError  = 0;
         if ( ((0==this.A518BR_MedicalImaging_No)) )
         {
            try {
               gxballoon.setError("缂栧彿鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_medicalimaging_imagename=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICALIMAGING_IMAGENAME");
         this.AnyError  = 0;
         try {
            gx.fn.setCtrlProperty("vVNAME","Visible", (this.A228BR_MedicalImaging_ImageName=="鍏跺畠") );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A228BR_MedicalImaging_ImageName == "鍏跺畠" ) ) )
            {
               gx.fn.setCtrlProperty("VNAME_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A228BR_MedicalImaging_ImageName == "鍏跺畠" )
               {
                  gx.fn.setCtrlProperty("VNAME_CELL","Class", "RequiredDataContentCell" );
               }
            }
         }
         catch(e){}
         if ( ((''==this.A228BR_MedicalImaging_ImageName)) )
         {
            try {
               gxballoon.setError("褰卞儚鍚嶇О鏄繀椤诲～鍐欑殑銆?);
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
   this.Validv_Vname=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVNAME");
         this.AnyError  = 0;
         if ( ( ( this.A228BR_MedicalImaging_ImageName == "鍏跺畠" ) ) && ((''==this.AV15vName)) )
         {
            try {
               gxballoon.setError("鍏跺畠褰卞儚鍚嶇О鏄繀濉殑");
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
   this.Valid_Br_medicalimaging_imageage=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICALIMAGING_IMAGEAGE");
         this.AnyError  = 0;
         if ( ((0==this.A231BR_MedicalImaging_ImageAge)) )
         {
            try {
               gxballoon.setError("骞撮緞鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_medicalimaging_imagedate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICALIMAGING_IMAGEDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A229BR_MedicalImaging_ImageDate)==0) || new gx.date.gxdate( this.A229BR_MedicalImaging_ImageDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
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
   this.Valid_Br_medicalimaging_imagehosp=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICALIMAGING_IMAGEHOSP");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_medicalimaging_imageloc=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICALIMAGING_IMAGELOC");
         this.AnyError  = 0;
         try {
            gx.fn.setCtrlProperty("vWXNAME","Visible", (this.A232BR_MedicalImaging_ImageLoc=="鍏跺畠") );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A232BR_MedicalImaging_ImageLoc == "鍏跺畠" ) ) )
            {
               gx.fn.setCtrlProperty("WXNAME_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A232BR_MedicalImaging_ImageLoc == "鍏跺畠" )
               {
                  gx.fn.setCtrlProperty("WXNAME_CELL","Class", "RequiredDataContentCell" );
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
   this.Validv_Wxname=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vWXNAME");
         this.AnyError  = 0;
         if ( ( ( this.A232BR_MedicalImaging_ImageLoc == "鍏跺畠" ) ) && ((''==this.AV16wxname)) )
         {
            try {
               gxballoon.setError("鍏跺畠妫€娴嬮儴浣嶆槸蹇呭～鐨?);
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
   this.Valid_Br_medicalimaging_metastasesdx=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICALIMAGING_METASTASESDX");
         this.AnyError  = 0;
         if ( ! ( ( this.A514BR_MedicalImaging_MetastasesDX == "鍚? ) || ( this.A514BR_MedicalImaging_MetastasesDX == "鏄? ) || ( this.A514BR_MedicalImaging_MetastasesDX == "涓嶈" ) || ((''==this.A514BR_MedicalImaging_MetastasesDX)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }
         try {
            gx.fn.setCtrlProperty("BR_MEDICALIMAGING_METALOC","Visible", (this.A514BR_MedicalImaging_MetastasesDX=="鏄?) );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A514BR_MedicalImaging_MetastasesDX == "鏄? ) ) )
            {
               gx.fn.setCtrlProperty("BR_MEDICALIMAGING_METALOC_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A514BR_MedicalImaging_MetastasesDX == "鏄? )
               {
                  gx.fn.setCtrlProperty("BR_MEDICALIMAGING_METALOC_CELL","Class", "col-xs-12 col-md-6 DataContentCell" );
               }
            }
         }
         catch(e){}
         try {
            gx.fn.setCtrlProperty("BR_MEDICALIMAGING_METADATE","Visible", (this.A514BR_MedicalImaging_MetastasesDX=="鏄?) );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A514BR_MedicalImaging_MetastasesDX == "鏄? ) ) )
            {
               gx.fn.setCtrlProperty("BR_MEDICALIMAGING_METADATE_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A514BR_MedicalImaging_MetastasesDX == "鏄? )
               {
                  gx.fn.setCtrlProperty("BR_MEDICALIMAGING_METADATE_CELL","Class", "col-xs-12 col-md-6 DataContentCell" );
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
   this.Valid_Br_medicalimaging_metadate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICALIMAGING_METADATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A516BR_MedicalImaging_MetaDate)==0) || new gx.date.gxdate( this.A516BR_MedicalImaging_MetaDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
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
   this.Valid_Br_encounterid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_encounterid",["gx.num.urlDecimal(gx.O.A19BR_EncounterID,\',\',\'.\')", "gx.num.urlDecimal(gx.O.A85BR_Information_ID,\',\',\'.\')", "gx.O.A36BR_Information_PatientNo"],["A85BR_Information_ID", "A36BR_Information_PatientNo"]);
      return true;
   }
   this.s112_client=function()
   {
      gx.fn.setCtrlProperty("vVNAME","Visible", false );
      gx.fn.setCtrlProperty("VNAME_CELL","Class", "Invisible" );
      gx.fn.setCtrlProperty("vWXNAME","Visible", false );
      gx.fn.setCtrlProperty("WXNAME_CELL","Class", "Invisible" );
      gx.fn.setCtrlProperty("BR_MEDICALIMAGING_METALOC","Visible", false );
      gx.fn.setCtrlProperty("BR_MEDICALIMAGING_METALOC_CELL","Class", "Invisible" );
      gx.fn.setCtrlProperty("BR_MEDICALIMAGING_METADATE","Visible", false );
      gx.fn.setCtrlProperty("BR_MEDICALIMAGING_METADATE_CELL","Class", "Invisible" );
   };
   this.e120t2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130t30_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140t30_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,39,40,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,96,97,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160];
   this.GXLastCtrlId =160;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "褰卞儚瀛?, "str");
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
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_NO",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_MEDICALIMAGING_NO", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medicalimaging_no,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_NO",gxz:"Z518BR_MedicalImaging_No",gxold:"O518BR_MedicalImaging_No",gxvar:"A518BR_MedicalImaging_No",ucs:[],op:[29],ip:[29],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A518BR_MedicalImaging_No=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z518BR_MedicalImaging_No=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_NO",gx.O.A518BR_MedicalImaging_No,0)},c2v:function(){if(this.val()!==undefined)gx.O.A518BR_MedicalImaging_No=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_NO",',')},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"TABLESPLITTEDBR_MEDICALIMAGING_IMAGENAME",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"TEXTBLOCKBR_MEDICALIMAGING_IMAGENAME", format:0,grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"TABLEMERGEDBR_MEDICALIMAGING_IMAGENAME",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id:40 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medicalimaging_imagename,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_IMAGENAME",gxz:"Z228BR_MedicalImaging_ImageName",gxold:"O228BR_MedicalImaging_ImageName",gxvar:"A228BR_MedicalImaging_ImageName",ucs:[],op:[40],ip:[40],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A228BR_MedicalImaging_ImageName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z228BR_MedicalImaging_ImageName=Value},v2c:function(){gx.fn.setComboBoxValue("BR_MEDICALIMAGING_IMAGENAME",gx.O.A228BR_MedicalImaging_ImageName)},c2v:function(){if(this.val()!==undefined)gx.O.A228BR_MedicalImaging_ImageName=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_IMAGENAME")},nac:gx.falseFn};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id:43 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vname,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVNAME",gxz:"ZV15vName",gxold:"OV15vName",gxvar:"AV15vName",ucs:[],op:[43,40],ip:[43,40],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15vName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV15vName=Value},v2c:function(){gx.fn.setControlValue("vVNAME",gx.O.AV15vName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15vName=this.val()},val:function(){return gx.fn.getControlValue("vVNAME")},nac:gx.falseFn};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEAGE",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"TEXTBLOCKBR_MEDICALIMAGING_IMAGEAGE", format:0,grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medicalimaging_imageage,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_IMAGEAGE",gxz:"Z231BR_MedicalImaging_ImageAge",gxold:"O231BR_MedicalImaging_ImageAge",gxvar:"A231BR_MedicalImaging_ImageAge",ucs:[],op:[52],ip:[52],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A231BR_MedicalImaging_ImageAge=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z231BR_MedicalImaging_ImageAge=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_IMAGEAGE",gx.O.A231BR_MedicalImaging_ImageAge,0)},c2v:function(){if(this.val()!==undefined)gx.O.A231BR_MedicalImaging_ImageAge=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_IMAGEAGE",',')},nac:gx.falseFn};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEDATE",grid:0};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"TEXTBLOCKBR_MEDICALIMAGING_IMAGEDATE", format:0,grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id:60 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medicalimaging_imagedate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_IMAGEDATE",gxz:"Z229BR_MedicalImaging_ImageDate",gxold:"O229BR_MedicalImaging_ImageDate",gxvar:"A229BR_MedicalImaging_ImageDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[60],ip:[60],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A229BR_MedicalImaging_ImageDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z229BR_MedicalImaging_ImageDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_IMAGEDATE",gx.O.A229BR_MedicalImaging_ImageDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A229BR_MedicalImaging_ImageDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_IMAGEDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 60 , function() {
   });
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEHOSP",grid:0};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id: 66, fld:"TEXTBLOCKBR_MEDICALIMAGING_IMAGEHOSP", format:0,grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medicalimaging_imagehosp,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_IMAGEHOSP",gxz:"Z230BR_MedicalImaging_ImageHosp",gxold:"O230BR_MedicalImaging_ImageHosp",gxvar:"A230BR_MedicalImaging_ImageHosp",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A230BR_MedicalImaging_ImageHosp=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z230BR_MedicalImaging_ImageHosp=Value},v2c:function(){gx.fn.setComboBoxValue("BR_MEDICALIMAGING_IMAGEHOSP",gx.O.A230BR_MedicalImaging_ImageHosp)},c2v:function(){if(this.val()!==undefined)gx.O.A230BR_MedicalImaging_ImageHosp=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_IMAGEHOSP")},nac:gx.falseFn};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_TUMORSIZE",grid:0};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id: 74, fld:"TEXTBLOCKBR_MEDICALIMAGING_TUMORSIZE", format:0,grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id:77 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_TUMORSIZE",gxz:"Z236BR_MedicalImaging_TumorSize",gxold:"O236BR_MedicalImaging_TumorSize",gxvar:"A236BR_MedicalImaging_TumorSize",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A236BR_MedicalImaging_TumorSize=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z236BR_MedicalImaging_TumorSize=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_TUMORSIZE",gx.O.A236BR_MedicalImaging_TumorSize,0)},c2v:function(){if(this.val()!==undefined)gx.O.A236BR_MedicalImaging_TumorSize=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_TUMORSIZE")},nac:gx.falseFn};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id: 80, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_PREIMAGEDIAG",grid:0};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"",grid:0};
   GXValidFnc[83]={ id: 83, fld:"TEXTBLOCKBR_MEDICALIMAGING_PREIMAGEDIAG", format:0,grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id: 85, fld:"",grid:0};
   GXValidFnc[86]={ id:86 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_PREIMAGEDIAG",gxz:"Z234BR_MedicalImaging_PreImageDiag",gxold:"O234BR_MedicalImaging_PreImageDiag",gxvar:"A234BR_MedicalImaging_PreImageDiag",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A234BR_MedicalImaging_PreImageDiag=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z234BR_MedicalImaging_PreImageDiag=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_PREIMAGEDIAG",gx.O.A234BR_MedicalImaging_PreImageDiag,0)},c2v:function(){if(this.val()!==undefined)gx.O.A234BR_MedicalImaging_PreImageDiag=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_PREIMAGEDIAG")},nac:gx.falseFn};
   GXValidFnc[87]={ id: 87, fld:"",grid:0};
   GXValidFnc[88]={ id: 88, fld:"TABLESPLITTEDBR_MEDICALIMAGING_IMAGELOC",grid:0};
   GXValidFnc[89]={ id: 89, fld:"",grid:0};
   GXValidFnc[90]={ id: 90, fld:"",grid:0};
   GXValidFnc[91]={ id: 91, fld:"TEXTBLOCKBR_MEDICALIMAGING_IMAGELOC", format:0,grid:0};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id: 93, fld:"TABLEMERGEDBR_MEDICALIMAGING_IMAGELOC",grid:0};
   GXValidFnc[96]={ id: 96, fld:"",grid:0};
   GXValidFnc[97]={ id:97 ,lvl:0,type:"svchar",len:5000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medicalimaging_imageloc,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_IMAGELOC",gxz:"Z232BR_MedicalImaging_ImageLoc",gxold:"O232BR_MedicalImaging_ImageLoc",gxvar:"A232BR_MedicalImaging_ImageLoc",ucs:[],op:[],ip:[97],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A232BR_MedicalImaging_ImageLoc=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z232BR_MedicalImaging_ImageLoc=Value},v2c:function(){gx.fn.setComboBoxValue("BR_MEDICALIMAGING_IMAGELOC",gx.O.A232BR_MedicalImaging_ImageLoc)},c2v:function(){if(this.val()!==undefined)gx.O.A232BR_MedicalImaging_ImageLoc=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_IMAGELOC")},nac:gx.falseFn};
   GXValidFnc[99]={ id: 99, fld:"",grid:0};
   GXValidFnc[100]={ id:100 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Wxname,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vWXNAME",gxz:"ZV16wxname",gxold:"OV16wxname",gxvar:"AV16wxname",ucs:[],op:[100,97],ip:[100,97],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV16wxname=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV16wxname=Value},v2c:function(){gx.fn.setControlValue("vWXNAME",gx.O.AV16wxname,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV16wxname=this.val()},val:function(){return gx.fn.getControlValue("vWXNAME")},nac:gx.falseFn};
   GXValidFnc[101]={ id: 101, fld:"",grid:0};
   GXValidFnc[102]={ id: 102, fld:"",grid:0};
   GXValidFnc[103]={ id: 103, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEORGAN",grid:0};
   GXValidFnc[104]={ id: 104, fld:"",grid:0};
   GXValidFnc[105]={ id: 105, fld:"",grid:0};
   GXValidFnc[106]={ id: 106, fld:"TEXTBLOCKBR_MEDICALIMAGING_IMAGEORGAN", format:0,grid:0};
   GXValidFnc[107]={ id: 107, fld:"",grid:0};
   GXValidFnc[108]={ id: 108, fld:"",grid:0};
   GXValidFnc[109]={ id:109 ,lvl:0,type:"svchar",len:5000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_IMAGEORGAN",gxz:"Z233BR_MedicalImaging_ImageOrgan",gxold:"O233BR_MedicalImaging_ImageOrgan",gxvar:"A233BR_MedicalImaging_ImageOrgan",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A233BR_MedicalImaging_ImageOrgan=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z233BR_MedicalImaging_ImageOrgan=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_IMAGEORGAN",gx.O.A233BR_MedicalImaging_ImageOrgan,0)},c2v:function(){if(this.val()!==undefined)gx.O.A233BR_MedicalImaging_ImageOrgan=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_IMAGEORGAN")},nac:gx.falseFn};
   GXValidFnc[110]={ id: 110, fld:"",grid:0};
   GXValidFnc[111]={ id: 111, fld:"",grid:0};
   GXValidFnc[112]={ id: 112, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEDES",grid:0};
   GXValidFnc[113]={ id: 113, fld:"",grid:0};
   GXValidFnc[114]={ id: 114, fld:"",grid:0};
   GXValidFnc[115]={ id: 115, fld:"TEXTBLOCKBR_MEDICALIMAGING_IMAGEDES", format:0,grid:0};
   GXValidFnc[116]={ id: 116, fld:"",grid:0};
   GXValidFnc[117]={ id: 117, fld:"",grid:0};
   GXValidFnc[118]={ id:118 ,lvl:0,type:"svchar",len:9999,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_IMAGEDES",gxz:"Z235BR_MedicalImaging_ImageDes",gxold:"O235BR_MedicalImaging_ImageDes",gxvar:"A235BR_MedicalImaging_ImageDes",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A235BR_MedicalImaging_ImageDes=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z235BR_MedicalImaging_ImageDes=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_IMAGEDES",gx.O.A235BR_MedicalImaging_ImageDes,0)},c2v:function(){if(this.val()!==undefined)gx.O.A235BR_MedicalImaging_ImageDes=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_IMAGEDES")},nac:gx.falseFn};
   GXValidFnc[119]={ id: 119, fld:"",grid:0};
   GXValidFnc[120]={ id: 120, fld:"",grid:0};
   GXValidFnc[121]={ id: 121, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_METASTASESDX",grid:0};
   GXValidFnc[122]={ id: 122, fld:"",grid:0};
   GXValidFnc[123]={ id: 123, fld:"",grid:0};
   GXValidFnc[124]={ id: 124, fld:"TEXTBLOCKBR_MEDICALIMAGING_METASTASESDX", format:0,grid:0};
   GXValidFnc[125]={ id: 125, fld:"",grid:0};
   GXValidFnc[126]={ id: 126, fld:"",grid:0};
   GXValidFnc[127]={ id:127 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medicalimaging_metastasesdx,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_METASTASESDX",gxz:"Z514BR_MedicalImaging_MetastasesDX",gxold:"O514BR_MedicalImaging_MetastasesDX",gxvar:"A514BR_MedicalImaging_MetastasesDX",ucs:[],op:[127],ip:[127],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A514BR_MedicalImaging_MetastasesDX=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z514BR_MedicalImaging_MetastasesDX=Value},v2c:function(){gx.fn.setComboBoxValue("BR_MEDICALIMAGING_METASTASESDX",gx.O.A514BR_MedicalImaging_MetastasesDX);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A514BR_MedicalImaging_MetastasesDX=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_METASTASESDX")},nac:gx.falseFn};
   this.declareDomainHdlr( 127 , function() {
   });
   GXValidFnc[128]={ id: 128, fld:"",grid:0};
   GXValidFnc[129]={ id: 129, fld:"BR_MEDICALIMAGING_METALOC_CELL",grid:0};
   GXValidFnc[130]={ id: 130, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_METALOC",grid:0};
   GXValidFnc[131]={ id: 131, fld:"",grid:0};
   GXValidFnc[132]={ id: 132, fld:"",grid:0};
   GXValidFnc[133]={ id: 133, fld:"TEXTBLOCKBR_MEDICALIMAGING_METALOC", format:0,grid:0};
   GXValidFnc[134]={ id: 134, fld:"",grid:0};
   GXValidFnc[135]={ id: 135, fld:"",grid:0};
   GXValidFnc[136]={ id:136 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_METALOC",gxz:"Z515BR_MedicalImaging_MetaLoc",gxold:"O515BR_MedicalImaging_MetaLoc",gxvar:"A515BR_MedicalImaging_MetaLoc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A515BR_MedicalImaging_MetaLoc=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z515BR_MedicalImaging_MetaLoc=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_METALOC",gx.O.A515BR_MedicalImaging_MetaLoc,0)},c2v:function(){if(this.val()!==undefined)gx.O.A515BR_MedicalImaging_MetaLoc=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_METALOC")},nac:gx.falseFn};
   GXValidFnc[137]={ id: 137, fld:"BR_MEDICALIMAGING_METADATE_CELL",grid:0};
   GXValidFnc[138]={ id: 138, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_METADATE",grid:0};
   GXValidFnc[139]={ id: 139, fld:"",grid:0};
   GXValidFnc[140]={ id: 140, fld:"",grid:0};
   GXValidFnc[141]={ id: 141, fld:"TEXTBLOCKBR_MEDICALIMAGING_METADATE", format:0,grid:0};
   GXValidFnc[142]={ id: 142, fld:"",grid:0};
   GXValidFnc[143]={ id: 143, fld:"",grid:0};
   GXValidFnc[144]={ id:144 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medicalimaging_metadate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_METADATE",gxz:"Z516BR_MedicalImaging_MetaDate",gxold:"O516BR_MedicalImaging_MetaDate",gxvar:"A516BR_MedicalImaging_MetaDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[144],ip:[144],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A516BR_MedicalImaging_MetaDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z516BR_MedicalImaging_MetaDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_METADATE",gx.O.A516BR_MedicalImaging_MetaDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A516BR_MedicalImaging_MetaDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_METADATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 144 , function() {
   });
   GXValidFnc[145]={ id: 145, fld:"",grid:0};
   GXValidFnc[146]={ id: 146, fld:"",grid:0};
   GXValidFnc[147]={ id: 147, fld:"",grid:0};
   GXValidFnc[148]={ id: 148, fld:"",grid:0};
   GXValidFnc[149]={ id: 149, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[150]={ id: 150, fld:"",grid:0};
   GXValidFnc[151]={ id: 151, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[152]={ id: 152, fld:"",grid:0};
   GXValidFnc[153]={ id: 153, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[154]={ id: 154, fld:"",grid:0};
   GXValidFnc[155]={ id: 155, fld:"",grid:0};
   GXValidFnc[156]={ id: 156, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[157]={ id:157 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_medicalimagingid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGINGID",gxz:"Z225BR_MedicalImagingID",gxold:"O225BR_MedicalImagingID",gxvar:"A225BR_MedicalImagingID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A225BR_MedicalImagingID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z225BR_MedicalImagingID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGINGID",gx.O.A225BR_MedicalImagingID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A225BR_MedicalImagingID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGINGID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 157 , function() {
   });
   GXValidFnc[158]={ id:158 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[159],ip:[159,158],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV13Insert_BR_EncounterID))}};
   this.declareDomainHdlr( 158 , function() {
   });
   GXValidFnc[159]={ id:159 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A36BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z36BR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_PATIENTNO",gx.O.A36BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A36BR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[160]={ id:160 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_ID",gxz:"Z227BR_MedicalImaging_ID",gxold:"O227BR_MedicalImaging_ID",gxvar:"A227BR_MedicalImaging_ID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A227BR_MedicalImaging_ID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z227BR_MedicalImaging_ID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_ID",gx.O.A227BR_MedicalImaging_ID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A227BR_MedicalImaging_ID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_ID",',')},nac:gx.falseFn};
   this.A518BR_MedicalImaging_No = 0 ;
   this.Z518BR_MedicalImaging_No = 0 ;
   this.O518BR_MedicalImaging_No = 0 ;
   this.A228BR_MedicalImaging_ImageName = "" ;
   this.Z228BR_MedicalImaging_ImageName = "" ;
   this.O228BR_MedicalImaging_ImageName = "" ;
   this.AV15vName = "" ;
   this.ZV15vName = "" ;
   this.OV15vName = "" ;
   this.A231BR_MedicalImaging_ImageAge = 0 ;
   this.Z231BR_MedicalImaging_ImageAge = 0 ;
   this.O231BR_MedicalImaging_ImageAge = 0 ;
   this.A229BR_MedicalImaging_ImageDate = gx.date.nullDate() ;
   this.Z229BR_MedicalImaging_ImageDate = gx.date.nullDate() ;
   this.O229BR_MedicalImaging_ImageDate = gx.date.nullDate() ;
   this.A230BR_MedicalImaging_ImageHosp = "" ;
   this.Z230BR_MedicalImaging_ImageHosp = "" ;
   this.O230BR_MedicalImaging_ImageHosp = "" ;
   this.A236BR_MedicalImaging_TumorSize = "" ;
   this.Z236BR_MedicalImaging_TumorSize = "" ;
   this.O236BR_MedicalImaging_TumorSize = "" ;
   this.A234BR_MedicalImaging_PreImageDiag = "" ;
   this.Z234BR_MedicalImaging_PreImageDiag = "" ;
   this.O234BR_MedicalImaging_PreImageDiag = "" ;
   this.A232BR_MedicalImaging_ImageLoc = "" ;
   this.Z232BR_MedicalImaging_ImageLoc = "" ;
   this.O232BR_MedicalImaging_ImageLoc = "" ;
   this.AV16wxname = "" ;
   this.ZV16wxname = "" ;
   this.OV16wxname = "" ;
   this.A233BR_MedicalImaging_ImageOrgan = "" ;
   this.Z233BR_MedicalImaging_ImageOrgan = "" ;
   this.O233BR_MedicalImaging_ImageOrgan = "" ;
   this.A235BR_MedicalImaging_ImageDes = "" ;
   this.Z235BR_MedicalImaging_ImageDes = "" ;
   this.O235BR_MedicalImaging_ImageDes = "" ;
   this.A514BR_MedicalImaging_MetastasesDX = "" ;
   this.Z514BR_MedicalImaging_MetastasesDX = "" ;
   this.O514BR_MedicalImaging_MetastasesDX = "" ;
   this.A515BR_MedicalImaging_MetaLoc = "" ;
   this.Z515BR_MedicalImaging_MetaLoc = "" ;
   this.O515BR_MedicalImaging_MetaLoc = "" ;
   this.A516BR_MedicalImaging_MetaDate = gx.date.nullDate() ;
   this.Z516BR_MedicalImaging_MetaDate = gx.date.nullDate() ;
   this.O516BR_MedicalImaging_MetaDate = gx.date.nullDate() ;
   this.A225BR_MedicalImagingID = 0 ;
   this.Z225BR_MedicalImagingID = 0 ;
   this.O225BR_MedicalImagingID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.Z36BR_Information_PatientNo = "" ;
   this.O36BR_Information_PatientNo = "" ;
   this.A227BR_MedicalImaging_ID = 0 ;
   this.Z227BR_MedicalImaging_ID = 0 ;
   this.O227BR_MedicalImaging_ID = 0 ;
   this.A85BR_Information_ID = 0 ;
   this.AV18tCurrentCode = "" ;
   this.AV8WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV9IsAuthorized = false ;
   this.AV19Pgmname = "" ;
   this.AV11TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV20GXV1 = 0 ;
   this.AV13Insert_BR_EncounterID = 0 ;
   this.AV17TempBoolean = false ;
   this.AV14TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV7BR_MedicalImagingID = 0 ;
   this.AV12WebSession = {} ;
   this.A225BR_MedicalImagingID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.AV15vName = "" ;
   this.AV16wxname = "" ;
   this.A484BR_MedicalImaging_ImageName_Code = "" ;
   this.A485BR_MedicalImaging_ImageHosp_Code = "" ;
   this.A36BR_Information_PatientNo = "" ;
   this.A227BR_MedicalImaging_ID = 0 ;
   this.A518BR_MedicalImaging_No = 0 ;
   this.A228BR_MedicalImaging_ImageName = "" ;
   this.A229BR_MedicalImaging_ImageDate = gx.date.nullDate() ;
   this.A230BR_MedicalImaging_ImageHosp = "" ;
   this.A231BR_MedicalImaging_ImageAge = 0 ;
   this.A232BR_MedicalImaging_ImageLoc = "" ;
   this.A486BR_MedicalImaging_ImageLoc_Code = "" ;
   this.A233BR_MedicalImaging_ImageOrgan = "" ;
   this.A234BR_MedicalImaging_PreImageDiag = "" ;
   this.A235BR_MedicalImaging_ImageDes = "" ;
   this.A236BR_MedicalImaging_TumorSize = "" ;
   this.A334BR_MedicalImaging_ImageHtml = "" ;
   this.A514BR_MedicalImaging_MetastasesDX = "" ;
   this.A515BR_MedicalImaging_MetaLoc = "" ;
   this.A516BR_MedicalImaging_MetaDate = gx.date.nullDate() ;
   this.Gx_mode = "" ;
   this.Events = {"e120t2_client": ["AFTER TRN", true] ,"e130t30_client": ["ENTER", true] ,"e140t30_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_MedicalImagingID',fld:'vBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_MedicalImagingID',fld:'vBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A225BR_MedicalImagingID',fld:'BR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV13Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A486BR_MedicalImaging_ImageLoc_Code',fld:'BR_MEDICALIMAGING_IMAGELOC_CODE',pic:''}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV19Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV18tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV8WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV9IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV20GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV14TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV13Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGINGID","Visible")',ctrl:'BR_MEDICALIMAGINGID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Visible")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_ID","Visible")',ctrl:'BR_MEDICALIMAGING_ID',prop:'Visible'},{av:'AV17TempBoolean',fld:'vTEMPBOOLEAN',pic:''},{ctrl:'BTNTRN_ENTER',prop:'Visible'},{ctrl:'BTNTRN_CANCEL',prop:'Visible'},{ctrl:'BTNTRN_DELETE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vVNAME","Visible")',ctrl:'vVNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("VNAME_CELL","Class")',ctrl:'VNAME_CELL',prop:'Class'},{av:'gx.fn.getCtrlProperty("vWXNAME","Visible")',ctrl:'vWXNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("WXNAME_CELL","Class")',ctrl:'WXNAME_CELL',prop:'Class'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_METALOC","Visible")',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_METALOC_CELL","Class")',ctrl:'BR_MEDICALIMAGING_METALOC_CELL',prop:'Class'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_METADATE","Visible")',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_METADATE_CELL","Class")',ctrl:'BR_MEDICALIMAGING_METADATE_CELL',prop:'Class'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'A225BR_MedicalImagingID',fld:'BR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7BR_MedicalImagingID", "vBR_MEDICALIMAGINGID", 0, "int", 18, 0);
   this.setVCMap("AV13Insert_BR_EncounterID", "vINSERT_BR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("A484BR_MedicalImaging_ImageName_Code", "BR_MEDICALIMAGING_IMAGENAME_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A485BR_MedicalImaging_ImageHosp_Code", "BR_MEDICALIMAGING_IMAGEHOSP_CODE", 0, "svchar", 40, 0);
   this.setVCMap("AV18tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("A486BR_MedicalImaging_ImageLoc_Code", "BR_MEDICALIMAGING_IMAGELOC_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A334BR_MedicalImaging_ImageHtml", "BR_MEDICALIMAGING_IMAGEHTML", 0, "vchar", 2097152, 0);
   this.setVCMap("A85BR_Information_ID", "BR_INFORMATION_ID", 0, "int", 18, 0);
   this.setVCMap("AV19Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV11TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_medicalimaging);
