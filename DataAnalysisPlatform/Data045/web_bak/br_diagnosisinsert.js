/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:47:23.89
*/
gx.evt.autoSkip = false;
gx.define('br_diagnosisinsert', false, function () {
   this.ServerClass =  "br_diagnosisinsert" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV14tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.AV5BR_Diagnosis=gx.fn.getControlValue("vBR_DIAGNOSIS") ;
      this.AV6BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
   };
   this.Validv_Vmetastasesdx=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVMETASTASESDX");
         this.AnyError  = 0;
         if ( ! ( ( this.AV18vMetastasesDX == "鍚? ) || ( this.AV18vMetastasesDX == "鏄? ) || ( this.AV18vMetastasesDX == "涓嶈" ) || ((''==this.AV18vMetastasesDX)) ) )
         {
            try {
               gxballoon.setError("鍩焩 Metastases DX瓒呯晫");
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
   this.e158n1_client=function()
   {
      this.clearMessages();
      if ( this.AV18vMetastasesDX == "鏄? )
      {
         gx.fn.setCtrlProperty("vVDXSOURCE","Visible", true );
      }
      else
      {
         gx.fn.setCtrlProperty("vVDXSOURCE","Visible", false );
      }
      this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vVDXSOURCE","Visible")',ctrl:'vVDXSOURCE',prop:'Visible'}]);
      return gx.$.Deferred().resolve();
   };
   this.e138n2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e168n1_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76];
   this.GXLastCtrlId =76;
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
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id:25 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_BR_DIAGNOSIS_NO",gxz:"ZV23GXV1",gxold:"OV23GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV1=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV23GXV1=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_DIAGNOSIS_BR_DIAGNOSIS_NO",gx.O.GXV1,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV1=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_DIAGNOSIS_BR_DIAGNOSIS_NO",',')},nac:gx.falseFn};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_BR_DIAGNOSIS_DXDESCRIPTION",gxz:"ZV24GXV2",gxold:"OV24GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV2=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24GXV2=Value},v2c:function(){gx.fn.setControlValue("BR_DIAGNOSIS_BR_DIAGNOSIS_DXDESCRIPTION",gx.O.GXV2,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV2=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_BR_DIAGNOSIS_DXDESCRIPTION")},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id:34 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVDXTSOURCE",gxz:"ZV13vDXTsource",gxold:"OV13vDXTsource",gxvar:"AV13vDXTsource",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.AV13vDXTsource=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV13vDXTsource=Value},v2c:function(){gx.fn.setComboBoxValue("vVDXTSOURCE",gx.O.AV13vDXTsource)},c2v:function(){if(this.val()!==undefined)gx.O.AV13vDXTsource=this.val()},val:function(){return gx.fn.getControlValue("vVDXTSOURCE")},nac:gx.falseFn};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id:38 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_BR_DIAGNOSIS_DXID",gxz:"ZV25GXV3",gxold:"OV25GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV3=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25GXV3=Value},v2c:function(){gx.fn.setControlValue("BR_DIAGNOSIS_BR_DIAGNOSIS_DXID",gx.O.GXV3,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV3=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_BR_DIAGNOSIS_DXID")},nac:gx.falseFn};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id:43 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_BR_DIAGNOSIS_DXCODE",gxz:"ZV26GXV4",gxold:"OV26GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV4=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26GXV4=Value},v2c:function(){gx.fn.setControlValue("BR_DIAGNOSIS_BR_DIAGNOSIS_DXCODE",gx.O.GXV4,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV4=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_BR_DIAGNOSIS_DXCODE")},nac:gx.falseFn};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVDXTYPE",gxz:"ZV15vDXType",gxold:"OV15vDXType",gxvar:"AV15vDXType",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.AV15vDXType=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV15vDXType=Value},v2c:function(){gx.fn.setComboBoxValue("vVDXTYPE",gx.O.AV15vDXType)},c2v:function(){if(this.val()!==undefined)gx.O.AV15vDXType=this.val()},val:function(){return gx.fn.getControlValue("vVDXTYPE")},nac:gx.falseFn};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_BR_DIAGNOSIS_INITIALDX",gxz:"ZV27GXV5",gxold:"OV27GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.GXV5=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27GXV5=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DIAGNOSIS_BR_DIAGNOSIS_INITIALDX",gx.O.GXV5)},c2v:function(){if(this.val()!==undefined)gx.O.GXV5=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_BR_DIAGNOSIS_INITIALDX")},nac:gx.falseFn};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vmetastasesdx,isvalid:null,evt_cvc:'e158n1_client',evt_cvcing:null,rgrid:[],fld:"vVMETASTASESDX",gxz:"ZV18vMetastasesDX",gxold:"OV18vMetastasesDX",gxvar:"AV18vMetastasesDX",ucs:[],op:[56],ip:[56],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV18vMetastasesDX=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV18vMetastasesDX=Value},v2c:function(){gx.fn.setComboBoxValue("vVMETASTASESDX",gx.O.AV18vMetastasesDX)},c2v:function(){if(this.val()!==undefined)gx.O.AV18vMetastasesDX=this.val()},val:function(){return gx.fn.getControlValue("vVMETASTASESDX")},nac:gx.falseFn};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVDXSOURCE",gxz:"ZV19vDXSource",gxold:"OV19vDXSource",gxvar:"AV19vDXSource",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19vDXSource=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19vDXSource=Value},v2c:function(){gx.fn.setControlValue("vVDXSOURCE",gx.O.AV19vDXSource,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19vDXSource=this.val()},val:function(){return gx.fn.getControlValue("vVDXSOURCE")},nac:gx.falseFn};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"",grid:0};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id: 66, fld:"BTNENTER",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"BTNCANCEL",grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[72]={ id:72 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_BR_DIAGNOSISID",gxz:"ZV28GXV6",gxold:"OV28GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV6=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV28GXV6=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_DIAGNOSIS_BR_DIAGNOSISID",gx.O.GXV6,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV6=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_DIAGNOSIS_BR_DIAGNOSISID",',')},nac:gx.falseFn};
   GXValidFnc[73]={ id:73 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_BR_ENCOUNTERID",gxz:"ZV29GXV7",gxold:"OV29GXV7",gxvar:"GXV7",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV7=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV29GXV7=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_DIAGNOSIS_BR_ENCOUNTERID",gx.O.GXV7,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV7=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_DIAGNOSIS_BR_ENCOUNTERID",',')},nac:gx.falseFn};
   GXValidFnc[74]={ id:74 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_BR_INFORMATION_PATIENTNO",gxz:"ZV30GXV8",gxold:"OV30GXV8",gxvar:"GXV8",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV8=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30GXV8=Value},v2c:function(){gx.fn.setControlValue("BR_DIAGNOSIS_BR_INFORMATION_PATIENTNO",gx.O.GXV8,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV8=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[75]={ id:75 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE",gxz:"ZV31GXV9",gxold:"OV31GXV9",gxvar:"GXV9",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.GXV9=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31GXV9=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE",gx.O.GXV9)},c2v:function(){if(this.val()!==undefined)gx.O.GXV9=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE")},nac:gx.falseFn};
   GXValidFnc[76]={ id:76 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE",gxz:"ZV32GXV10",gxold:"OV32GXV10",gxvar:"GXV10",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.GXV10=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV32GXV10=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE",gx.O.GXV10)},c2v:function(){if(this.val()!==undefined)gx.O.GXV10=this.val()},val:function(){return gx.fn.getControlValue("BR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE")},nac:gx.falseFn};
   this.GXV1 = 0 ;
   this.ZV23GXV1 = 0 ;
   this.OV23GXV1 = 0 ;
   this.GXV2 = "" ;
   this.ZV24GXV2 = "" ;
   this.OV24GXV2 = "" ;
   this.AV13vDXTsource = "" ;
   this.ZV13vDXTsource = "" ;
   this.OV13vDXTsource = "" ;
   this.GXV3 = "" ;
   this.ZV25GXV3 = "" ;
   this.OV25GXV3 = "" ;
   this.GXV4 = "" ;
   this.ZV26GXV4 = "" ;
   this.OV26GXV4 = "" ;
   this.AV15vDXType = "" ;
   this.ZV15vDXType = "" ;
   this.OV15vDXType = "" ;
   this.GXV5 = "" ;
   this.ZV27GXV5 = "" ;
   this.OV27GXV5 = "" ;
   this.AV18vMetastasesDX = "" ;
   this.ZV18vMetastasesDX = "" ;
   this.OV18vMetastasesDX = "" ;
   this.AV19vDXSource = "" ;
   this.ZV19vDXSource = "" ;
   this.OV19vDXSource = "" ;
   this.GXV6 = 0 ;
   this.ZV28GXV6 = 0 ;
   this.OV28GXV6 = 0 ;
   this.GXV7 = 0 ;
   this.ZV29GXV7 = 0 ;
   this.OV29GXV7 = 0 ;
   this.GXV8 = "" ;
   this.ZV30GXV8 = "" ;
   this.OV30GXV8 = "" ;
   this.GXV9 = "" ;
   this.ZV31GXV9 = "" ;
   this.OV31GXV9 = "" ;
   this.GXV10 = "" ;
   this.ZV32GXV10 = "" ;
   this.OV32GXV10 = "" ;
   this.GXV1 = 0 ;
   this.GXV2 = "" ;
   this.AV13vDXTsource = "" ;
   this.GXV3 = "" ;
   this.GXV4 = "" ;
   this.AV15vDXType = "" ;
   this.GXV5 = "" ;
   this.AV18vMetastasesDX = "" ;
   this.AV19vDXSource = "" ;
   this.GXV6 = 0 ;
   this.GXV7 = 0 ;
   this.GXV8 = "" ;
   this.GXV9 = "" ;
   this.GXV10 = "" ;
   this.AV6BR_EncounterID = 0 ;
   this.AV5BR_Diagnosis = {BR_DiagnosisID:0,BR_EncounterID:0,BR_Information_PatientNo:"",BR_Diagnosis_No:0,BR_Diagnosis_DXID:"",BR_Diagnosis_DXCode:"",BR_Diagnosis_DXType:"",BR_Diagnosis_DXType_Code:"",BR_Diagnosis_DXTsource:"",BR_Diagnosis_DXTsource_Code:"",BR_Diagnosis_DXDescription:"",BR_Diagnosis_InitialDX:"",BR_Diagnosis_InitialDX_Code:"",BR_Diagnosis_MetastasesDX:"",BR_Diagnosis_MetastasesDX_Code:"",BR_Diagnosis_DXSource:"",BR_Diagnosis_TumorStageClinical:"",Mode:"",Initialized:0,BR_DiagnosisID_Z:0,BR_EncounterID_Z:0,BR_Information_PatientNo_Z:"",BR_Diagnosis_No_Z:0,BR_Diagnosis_DXID_Z:"",BR_Diagnosis_DXCode_Z:"",BR_Diagnosis_DXType_Z:"",BR_Diagnosis_DXType_Code_Z:"",BR_Diagnosis_DXTsource_Z:"",BR_Diagnosis_DXTsource_Code_Z:"",BR_Diagnosis_DXDescription_Z:"",BR_Diagnosis_InitialDX_Z:"",BR_Diagnosis_InitialDX_Code_Z:"",BR_Diagnosis_MetastasesDX_Z:"",BR_Diagnosis_MetastasesDX_Code_Z:"",BR_Diagnosis_DXSource_Z:"",BR_Diagnosis_TumorStageClinical_Z:""} ;
   this.Events = {"e138n2_client": ["ENTER", true] ,"e168n1_client": ["CANCEL", true] ,"e158n1_client": ["VVMETASTASESDX.CONTROLVALUECHANGED", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV6BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["START"] = [[],[{ctrl:'BR_DIAGNOSIS_BR_DIAGNOSISID',prop:'Visible'},{ctrl:'BR_DIAGNOSIS_BR_ENCOUNTERID',prop:'Visible'},{ctrl:'BR_DIAGNOSIS_BR_INFORMATION_PATIENTNO',prop:'Visible'},{ctrl:'BR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE',prop:'Visible'},{ctrl:'BR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE',prop:'Visible'}]];
   this.EvtParms["ENTER"] = [[{av:'AV5BR_Diagnosis',fld:'vBR_DIAGNOSIS',pic:''},{ctrl:'vVDXTSOURCE'},{av:'AV13vDXTsource',fld:'vVDXTSOURCE',pic:''},{ctrl:'vVMETASTASESDX'},{av:'AV18vMetastasesDX',fld:'vVMETASTASESDX',pic:''},{ctrl:'vVDXTYPE'},{av:'AV15vDXType',fld:'vVDXTYPE',pic:''},{av:'AV19vDXSource',fld:'vVDXSOURCE',pic:''},{av:'AV6BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV5BR_Diagnosis',fld:'vBR_DIAGNOSIS',pic:''}]];
   this.EvtParms["VVMETASTASESDX.CONTROLVALUECHANGED"] = [[{ctrl:'vVMETASTASESDX'},{av:'AV18vMetastasesDX',fld:'vVMETASTASESDX',pic:''}],[{av:'gx.fn.getCtrlProperty("vVDXSOURCE","Visible")',ctrl:'vVDXSOURCE',prop:'Visible'}]];
   this.EvtParms["LOAD"] = [[{av:'AV5BR_Diagnosis',fld:'vBR_DIAGNOSIS',pic:''},{ctrl:'vVDXTSOURCE'},{av:'AV13vDXTsource',fld:'vVDXTSOURCE',pic:''},{ctrl:'vVDXTYPE'},{av:'AV15vDXType',fld:'vVDXTYPE',pic:''},{ctrl:'vVMETASTASESDX'},{av:'AV18vMetastasesDX',fld:'vVMETASTASESDX',pic:''}],[{av:'gx.fn.getCtrlProperty("vVDXSOURCE","Visible")',ctrl:'vVDXSOURCE',prop:'Visible'},{ctrl:'vVDXTSOURCE'},{av:'AV13vDXTsource',fld:'vVDXTSOURCE',pic:''},{ctrl:'vVDXTYPE'},{av:'AV15vDXType',fld:'vVDXTYPE',pic:''},{ctrl:'vVMETASTASESDX'},{av:'AV18vMetastasesDX',fld:'vVMETASTASESDX',pic:''}]];
   this.EnterCtrl = ["BTNENTER"];
   this.setVCMap("AV14tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("AV5BR_Diagnosis", "vBR_DIAGNOSIS", 0, "BR_Diagnosis", 0, 0);
   this.setVCMap("AV6BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.addBCProperty("Br_diagnosis", ["BR_Diagnosis_No"], this.GXValidFnc[25], "AV5BR_Diagnosis");
   this.addBCProperty("Br_diagnosis", ["BR_Diagnosis_DXDescription"], this.GXValidFnc[29], "AV5BR_Diagnosis");
   this.addBCProperty("Br_diagnosis", ["BR_Diagnosis_DXID"], this.GXValidFnc[38], "AV5BR_Diagnosis");
   this.addBCProperty("Br_diagnosis", ["BR_Diagnosis_DXCode"], this.GXValidFnc[43], "AV5BR_Diagnosis");
   this.addBCProperty("Br_diagnosis", ["BR_Diagnosis_InitialDX"], this.GXValidFnc[52], "AV5BR_Diagnosis");
   this.addBCProperty("Br_diagnosis", ["BR_DiagnosisID"], this.GXValidFnc[72], "AV5BR_Diagnosis");
   this.addBCProperty("Br_diagnosis", ["BR_EncounterID"], this.GXValidFnc[73], "AV5BR_Diagnosis");
   this.addBCProperty("Br_diagnosis", ["BR_Information_PatientNo"], this.GXValidFnc[74], "AV5BR_Diagnosis");
   this.addBCProperty("Br_diagnosis", ["BR_Diagnosis_DXTsource"], this.GXValidFnc[75], "AV5BR_Diagnosis");
   this.addBCProperty("Br_diagnosis", ["BR_Diagnosis_DXType"], this.GXValidFnc[76], "AV5BR_Diagnosis");
   this.Initialize( );
});
gx.createParentObj(br_diagnosisinsert);
