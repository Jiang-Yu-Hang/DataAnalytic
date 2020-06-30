/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:47:43.92
*/
gx.evt.autoSkip = false;
gx.define('br_procedureupdate', false, function () {
   this.ServerClass =  "br_procedureupdate" ;
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
      this.AV10BR_Procedure=gx.fn.getControlValue("vBR_PROCEDURE") ;
      this.AV18BR_ProcedureID=gx.fn.getIntegerValue("vBR_PROCEDUREID",',') ;
   };
   this.Validv_Vpxsurgeryname=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVPXSURGERYNAME");
         this.AnyError  = 0;
         if ( ! ( ( this.AV11vPXSurgeryName == "鍚? ) || ( this.AV11vPXSurgeryName == "鏄? ) || ( this.AV11vPXSurgeryName == "涓嶈" ) ) )
         {
            try {
               gxballoon.setError("鍩焩 PXSurgery Name瓒呯晫");
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
   this.Validv_Vdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVDATE");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Vpxradiotherapy=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVPXRADIOTHERAPY");
         this.AnyError  = 0;
         if ( ! ( ( this.AV13vPXRadiotherapy == "鍚? ) || ( this.AV13vPXRadiotherapy == "鏄? ) || ( this.AV13vPXRadiotherapy == "涓嶈" ) ) )
         {
            try {
               gxballoon.setError("鍩焩 PXRadiotherapy瓒呯晫");
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
   this.Validv_Vradiodate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVRADIODATE");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e158t1_client=function()
   {
      this.clearMessages();
      if ( this.AV11vPXSurgeryName == "鏄? )
      {
         gx.fn.setCtrlProperty("vVDATE","Visible", true );
         gx.fn.setCtrlProperty("vVPXRADIOTHERAPY","Visible", false );
      }
      else
      {
         gx.fn.setCtrlProperty("vVDATE","Visible", false );
         gx.fn.setCtrlProperty("vVPXRADIOTHERAPY","Visible", true );
      }
      this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vVDATE","Visible")',ctrl:'vVDATE',prop:'Visible'},{ctrl:'vVPXRADIOTHERAPY'}]);
      return gx.$.Deferred().resolve();
   };
   this.e168t1_client=function()
   {
      this.clearMessages();
      if ( this.AV13vPXRadiotherapy == "鏄? )
      {
         gx.fn.setCtrlProperty("vVRADIODATE","Visible", true );
         gx.fn.setCtrlProperty("vVRADIOTIME","Visible", true );
         gx.fn.setCtrlProperty("vVPXSURGERYNAME","Visible", false );
      }
      else
      {
         gx.fn.setCtrlProperty("vVRADIODATE","Visible", false );
         gx.fn.setCtrlProperty("vVRADIOTIME","Visible", false );
         gx.fn.setCtrlProperty("vVPXSURGERYNAME","Visible", true );
      }
      this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vVRADIODATE","Visible")',ctrl:'vVRADIODATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vVRADIOTIME","Visible")',ctrl:'vVRADIOTIME',prop:'Visible'},{ctrl:'vVPXSURGERYNAME'}]);
      return gx.$.Deferred().resolve();
   };
   this.e138t2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e178t1_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57];
   this.GXLastCtrlId =57;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "璇婄枟澶勭悊", "str");
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
   GXValidFnc[25]={ id:25 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vpxsurgeryname,isvalid:null,evt_cvc:'e158t1_client',evt_cvcing:null,rgrid:[],fld:"vVPXSURGERYNAME",gxz:"ZV11vPXSurgeryName",gxold:"OV11vPXSurgeryName",gxvar:"AV11vPXSurgeryName",ucs:[],op:[25],ip:[25],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV11vPXSurgeryName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV11vPXSurgeryName=Value},v2c:function(){gx.fn.setComboBoxValue("vVPXSURGERYNAME",gx.O.AV11vPXSurgeryName)},c2v:function(){if(this.val()!==undefined)gx.O.AV11vPXSurgeryName=this.val()},val:function(){return gx.fn.getControlValue("vVPXSURGERYNAME")},nac:gx.falseFn};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVDATE",gxz:"ZV12vDate",gxold:"OV12vDate",gxvar:"AV12vDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV12vDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV12vDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vVDATE",gx.O.AV12vDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV12vDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vVDATE")},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id:34 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vpxradiotherapy,isvalid:null,evt_cvc:'e168t1_client',evt_cvcing:null,rgrid:[],fld:"vVPXRADIOTHERAPY",gxz:"ZV13vPXRadiotherapy",gxold:"OV13vPXRadiotherapy",gxvar:"AV13vPXRadiotherapy",ucs:[],op:[34],ip:[34],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV13vPXRadiotherapy=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV13vPXRadiotherapy=Value},v2c:function(){gx.fn.setComboBoxValue("vVPXRADIOTHERAPY",gx.O.AV13vPXRadiotherapy)},c2v:function(){if(this.val()!==undefined)gx.O.AV13vPXRadiotherapy=this.val()},val:function(){return gx.fn.getControlValue("vVPXRADIOTHERAPY")},nac:gx.falseFn};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id:38 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vradiodate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVRADIODATE",gxz:"ZV14vRadioDate",gxold:"OV14vRadioDate",gxvar:"AV14vRadioDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14vRadioDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14vRadioDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vVRADIODATE",gx.O.AV14vRadioDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14vRadioDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vVRADIODATE")},nac:gx.falseFn};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id:43 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVRADIOTIME",gxz:"ZV15vRadioTime",gxold:"OV15vRadioTime",gxvar:"AV15vRadioTime",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15vRadioTime=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV15vRadioTime=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vVRADIOTIME",gx.O.AV15vRadioTime,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV15vRadioTime=this.val()},val:function(){return gx.fn.getDecimalValue("vVRADIOTIME",',','.')},nac:gx.falseFn};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"BTNENTER",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"BTNCANCEL",grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_BR_PROCEDUREID",gxz:"ZV24GXV1",gxold:"OV24GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV1=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV24GXV1=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_BR_PROCEDUREID",gx.O.GXV1,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV1=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PROCEDURE_BR_PROCEDUREID",',')},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_BR_ENCOUNTERID",gxz:"ZV25GXV2",gxold:"OV25GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV2=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV25GXV2=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_BR_ENCOUNTERID",gx.O.GXV2,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV2=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PROCEDURE_BR_ENCOUNTERID",',')},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_BR_INFORMATION_PATIENTNO",gxz:"ZV26GXV3",gxold:"OV26GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV3=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26GXV3=Value},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_BR_INFORMATION_PATIENTNO",gx.O.GXV3,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV3=this.val()},val:function(){return gx.fn.getControlValue("BR_PROCEDURE_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_BR_PROCEDURE_PXID",gxz:"ZV27GXV4",gxold:"OV27GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV4=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV27GXV4=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_BR_PROCEDURE_PXID",gx.O.GXV4,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV4=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PROCEDURE_BR_PROCEDURE_PXID",',')},nac:gx.falseFn};
   this.AV11vPXSurgeryName = "" ;
   this.ZV11vPXSurgeryName = "" ;
   this.OV11vPXSurgeryName = "" ;
   this.AV12vDate = gx.date.nullDate() ;
   this.ZV12vDate = gx.date.nullDate() ;
   this.OV12vDate = gx.date.nullDate() ;
   this.AV13vPXRadiotherapy = "" ;
   this.ZV13vPXRadiotherapy = "" ;
   this.OV13vPXRadiotherapy = "" ;
   this.AV14vRadioDate = gx.date.nullDate() ;
   this.ZV14vRadioDate = gx.date.nullDate() ;
   this.OV14vRadioDate = gx.date.nullDate() ;
   this.AV15vRadioTime = 0 ;
   this.ZV15vRadioTime = 0 ;
   this.OV15vRadioTime = 0 ;
   this.GXV1 = 0 ;
   this.ZV24GXV1 = 0 ;
   this.OV24GXV1 = 0 ;
   this.GXV2 = 0 ;
   this.ZV25GXV2 = 0 ;
   this.OV25GXV2 = 0 ;
   this.GXV3 = "" ;
   this.ZV26GXV3 = "" ;
   this.OV26GXV3 = "" ;
   this.GXV4 = 0 ;
   this.ZV27GXV4 = 0 ;
   this.OV27GXV4 = 0 ;
   this.AV11vPXSurgeryName = "" ;
   this.AV12vDate = gx.date.nullDate() ;
   this.AV13vPXRadiotherapy = "" ;
   this.AV14vRadioDate = gx.date.nullDate() ;
   this.AV15vRadioTime = 0 ;
   this.GXV1 = 0 ;
   this.GXV2 = 0 ;
   this.GXV3 = "" ;
   this.GXV4 = 0 ;
   this.AV18BR_ProcedureID = 0 ;
   this.AV10BR_Procedure = {BR_ProcedureID:0,BR_EncounterID:0,BR_Information_PatientNo:"",BR_Procedure_PXID:0,BR_Procedure_PXSurgery:"",BR_Procedure_PXSurgery_Code:"",BR_Procedure_Date:gx.date.nullDate(),BR_Procedure_PXRadiotherapy:"",BR_Procedure_PXRadiotherapy_Code:"",BR_Procedure_RadioDate:gx.date.nullDate(),BR_Procedure_RadioTime:0,Mode:"",Initialized:0,BR_ProcedureID_Z:0,BR_EncounterID_Z:0,BR_Information_PatientNo_Z:"",BR_Procedure_PXID_Z:0,BR_Procedure_PXSurgery_Z:"",BR_Procedure_PXSurgery_Code_Z:"",BR_Procedure_Date_Z:gx.date.nullDate(),BR_Procedure_PXRadiotherapy_Z:"",BR_Procedure_PXRadiotherapy_Code_Z:"",BR_Procedure_RadioDate_Z:gx.date.nullDate(),BR_Procedure_RadioTime_Z:0} ;
   this.Events = {"e138t2_client": ["ENTER", true] ,"e178t1_client": ["CANCEL", true] ,"e158t1_client": ["VVPXSURGERYNAME.CONTROLVALUECHANGED", false] ,"e168t1_client": ["VVPXRADIOTHERAPY.CONTROLVALUECHANGED", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV18BR_ProcedureID',fld:'vBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["START"] = [[{av:'AV18BR_ProcedureID',fld:'vBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{ctrl:'BR_PROCEDURE_BR_PROCEDUREID',prop:'Visible'},{ctrl:'BR_PROCEDURE_BR_ENCOUNTERID',prop:'Visible'},{ctrl:'BR_PROCEDURE_BR_INFORMATION_PATIENTNO',prop:'Visible'},{ctrl:'BR_PROCEDURE_BR_PROCEDURE_PXID',prop:'Visible'},{av:'AV10BR_Procedure',fld:'vBR_PROCEDURE',pic:''},{av:'AV12vDate',fld:'vVDATE',pic:''},{av:'AV14vRadioDate',fld:'vVRADIODATE',pic:''},{av:'AV15vRadioTime',fld:'vVRADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'}]];
   this.EvtParms["ENTER"] = [[{ctrl:'vVPXSURGERYNAME'},{av:'AV11vPXSurgeryName',fld:'vVPXSURGERYNAME',pic:''},{ctrl:'vVPXRADIOTHERAPY'},{av:'AV13vPXRadiotherapy',fld:'vVPXRADIOTHERAPY',pic:''},{av:'AV12vDate',fld:'vVDATE',pic:''},{av:'AV10BR_Procedure',fld:'vBR_PROCEDURE',pic:''},{av:'AV14vRadioDate',fld:'vVRADIODATE',pic:''},{av:'AV15vRadioTime',fld:'vVRADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'}],[{av:'AV10BR_Procedure',fld:'vBR_PROCEDURE',pic:''}]];
   this.EvtParms["VVPXSURGERYNAME.CONTROLVALUECHANGED"] = [[{ctrl:'vVPXSURGERYNAME'},{av:'AV11vPXSurgeryName',fld:'vVPXSURGERYNAME',pic:''}],[{av:'gx.fn.getCtrlProperty("vVDATE","Visible")',ctrl:'vVDATE',prop:'Visible'},{ctrl:'vVPXRADIOTHERAPY'}]];
   this.EvtParms["VVPXRADIOTHERAPY.CONTROLVALUECHANGED"] = [[{ctrl:'vVPXRADIOTHERAPY'},{av:'AV13vPXRadiotherapy',fld:'vVPXRADIOTHERAPY',pic:''}],[{av:'gx.fn.getCtrlProperty("vVRADIODATE","Visible")',ctrl:'vVRADIODATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vVRADIOTIME","Visible")',ctrl:'vVRADIOTIME',prop:'Visible'},{ctrl:'vVPXSURGERYNAME'}]];
   this.EvtParms["LOAD"] = [[{av:'AV18BR_ProcedureID',fld:'vBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{ctrl:'vVPXSURGERYNAME'},{av:'AV11vPXSurgeryName',fld:'vVPXSURGERYNAME',pic:''},{ctrl:'vVPXRADIOTHERAPY'},{av:'AV13vPXRadiotherapy',fld:'vVPXRADIOTHERAPY',pic:''}],[{av:'AV10BR_Procedure',fld:'vBR_PROCEDURE',pic:''},{av:'gx.fn.getCtrlProperty("vVDATE","Visible")',ctrl:'vVDATE',prop:'Visible'},{ctrl:'vVPXRADIOTHERAPY'},{av:'gx.fn.getCtrlProperty("vVRADIODATE","Visible")',ctrl:'vVRADIODATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vVRADIOTIME","Visible")',ctrl:'vVRADIOTIME',prop:'Visible'},{ctrl:'vVPXSURGERYNAME'},{av:'AV11vPXSurgeryName',fld:'vVPXSURGERYNAME',pic:''},{av:'AV13vPXRadiotherapy',fld:'vVPXRADIOTHERAPY',pic:''}]];
   this.EnterCtrl = ["BTNENTER"];
   this.setVCMap("AV10BR_Procedure", "vBR_PROCEDURE", 0, "BR_Procedure", 0, 0);
   this.setVCMap("AV18BR_ProcedureID", "vBR_PROCEDUREID", 0, "int", 18, 0);
   this.addBCProperty("Br_procedure", ["BR_ProcedureID"], this.GXValidFnc[54], "AV10BR_Procedure");
   this.addBCProperty("Br_procedure", ["BR_EncounterID"], this.GXValidFnc[55], "AV10BR_Procedure");
   this.addBCProperty("Br_procedure", ["BR_Information_PatientNo"], this.GXValidFnc[56], "AV10BR_Procedure");
   this.addBCProperty("Br_procedure", ["BR_Procedure_PXID"], this.GXValidFnc[57], "AV10BR_Procedure");
   this.Initialize( );
});
gx.createParentObj(br_procedureupdate);
