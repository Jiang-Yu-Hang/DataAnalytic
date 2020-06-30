/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:48:0.56
*/
gx.evt.autoSkip = false;
gx.define('br_pathologyupdate', false, function () {
   this.ServerClass =  "br_pathologyupdate" ;
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
      this.AV10BR_Pathology=gx.fn.getControlValue("vBR_PATHOLOGY") ;
      this.AV15BR_PathologyID=gx.fn.getIntegerValue("vBR_PATHOLOGYID",',') ;
   };
   this.Validv_Vpathologym=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVPATHOLOGYM");
         this.AnyError  = 0;
         if ( ! ( ( this.AV11vPathologyM == "鍚? ) || ( this.AV11vPathologyM == "鏄? ) || ( this.AV11vPathologyM == "涓嶈" ) || ((''==this.AV11vPathologyM)) ) )
         {
            try {
               gxballoon.setError("鍩焩 Pathology M瓒呯晫");
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
   this.e159a1_client=function()
   {
      this.clearMessages();
      if ( this.AV11vPathologyM == "鏄? )
      {
         gx.fn.setCtrlProperty("vVMETALOC","Visible", true );
      }
      else
      {
         gx.fn.setCtrlProperty("vVMETALOC","Visible", false );
      }
      this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vVMETALOC","Visible")',ctrl:'vVMETALOC',prop:'Visible'}]);
      return gx.$.Deferred().resolve();
   };
   this.e139a2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e169a1_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128];
   this.GXLastCtrlId =128;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鐥呯悊瀛︿俊鎭?, "str");
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
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGYID_PADATE",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGYID_PADATE", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_BR_PATHOLOGYID_PADATE",gxz:"ZV21GXV1",gxold:"OV21GXV1",gxvar:"GXV1",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV1=gx.fn.toDatetimeValue(Value,"Y4MD")},v2z:function(Value){if(Value!==undefined)gx.O.ZV21GXV1=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_BR_PATHOLOGYID_PADATE",gx.O.GXV1,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV1=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_BR_PATHOLOGYID_PADATE")},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGYID_PAAGE",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGYID_PAAGE", format:0,grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_BR_PATHOLOGYID_PAAGE",gxz:"ZV22GXV2",gxold:"OV22GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV2=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22GXV2=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_BR_PATHOLOGYID_PAAGE",gx.O.GXV2,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV2=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_BR_PATHOLOGYID_PAAGE",',')},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP", format:0,grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP",gxz:"ZV23GXV3",gxold:"OV23GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.GXV3=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23GXV3=Value},v2c:function(){gx.fn.setComboBoxValue("BR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP",gx.O.GXV3)},c2v:function(){if(this.val()!==undefined)gx.O.GXV3=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP")},nac:gx.falseFn};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGY_DIA_NAME",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGY_DIA_NAME", format:0,grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:3000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_BR_PATHOLOGY_DIA_NAME",gxz:"ZV24GXV4",gxold:"OV24GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV4=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24GXV4=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_BR_PATHOLOGY_DIA_NAME",gx.O.GXV4,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV4=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_BR_PATHOLOGY_DIA_NAME")},nac:gx.falseFn};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGYID_PARESULT",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGYID_PARESULT", format:0,grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"svchar",len:9999,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_BR_PATHOLOGYID_PARESULT",gxz:"ZV25GXV5",gxold:"OV25GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV5=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25GXV5=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_BR_PATHOLOGYID_PARESULT",gx.O.GXV5,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV5=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_BR_PATHOLOGYID_PARESULT")},nac:gx.falseFn};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGYID_PREPADIA",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGYID_PREPADIA", format:0,grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_BR_PATHOLOGYID_PREPADIA",gxz:"ZV26GXV6",gxold:"OV26GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV6=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26GXV6=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_BR_PATHOLOGYID_PREPADIA",gx.O.GXV6,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV6=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_BR_PATHOLOGYID_PREPADIA")},nac:gx.falseFn};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id: 74, fld:"UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGY_T",grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGY_T", format:0,grid:0};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id:80 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_BR_PATHOLOGY_T",gxz:"ZV27GXV7",gxold:"OV27GXV7",gxvar:"GXV7",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV7=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV27GXV7=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PATHOLOGY_BR_PATHOLOGY_T",gx.O.GXV7,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.GXV7=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PATHOLOGY_BR_PATHOLOGY_T",',','.')},nac:gx.falseFn};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"",grid:0};
   GXValidFnc[83]={ id: 83, fld:"UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGY_N",grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id: 85, fld:"",grid:0};
   GXValidFnc[86]={ id: 86, fld:"TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGY_N", format:0,grid:0};
   GXValidFnc[87]={ id: 87, fld:"",grid:0};
   GXValidFnc[88]={ id: 88, fld:"",grid:0};
   GXValidFnc[89]={ id:89 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_BR_PATHOLOGY_N",gxz:"ZV28GXV8",gxold:"OV28GXV8",gxvar:"GXV8",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.GXV8=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV28GXV8=Value},v2c:function(){gx.fn.setComboBoxValue("BR_PATHOLOGY_BR_PATHOLOGY_N",gx.O.GXV8)},c2v:function(){if(this.val()!==undefined)gx.O.GXV8=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_BR_PATHOLOGY_N")},nac:gx.falseFn};
   GXValidFnc[90]={ id: 90, fld:"",grid:0};
   GXValidFnc[91]={ id: 91, fld:"",grid:0};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id:93 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_BR_PATHOLOGY_LYMPHNUM",gxz:"ZV29GXV9",gxold:"OV29GXV9",gxvar:"GXV9",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV9=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV29GXV9=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PATHOLOGY_BR_PATHOLOGY_LYMPHNUM",gx.O.GXV9,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.GXV9=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PATHOLOGY_BR_PATHOLOGY_LYMPHNUM",',','.')},nac:gx.falseFn};
   GXValidFnc[94]={ id: 94, fld:"",grid:0};
   GXValidFnc[95]={ id: 95, fld:"",grid:0};
   GXValidFnc[96]={ id: 96, fld:"UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGY_LYMPHRATE",grid:0};
   GXValidFnc[97]={ id: 97, fld:"",grid:0};
   GXValidFnc[98]={ id: 98, fld:"",grid:0};
   GXValidFnc[99]={ id: 99, fld:"TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGY_LYMPHRATE", format:0,grid:0};
   GXValidFnc[100]={ id: 100, fld:"",grid:0};
   GXValidFnc[101]={ id: 101, fld:"",grid:0};
   GXValidFnc[102]={ id:102 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_BR_PATHOLOGY_LYMPHRATE",gxz:"ZV30GXV10",gxold:"OV30GXV10",gxvar:"GXV10",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV10=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30GXV10=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_BR_PATHOLOGY_LYMPHRATE",gx.O.GXV10,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV10=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_BR_PATHOLOGY_LYMPHRATE")},nac:gx.falseFn};
   GXValidFnc[103]={ id: 103, fld:"",grid:0};
   GXValidFnc[104]={ id: 104, fld:"",grid:0};
   GXValidFnc[105]={ id: 105, fld:"UNNAMEDTABLEVPATHOLOGYM",grid:0};
   GXValidFnc[106]={ id: 106, fld:"",grid:0};
   GXValidFnc[107]={ id: 107, fld:"",grid:0};
   GXValidFnc[108]={ id: 108, fld:"TEXTBLOCKVPATHOLOGYM", format:0,grid:0};
   GXValidFnc[109]={ id: 109, fld:"",grid:0};
   GXValidFnc[110]={ id: 110, fld:"",grid:0};
   GXValidFnc[111]={ id:111 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vpathologym,isvalid:null,evt_cvc:'e159a1_client',evt_cvcing:null,rgrid:[],fld:"vVPATHOLOGYM",gxz:"ZV11vPathologyM",gxold:"OV11vPathologyM",gxvar:"AV11vPathologyM",ucs:[],op:[111],ip:[111],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV11vPathologyM=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV11vPathologyM=Value},v2c:function(){gx.fn.setComboBoxValue("vVPATHOLOGYM",gx.O.AV11vPathologyM)},c2v:function(){if(this.val()!==undefined)gx.O.AV11vPathologyM=this.val()},val:function(){return gx.fn.getControlValue("vVPATHOLOGYM")},nac:gx.falseFn};
   GXValidFnc[112]={ id: 112, fld:"",grid:0};
   GXValidFnc[113]={ id: 113, fld:"",grid:0};
   GXValidFnc[114]={ id: 114, fld:"",grid:0};
   GXValidFnc[115]={ id:115 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVMETALOC",gxz:"ZV12vMetaLoc",gxold:"OV12vMetaLoc",gxvar:"AV12vMetaLoc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV12vMetaLoc=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV12vMetaLoc=Value},v2c:function(){gx.fn.setControlValue("vVMETALOC",gx.O.AV12vMetaLoc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV12vMetaLoc=this.val()},val:function(){return gx.fn.getControlValue("vVMETALOC")},nac:gx.falseFn};
   GXValidFnc[116]={ id: 116, fld:"",grid:0};
   GXValidFnc[117]={ id: 117, fld:"",grid:0};
   GXValidFnc[118]={ id: 118, fld:"",grid:0};
   GXValidFnc[119]={ id: 119, fld:"",grid:0};
   GXValidFnc[120]={ id: 120, fld:"BTNENTER",grid:0};
   GXValidFnc[121]={ id: 121, fld:"",grid:0};
   GXValidFnc[122]={ id: 122, fld:"BTNCANCEL",grid:0};
   GXValidFnc[123]={ id: 123, fld:"",grid:0};
   GXValidFnc[124]={ id: 124, fld:"",grid:0};
   GXValidFnc[125]={ id: 125, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[126]={ id:126 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_BR_PATHOLOGYID",gxz:"ZV31GXV11",gxold:"OV31GXV11",gxvar:"GXV11",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV11=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV31GXV11=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_BR_PATHOLOGYID",gx.O.GXV11,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV11=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_BR_PATHOLOGYID",',')},nac:gx.falseFn};
   GXValidFnc[127]={ id:127 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_BR_ENCOUNTERID",gxz:"ZV32GXV12",gxold:"OV32GXV12",gxvar:"GXV12",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV12=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV32GXV12=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_BR_ENCOUNTERID",gx.O.GXV12,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV12=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_BR_ENCOUNTERID",',')},nac:gx.falseFn};
   GXValidFnc[128]={ id:128 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_BR_INFORMATION_PATIENTNO",gxz:"ZV33GXV13",gxold:"OV33GXV13",gxvar:"GXV13",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV13=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33GXV13=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_BR_INFORMATION_PATIENTNO",gx.O.GXV13,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV13=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   this.GXV1 = gx.date.nullDate() ;
   this.ZV21GXV1 = gx.date.nullDate() ;
   this.OV21GXV1 = gx.date.nullDate() ;
   this.GXV2 = 0 ;
   this.ZV22GXV2 = 0 ;
   this.OV22GXV2 = 0 ;
   this.GXV3 = "" ;
   this.ZV23GXV3 = "" ;
   this.OV23GXV3 = "" ;
   this.GXV4 = "" ;
   this.ZV24GXV4 = "" ;
   this.OV24GXV4 = "" ;
   this.GXV5 = "" ;
   this.ZV25GXV5 = "" ;
   this.OV25GXV5 = "" ;
   this.GXV6 = "" ;
   this.ZV26GXV6 = "" ;
   this.OV26GXV6 = "" ;
   this.GXV7 = 0 ;
   this.ZV27GXV7 = 0 ;
   this.OV27GXV7 = 0 ;
   this.GXV8 = "" ;
   this.ZV28GXV8 = "" ;
   this.OV28GXV8 = "" ;
   this.GXV9 = 0 ;
   this.ZV29GXV9 = 0 ;
   this.OV29GXV9 = 0 ;
   this.GXV10 = "" ;
   this.ZV30GXV10 = "" ;
   this.OV30GXV10 = "" ;
   this.AV11vPathologyM = "" ;
   this.ZV11vPathologyM = "" ;
   this.OV11vPathologyM = "" ;
   this.AV12vMetaLoc = "" ;
   this.ZV12vMetaLoc = "" ;
   this.OV12vMetaLoc = "" ;
   this.GXV11 = 0 ;
   this.ZV31GXV11 = 0 ;
   this.OV31GXV11 = 0 ;
   this.GXV12 = 0 ;
   this.ZV32GXV12 = 0 ;
   this.OV32GXV12 = 0 ;
   this.GXV13 = "" ;
   this.ZV33GXV13 = "" ;
   this.OV33GXV13 = "" ;
   this.GXV1 = gx.date.nullDate() ;
   this.GXV2 = 0 ;
   this.GXV3 = "" ;
   this.GXV4 = "" ;
   this.GXV5 = "" ;
   this.GXV6 = "" ;
   this.GXV7 = 0 ;
   this.GXV8 = "" ;
   this.GXV9 = 0 ;
   this.GXV10 = "" ;
   this.AV11vPathologyM = "" ;
   this.AV12vMetaLoc = "" ;
   this.GXV11 = 0 ;
   this.GXV12 = 0 ;
   this.GXV13 = "" ;
   this.AV15BR_PathologyID = 0 ;
   this.AV10BR_Pathology = {BR_PathologyID:0,BR_EncounterID:0,BR_Information_PatientNo:"",BR_PathologyID_TestID:0,BR_PathologyID_PADate:gx.date.nullDate(),BR_PathologyID_PAHosp:"",BR_PathologyID_PAHosp_Code:"",BR_PathologyID_PAAge:0,BR_PathologyID_PrePaDia:"",BR_PathologyID_PAResult:"",BR_Pathology_Dia_Name:"",BR_Pathology_T:0,BR_Pathology_N:"",BR_Pathology_N_Code:"",BR_Pathology_LymphNum:0,BR_Pathology_LymphRate:"",BR_Pathology_M:"",BR_Pathology_M_Code:"",BR_Pathology_MetaLoc:"",Mode:"",Initialized:0,BR_PathologyID_Z:0,BR_EncounterID_Z:0,BR_Information_PatientNo_Z:"",BR_PathologyID_TestID_Z:0,BR_PathologyID_PADate_Z:gx.date.nullDate(),BR_PathologyID_PAHosp_Z:"",BR_PathologyID_PAHosp_Code_Z:"",BR_PathologyID_PAAge_Z:0,BR_PathologyID_PrePaDia_Z:"",BR_PathologyID_PAResult_Z:"",BR_Pathology_Dia_Name_Z:"",BR_Pathology_T_Z:0,BR_Pathology_N_Z:"",BR_Pathology_N_Code_Z:"",BR_Pathology_LymphNum_Z:0,BR_Pathology_LymphRate_Z:"",BR_Pathology_M_Z:"",BR_Pathology_M_Code_Z:"",BR_Pathology_MetaLoc_Z:""} ;
   this.Events = {"e139a2_client": ["ENTER", true] ,"e169a1_client": ["CANCEL", true] ,"e159a1_client": ["VVPATHOLOGYM.CONTROLVALUECHANGED", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV15BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["START"] = [[{av:'AV15BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{ctrl:'BR_PATHOLOGY_BR_PATHOLOGYID',prop:'Visible'},{ctrl:'BR_PATHOLOGY_BR_ENCOUNTERID',prop:'Visible'},{ctrl:'BR_PATHOLOGY_BR_INFORMATION_PATIENTNO',prop:'Visible'},{av:'AV10BR_Pathology',fld:'vBR_PATHOLOGY',pic:''},{av:'AV12vMetaLoc',fld:'vVMETALOC',pic:''}]];
   this.EvtParms["ENTER"] = [[{av:'AV10BR_Pathology',fld:'vBR_PATHOLOGY',pic:''},{ctrl:'vVPATHOLOGYM'},{av:'AV11vPathologyM',fld:'vVPATHOLOGYM',pic:''},{av:'AV12vMetaLoc',fld:'vVMETALOC',pic:''}],[{av:'AV10BR_Pathology',fld:'vBR_PATHOLOGY',pic:''}]];
   this.EvtParms["VVPATHOLOGYM.CONTROLVALUECHANGED"] = [[{ctrl:'vVPATHOLOGYM'},{av:'AV11vPathologyM',fld:'vVPATHOLOGYM',pic:''}],[{av:'gx.fn.getCtrlProperty("vVMETALOC","Visible")',ctrl:'vVMETALOC',prop:'Visible'}]];
   this.EvtParms["LOAD"] = [[{av:'AV15BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{ctrl:'vVPATHOLOGYM'},{av:'AV11vPathologyM',fld:'vVPATHOLOGYM',pic:''}],[{av:'AV10BR_Pathology',fld:'vBR_PATHOLOGY',pic:''},{av:'gx.fn.getCtrlProperty("vVMETALOC","Visible")',ctrl:'vVMETALOC',prop:'Visible'},{ctrl:'vVPATHOLOGYM'},{av:'AV11vPathologyM',fld:'vVPATHOLOGYM',pic:''}]];
   this.EnterCtrl = ["BTNENTER"];
   this.setVCMap("AV14tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("AV10BR_Pathology", "vBR_PATHOLOGY", 0, "BR_Pathology", 0, 0);
   this.setVCMap("AV15BR_PathologyID", "vBR_PATHOLOGYID", 0, "int", 18, 0);
   this.addBCProperty("Br_pathology", ["BR_PathologyID_PADate"], this.GXValidFnc[29], "AV10BR_Pathology");
   this.addBCProperty("Br_pathology", ["BR_PathologyID_PAAge"], this.GXValidFnc[37], "AV10BR_Pathology");
   this.addBCProperty("Br_pathology", ["BR_PathologyID_PAHosp"], this.GXValidFnc[46], "AV10BR_Pathology");
   this.addBCProperty("Br_pathology", ["BR_Pathology_Dia_Name"], this.GXValidFnc[54], "AV10BR_Pathology");
   this.addBCProperty("Br_pathology", ["BR_PathologyID_PAResult"], this.GXValidFnc[63], "AV10BR_Pathology");
   this.addBCProperty("Br_pathology", ["BR_PathologyID_PrePaDia"], this.GXValidFnc[71], "AV10BR_Pathology");
   this.addBCProperty("Br_pathology", ["BR_Pathology_T"], this.GXValidFnc[80], "AV10BR_Pathology");
   this.addBCProperty("Br_pathology", ["BR_Pathology_N"], this.GXValidFnc[89], "AV10BR_Pathology");
   this.addBCProperty("Br_pathology", ["BR_Pathology_LymphNum"], this.GXValidFnc[93], "AV10BR_Pathology");
   this.addBCProperty("Br_pathology", ["BR_Pathology_LymphRate"], this.GXValidFnc[102], "AV10BR_Pathology");
   this.addBCProperty("Br_pathology", ["BR_PathologyID"], this.GXValidFnc[126], "AV10BR_Pathology");
   this.addBCProperty("Br_pathology", ["BR_EncounterID"], this.GXValidFnc[127], "AV10BR_Pathology");
   this.addBCProperty("Br_pathology", ["BR_Information_PatientNo"], this.GXValidFnc[128], "AV10BR_Pathology");
   this.Initialize( );
});
gx.createParentObj(br_pathologyupdate);
