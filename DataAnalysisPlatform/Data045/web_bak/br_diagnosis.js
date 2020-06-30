/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:36:21.32
*/
gx.evt.autoSkip = false;
gx.define('br_diagnosis', false, function () {
   this.ServerClass =  "br_diagnosis" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV12BR_DiagnosisID=gx.fn.getIntegerValue("vBR_DIAGNOSISID",',') ;
      this.AV10Insert_BR_EncounterID=gx.fn.getIntegerValue("vINSERT_BR_ENCOUNTERID",',') ;
      this.A466BR_Diagnosis_DXType_Code=gx.fn.getControlValue("BR_DIAGNOSIS_DXTYPE_CODE") ;
      this.A467BR_Diagnosis_DXTsource_Code=gx.fn.getControlValue("BR_DIAGNOSIS_DXTSOURCE_CODE") ;
      this.A503BR_Diagnosis_InitialDX_Code=gx.fn.getControlValue("BR_DIAGNOSIS_INITIALDX_CODE") ;
      this.A504BR_Diagnosis_MetastasesDX_Code=gx.fn.getControlValue("BR_DIAGNOSIS_METASTASESDX_CODE") ;
      this.AV15tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.A569BR_Diagnosis_TumorStageClinical=gx.fn.getControlValue("BR_DIAGNOSIS_TUMORSTAGECLINICAL") ;
      this.A85BR_Information_ID=gx.fn.getIntegerValue("BR_INFORMATION_ID",',') ;
      this.AV16Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV8TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_diagnosisid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DIAGNOSISID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_diagnosis_no=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DIAGNOSIS_NO");
         this.AnyError  = 0;
         if ( ((0==this.A513BR_Diagnosis_No)) )
         {
            try {
               gxballoon.setError("璇婃柇娆″簭鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_diagnosis_dxdescription=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DIAGNOSIS_DXDESCRIPTION");
         this.AnyError  = 0;
         if ( ((''==this.A69BR_Diagnosis_DXDescription)) )
         {
            try {
               gxballoon.setError("璇婃柇鍚嶇О鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_diagnosis_dxtsource=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DIAGNOSIS_DXTSOURCE");
         this.AnyError  = 0;
         if ( ((''==this.A68BR_Diagnosis_DXTsource)) )
         {
            try {
               gxballoon.setError("璇婃柇鏉ユ簮鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_diagnosis_dxtype=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DIAGNOSIS_DXTYPE");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_diagnosis_initialdx=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DIAGNOSIS_INITIALDX");
         this.AnyError  = 0;
         if ( ! ( ( this.A70BR_Diagnosis_InitialDX == "鍚? ) || ( this.A70BR_Diagnosis_InitialDX == "鏄? ) || ( this.A70BR_Diagnosis_InitialDX == "涓嶈" ) || ((''==this.A70BR_Diagnosis_InitialDX)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
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
   this.Valid_Br_diagnosis_metastasesdx=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DIAGNOSIS_METASTASESDX");
         this.AnyError  = 0;
         if ( ! ( ( this.A71BR_Diagnosis_MetastasesDX == "鍚? ) || ( this.A71BR_Diagnosis_MetastasesDX == "鏄? ) || ( this.A71BR_Diagnosis_MetastasesDX == "涓嶈" ) || ((''==this.A71BR_Diagnosis_MetastasesDX)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }
         try {
            gx.fn.setCtrlProperty("BR_DIAGNOSIS_DXSOURCE","Visible", (this.A71BR_Diagnosis_MetastasesDX=="鏄?) );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A71BR_Diagnosis_MetastasesDX == "鏄? ) ) )
            {
               gx.fn.setCtrlProperty("BR_DIAGNOSIS_DXSOURCE_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A71BR_Diagnosis_MetastasesDX == "鏄? )
               {
                  gx.fn.setCtrlProperty("BR_DIAGNOSIS_DXSOURCE_CELL","Class", "col-xs-12 col-md-6" );
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
   this.Valid_Br_encounterid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_encounterid",["gx.num.urlDecimal(gx.O.A19BR_EncounterID,\',\',\'.\')", "gx.num.urlDecimal(gx.O.A85BR_Information_ID,\',\',\'.\')", "gx.O.A36BR_Information_PatientNo"],["A85BR_Information_ID", "A36BR_Information_PatientNo"]);
      return true;
   }
   this.s112_client=function()
   {
      gx.fn.setCtrlProperty("BR_DIAGNOSIS_DXSOURCE","Visible", false );
      gx.fn.setCtrlProperty("BR_DIAGNOSIS_DXSOURCE_CELL","Class", "Invisible" );
   };
   this.e120c2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130c13_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140c13_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112];
   this.GXLastCtrlId =112;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "璇婃柇", "str");
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
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEBR_DIAGNOSIS_NO",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_DIAGNOSIS_NO", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_diagnosis_no,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_NO",gxz:"Z513BR_Diagnosis_No",gxold:"O513BR_Diagnosis_No",gxvar:"A513BR_Diagnosis_No",ucs:[],op:[29],ip:[29],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A513BR_Diagnosis_No=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z513BR_Diagnosis_No=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_DIAGNOSIS_NO",gx.O.A513BR_Diagnosis_No,0)},c2v:function(){if(this.val()!==undefined)gx.O.A513BR_Diagnosis_No=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_DIAGNOSIS_NO",',')},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLEBR_DIAGNOSIS_DXDESCRIPTION",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"TEXTBLOCKBR_DIAGNOSIS_DXDESCRIPTION", format:0,grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_diagnosis_dxdescription,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_DXDESCRIPTION",gxz:"Z69BR_Diagnosis_DXDescription",gxold:"O69BR_Diagnosis_DXDescription",gxvar:"A69BR_Diagnosis_DXDescription",ucs:[],op:[37],ip:[37],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A69BR_Diagnosis_DXDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z69BR_Diagnosis_DXDescription=Value},v2c:function(){gx.fn.setControlValue("BR_DIAGNOSIS_DXDESCRIPTION",gx.O.A69BR_Diagnosis_DXDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A69BR_Diagnosis_DXDescription=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_DXDESCRIPTION")},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"UNNAMEDTABLEBR_DIAGNOSIS_DXTSOURCE",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"TEXTBLOCKBR_DIAGNOSIS_DXTSOURCE", format:0,grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_diagnosis_dxtsource,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_DXTSOURCE",gxz:"Z68BR_Diagnosis_DXTsource",gxold:"O68BR_Diagnosis_DXTsource",gxvar:"A68BR_Diagnosis_DXTsource",ucs:[],op:[46],ip:[46],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A68BR_Diagnosis_DXTsource=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z68BR_Diagnosis_DXTsource=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DIAGNOSIS_DXTSOURCE",gx.O.A68BR_Diagnosis_DXTsource)},c2v:function(){if(this.val()!==undefined)gx.O.A68BR_Diagnosis_DXTsource=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_DXTSOURCE")},nac:gx.falseFn};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"UNNAMEDTABLEBR_DIAGNOSIS_DXID",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"TEXTBLOCKBR_DIAGNOSIS_DXID", format:0,grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_DXID",gxz:"Z65BR_Diagnosis_DXID",gxold:"O65BR_Diagnosis_DXID",gxvar:"A65BR_Diagnosis_DXID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A65BR_Diagnosis_DXID=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z65BR_Diagnosis_DXID=Value},v2c:function(){gx.fn.setControlValue("BR_DIAGNOSIS_DXID",gx.O.A65BR_Diagnosis_DXID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A65BR_Diagnosis_DXID=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_DXID")},nac:gx.falseFn};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"UNNAMEDTABLEBR_DIAGNOSIS_DXCODE",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"TEXTBLOCKBR_DIAGNOSIS_DXCODE", format:0,grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_DXCODE",gxz:"Z66BR_Diagnosis_DXCode",gxold:"O66BR_Diagnosis_DXCode",gxvar:"A66BR_Diagnosis_DXCode",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A66BR_Diagnosis_DXCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z66BR_Diagnosis_DXCode=Value},v2c:function(){gx.fn.setControlValue("BR_DIAGNOSIS_DXCODE",gx.O.A66BR_Diagnosis_DXCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.A66BR_Diagnosis_DXCode=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_DXCODE")},nac:gx.falseFn};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"UNNAMEDTABLEBR_DIAGNOSIS_DXTYPE",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"TEXTBLOCKBR_DIAGNOSIS_DXTYPE", format:0,grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_diagnosis_dxtype,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_DXTYPE",gxz:"Z67BR_Diagnosis_DXType",gxold:"O67BR_Diagnosis_DXType",gxvar:"A67BR_Diagnosis_DXType",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A67BR_Diagnosis_DXType=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z67BR_Diagnosis_DXType=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DIAGNOSIS_DXTYPE",gx.O.A67BR_Diagnosis_DXType)},c2v:function(){if(this.val()!==undefined)gx.O.A67BR_Diagnosis_DXType=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_DXTYPE")},nac:gx.falseFn};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id: 74, fld:"UNNAMEDTABLEBR_DIAGNOSIS_INITIALDX",grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"TEXTBLOCKBR_DIAGNOSIS_INITIALDX", format:0,grid:0};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id:80 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_diagnosis_initialdx,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_INITIALDX",gxz:"Z70BR_Diagnosis_InitialDX",gxold:"O70BR_Diagnosis_InitialDX",gxvar:"A70BR_Diagnosis_InitialDX",ucs:[],op:[80],ip:[80],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A70BR_Diagnosis_InitialDX=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z70BR_Diagnosis_InitialDX=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DIAGNOSIS_INITIALDX",gx.O.A70BR_Diagnosis_InitialDX);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A70BR_Diagnosis_InitialDX=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_INITIALDX")},nac:gx.falseFn};
   this.declareDomainHdlr( 80 , function() {
   });
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"",grid:0};
   GXValidFnc[83]={ id: 83, fld:"UNNAMEDTABLEBR_DIAGNOSIS_METASTASESDX",grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id: 85, fld:"",grid:0};
   GXValidFnc[86]={ id: 86, fld:"TEXTBLOCKBR_DIAGNOSIS_METASTASESDX", format:0,grid:0};
   GXValidFnc[87]={ id: 87, fld:"",grid:0};
   GXValidFnc[88]={ id: 88, fld:"",grid:0};
   GXValidFnc[89]={ id:89 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_diagnosis_metastasesdx,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_METASTASESDX",gxz:"Z71BR_Diagnosis_MetastasesDX",gxold:"O71BR_Diagnosis_MetastasesDX",gxvar:"A71BR_Diagnosis_MetastasesDX",ucs:[],op:[89],ip:[89],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A71BR_Diagnosis_MetastasesDX=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z71BR_Diagnosis_MetastasesDX=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DIAGNOSIS_METASTASESDX",gx.O.A71BR_Diagnosis_MetastasesDX);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A71BR_Diagnosis_MetastasesDX=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_METASTASESDX")},nac:gx.falseFn};
   this.declareDomainHdlr( 89 , function() {
   });
   GXValidFnc[90]={ id: 90, fld:"BR_DIAGNOSIS_DXSOURCE_CELL",grid:0};
   GXValidFnc[91]={ id: 91, fld:"UNNAMEDTABLEBR_DIAGNOSIS_DXSOURCE",grid:0};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id: 93, fld:"",grid:0};
   GXValidFnc[94]={ id: 94, fld:"TEXTBLOCKBR_DIAGNOSIS_DXSOURCE", format:0,grid:0};
   GXValidFnc[95]={ id: 95, fld:"",grid:0};
   GXValidFnc[96]={ id: 96, fld:"",grid:0};
   GXValidFnc[97]={ id:97 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_DXSOURCE",gxz:"Z260BR_Diagnosis_DXSource",gxold:"O260BR_Diagnosis_DXSource",gxvar:"A260BR_Diagnosis_DXSource",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A260BR_Diagnosis_DXSource=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z260BR_Diagnosis_DXSource=Value},v2c:function(){gx.fn.setControlValue("BR_DIAGNOSIS_DXSOURCE",gx.O.A260BR_Diagnosis_DXSource,0)},c2v:function(){if(this.val()!==undefined)gx.O.A260BR_Diagnosis_DXSource=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_DXSOURCE")},nac:gx.falseFn};
   GXValidFnc[98]={ id: 98, fld:"",grid:0};
   GXValidFnc[99]={ id: 99, fld:"",grid:0};
   GXValidFnc[100]={ id: 100, fld:"",grid:0};
   GXValidFnc[101]={ id: 101, fld:"",grid:0};
   GXValidFnc[102]={ id: 102, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[103]={ id: 103, fld:"",grid:0};
   GXValidFnc[104]={ id: 104, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[105]={ id: 105, fld:"",grid:0};
   GXValidFnc[106]={ id: 106, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[107]={ id: 107, fld:"",grid:0};
   GXValidFnc[108]={ id: 108, fld:"",grid:0};
   GXValidFnc[109]={ id: 109, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[110]={ id:110 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_diagnosisid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSISID",gxz:"Z64BR_DiagnosisID",gxold:"O64BR_DiagnosisID",gxvar:"A64BR_DiagnosisID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A64BR_DiagnosisID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z64BR_DiagnosisID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_DIAGNOSISID",gx.O.A64BR_DiagnosisID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A64BR_DiagnosisID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_DIAGNOSISID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 110 , function() {
   });
   GXValidFnc[111]={ id:111 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[112],ip:[112,111],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV10Insert_BR_EncounterID))}};
   this.declareDomainHdlr( 111 , function() {
   });
   GXValidFnc[112]={ id:112 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A36BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z36BR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_PATIENTNO",gx.O.A36BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A36BR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   this.A513BR_Diagnosis_No = 0 ;
   this.Z513BR_Diagnosis_No = 0 ;
   this.O513BR_Diagnosis_No = 0 ;
   this.A69BR_Diagnosis_DXDescription = "" ;
   this.Z69BR_Diagnosis_DXDescription = "" ;
   this.O69BR_Diagnosis_DXDescription = "" ;
   this.A68BR_Diagnosis_DXTsource = "" ;
   this.Z68BR_Diagnosis_DXTsource = "" ;
   this.O68BR_Diagnosis_DXTsource = "" ;
   this.A65BR_Diagnosis_DXID = "" ;
   this.Z65BR_Diagnosis_DXID = "" ;
   this.O65BR_Diagnosis_DXID = "" ;
   this.A66BR_Diagnosis_DXCode = "" ;
   this.Z66BR_Diagnosis_DXCode = "" ;
   this.O66BR_Diagnosis_DXCode = "" ;
   this.A67BR_Diagnosis_DXType = "" ;
   this.Z67BR_Diagnosis_DXType = "" ;
   this.O67BR_Diagnosis_DXType = "" ;
   this.A70BR_Diagnosis_InitialDX = "" ;
   this.Z70BR_Diagnosis_InitialDX = "" ;
   this.O70BR_Diagnosis_InitialDX = "" ;
   this.A71BR_Diagnosis_MetastasesDX = "" ;
   this.Z71BR_Diagnosis_MetastasesDX = "" ;
   this.O71BR_Diagnosis_MetastasesDX = "" ;
   this.A260BR_Diagnosis_DXSource = "" ;
   this.Z260BR_Diagnosis_DXSource = "" ;
   this.O260BR_Diagnosis_DXSource = "" ;
   this.A64BR_DiagnosisID = 0 ;
   this.Z64BR_DiagnosisID = 0 ;
   this.O64BR_DiagnosisID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.Z36BR_Information_PatientNo = "" ;
   this.O36BR_Information_PatientNo = "" ;
   this.A85BR_Information_ID = 0 ;
   this.AV15tCurrentCode = "" ;
   this.AV7WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV13IsAuthorized = false ;
   this.AV16Pgmname = "" ;
   this.AV8TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV17GXV1 = 0 ;
   this.AV10Insert_BR_EncounterID = 0 ;
   this.AV11TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV12BR_DiagnosisID = 0 ;
   this.AV9WebSession = {} ;
   this.A64BR_DiagnosisID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A466BR_Diagnosis_DXType_Code = "" ;
   this.A467BR_Diagnosis_DXTsource_Code = "" ;
   this.A503BR_Diagnosis_InitialDX_Code = "" ;
   this.A504BR_Diagnosis_MetastasesDX_Code = "" ;
   this.A36BR_Information_PatientNo = "" ;
   this.A513BR_Diagnosis_No = 0 ;
   this.A65BR_Diagnosis_DXID = "" ;
   this.A66BR_Diagnosis_DXCode = "" ;
   this.A67BR_Diagnosis_DXType = "" ;
   this.A68BR_Diagnosis_DXTsource = "" ;
   this.A69BR_Diagnosis_DXDescription = "" ;
   this.A70BR_Diagnosis_InitialDX = "" ;
   this.A71BR_Diagnosis_MetastasesDX = "" ;
   this.A260BR_Diagnosis_DXSource = "" ;
   this.A569BR_Diagnosis_TumorStageClinical = "" ;
   this.Gx_mode = "" ;
   this.Events = {"e120c2_client": ["AFTER TRN", true] ,"e130c13_client": ["ENTER", true] ,"e140c13_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_DiagnosisID',fld:'vBR_DIAGNOSISID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_DiagnosisID',fld:'vBR_DIAGNOSISID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A64BR_DiagnosisID',fld:'BR_DIAGNOSISID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV15tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A569BR_Diagnosis_TumorStageClinical',fld:'BR_DIAGNOSIS_TUMORSTAGECLINICAL',pic:''}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV16Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV15tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV7WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV13IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV17GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV11TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSISID","Visible")',ctrl:'BR_DIAGNOSISID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Visible")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXSOURCE","Visible")',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXSOURCE_CELL","Class")',ctrl:'BR_DIAGNOSIS_DXSOURCE_CELL',prop:'Class'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV12BR_DiagnosisID", "vBR_DIAGNOSISID", 0, "int", 18, 0);
   this.setVCMap("AV10Insert_BR_EncounterID", "vINSERT_BR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("A466BR_Diagnosis_DXType_Code", "BR_DIAGNOSIS_DXTYPE_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A467BR_Diagnosis_DXTsource_Code", "BR_DIAGNOSIS_DXTSOURCE_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A503BR_Diagnosis_InitialDX_Code", "BR_DIAGNOSIS_INITIALDX_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A504BR_Diagnosis_MetastasesDX_Code", "BR_DIAGNOSIS_METASTASESDX_CODE", 0, "svchar", 40, 0);
   this.setVCMap("AV15tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("A569BR_Diagnosis_TumorStageClinical", "BR_DIAGNOSIS_TUMORSTAGECLINICAL", 0, "svchar", 40, 0);
   this.setVCMap("A85BR_Information_ID", "BR_INFORMATION_ID", 0, "int", 18, 0);
   this.setVCMap("AV16Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV8TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_diagnosis);
