/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:36:11.78
*/
gx.evt.autoSkip = false;
gx.define('br_demographics', false, function () {
   this.ServerClass =  "br_demographics" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV12BR_Demographics_ID=gx.fn.getIntegerValue("vBR_DEMOGRAPHICS_ID",',') ;
      this.AV10Insert_BR_EncounterID=gx.fn.getIntegerValue("vINSERT_BR_ENCOUNTERID",',') ;
      this.A455BR_Demographics_Sex_Code=gx.fn.getControlValue("BR_DEMOGRAPHICS_SEX_CODE") ;
      this.A456BR_Demographics_MarritalStatus_Code=gx.fn.getControlValue("BR_DEMOGRAPHICS_MARRITALSTATUS_CODE") ;
      this.A457BR_Demographics_Ethnic_Code=gx.fn.getControlValue("BR_DEMOGRAPHICS_ETHNIC_CODE") ;
      this.A458BR_Demographics_Education_Code=gx.fn.getControlValue("BR_DEMOGRAPHICS_EDUCATION_CODE") ;
      this.A459BR_Demographics_Insurance_Code=gx.fn.getControlValue("BR_DEMOGRAPHICS_INSURANCE_CODE") ;
      this.AV15tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.A85BR_Information_ID=gx.fn.getIntegerValue("BR_INFORMATION_ID",',') ;
      this.AV16Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV8TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_demographics_id=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DEMOGRAPHICS_ID");
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
   this.Valid_Br_demographics_birthdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DEMOGRAPHICS_BIRTHDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A53BR_Demographics_BirthDate)==0) || new gx.date.gxdate( this.A53BR_Demographics_BirthDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
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
   this.Valid_Br_demographics_sex=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DEMOGRAPHICS_SEX");
         this.AnyError  = 0;
         if ( ((''==this.A54BR_Demographics_Sex)) )
         {
            try {
               gxballoon.setError("鎬у埆鏄繀椤婚€夋嫨鐨?);
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
   this.Valid_Br_demographics_marritalstatus=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DEMOGRAPHICS_MARRITALSTATUS");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_demographics_ethnic=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DEMOGRAPHICS_ETHNIC");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_demographics_education=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DEMOGRAPHICS_EDUCATION");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_demographics_insurance=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DEMOGRAPHICS_INSURANCE");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e120b2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130b12_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140b12_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84];
   this.GXLastCtrlId =84;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "浜哄彛淇℃伅瀛?, "str");
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
   GXValidFnc[25]={ id:25 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_demographics_id,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_ID",gxz:"Z61BR_Demographics_ID",gxold:"O61BR_Demographics_ID",gxvar:"A61BR_Demographics_ID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A61BR_Demographics_ID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z61BR_Demographics_ID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_DEMOGRAPHICS_ID",gx.O.A61BR_Demographics_ID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A61BR_Demographics_ID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_DEMOGRAPHICS_ID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 25 , function() {
   });
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[34],ip:[34,29],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV10Insert_BR_EncounterID))}};
   this.declareDomainHdlr( 29 , function() {
   });
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id:34 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A36BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z36BR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_PATIENTNO",gx.O.A36BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A36BR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id:38 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_demographics_birthdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_BIRTHDATE",gxz:"Z53BR_Demographics_BirthDate",gxold:"O53BR_Demographics_BirthDate",gxvar:"A53BR_Demographics_BirthDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[38],ip:[38],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A53BR_Demographics_BirthDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z53BR_Demographics_BirthDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_DEMOGRAPHICS_BIRTHDATE",gx.O.A53BR_Demographics_BirthDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A53BR_Demographics_BirthDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_BIRTHDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 38 , function() {
   });
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id:43 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_demographics_sex,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_SEX",gxz:"Z54BR_Demographics_Sex",gxold:"O54BR_Demographics_Sex",gxvar:"A54BR_Demographics_Sex",ucs:[],op:[43],ip:[43],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A54BR_Demographics_Sex=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z54BR_Demographics_Sex=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DEMOGRAPHICS_SEX",gx.O.A54BR_Demographics_Sex)},c2v:function(){if(this.val()!==undefined)gx.O.A54BR_Demographics_Sex=this.val()},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_SEX")},nac:gx.falseFn};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_demographics_marritalstatus,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_MARRITALSTATUS",gxz:"Z63BR_Demographics_MarritalStatus",gxold:"O63BR_Demographics_MarritalStatus",gxvar:"A63BR_Demographics_MarritalStatus",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A63BR_Demographics_MarritalStatus=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z63BR_Demographics_MarritalStatus=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DEMOGRAPHICS_MARRITALSTATUS",gx.O.A63BR_Demographics_MarritalStatus)},c2v:function(){if(this.val()!==undefined)gx.O.A63BR_Demographics_MarritalStatus=this.val()},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_MARRITALSTATUS")},nac:gx.falseFn};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_demographics_ethnic,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_ETHNIC",gxz:"Z55BR_Demographics_Ethnic",gxold:"O55BR_Demographics_Ethnic",gxvar:"A55BR_Demographics_Ethnic",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A55BR_Demographics_Ethnic=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z55BR_Demographics_Ethnic=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DEMOGRAPHICS_ETHNIC",gx.O.A55BR_Demographics_Ethnic)},c2v:function(){if(this.val()!==undefined)gx.O.A55BR_Demographics_Ethnic=this.val()},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_ETHNIC")},nac:gx.falseFn};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_demographics_education,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_EDUCATION",gxz:"Z56BR_Demographics_Education",gxold:"O56BR_Demographics_Education",gxvar:"A56BR_Demographics_Education",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A56BR_Demographics_Education=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z56BR_Demographics_Education=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DEMOGRAPHICS_EDUCATION",gx.O.A56BR_Demographics_Education)},c2v:function(){if(this.val()!==undefined)gx.O.A56BR_Demographics_Education=this.val()},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_EDUCATION")},nac:gx.falseFn};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_OCCUPATION",gxz:"Z57BR_Demographics_Occupation",gxold:"O57BR_Demographics_Occupation",gxvar:"A57BR_Demographics_Occupation",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A57BR_Demographics_Occupation=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z57BR_Demographics_Occupation=Value},v2c:function(){gx.fn.setControlValue("BR_DEMOGRAPHICS_OCCUPATION",gx.O.A57BR_Demographics_Occupation,0)},c2v:function(){if(this.val()!==undefined)gx.O.A57BR_Demographics_Occupation=this.val()},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_OCCUPATION")},nac:gx.falseFn};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"",grid:0};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_demographics_insurance,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_INSURANCE",gxz:"Z58BR_Demographics_Insurance",gxold:"O58BR_Demographics_Insurance",gxvar:"A58BR_Demographics_Insurance",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A58BR_Demographics_Insurance=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z58BR_Demographics_Insurance=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DEMOGRAPHICS_INSURANCE",gx.O.A58BR_Demographics_Insurance)},c2v:function(){if(this.val()!==undefined)gx.O.A58BR_Demographics_Insurance=this.val()},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_INSURANCE")},nac:gx.falseFn};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id:70 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_PROVINCE",gxz:"Z59BR_Demographics_Province",gxold:"O59BR_Demographics_Province",gxvar:"A59BR_Demographics_Province",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A59BR_Demographics_Province=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z59BR_Demographics_Province=Value},v2c:function(){gx.fn.setControlValue("BR_DEMOGRAPHICS_PROVINCE",gx.O.A59BR_Demographics_Province,0)},c2v:function(){if(this.val()!==undefined)gx.O.A59BR_Demographics_Province=this.val()},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_PROVINCE")},nac:gx.falseFn};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id:74 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_CITY",gxz:"Z60BR_Demographics_City",gxold:"O60BR_Demographics_City",gxvar:"A60BR_Demographics_City",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A60BR_Demographics_City=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z60BR_Demographics_City=Value},v2c:function(){gx.fn.setControlValue("BR_DEMOGRAPHICS_CITY",gx.O.A60BR_Demographics_City,0)},c2v:function(){if(this.val()!==undefined)gx.O.A60BR_Demographics_City=this.val()},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_CITY")},nac:gx.falseFn};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"",grid:0};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[80]={ id: 80, fld:"",grid:0};
   GXValidFnc[81]={ id: 81, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[82]={ id: 82, fld:"",grid:0};
   GXValidFnc[83]={ id: 83, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[84]={ id: 84, fld:"PROMPT_19",grid:12};
   this.A61BR_Demographics_ID = 0 ;
   this.Z61BR_Demographics_ID = 0 ;
   this.O61BR_Demographics_ID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.Z36BR_Information_PatientNo = "" ;
   this.O36BR_Information_PatientNo = "" ;
   this.A53BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.Z53BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.O53BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.A54BR_Demographics_Sex = "" ;
   this.Z54BR_Demographics_Sex = "" ;
   this.O54BR_Demographics_Sex = "" ;
   this.A63BR_Demographics_MarritalStatus = "" ;
   this.Z63BR_Demographics_MarritalStatus = "" ;
   this.O63BR_Demographics_MarritalStatus = "" ;
   this.A55BR_Demographics_Ethnic = "" ;
   this.Z55BR_Demographics_Ethnic = "" ;
   this.O55BR_Demographics_Ethnic = "" ;
   this.A56BR_Demographics_Education = "" ;
   this.Z56BR_Demographics_Education = "" ;
   this.O56BR_Demographics_Education = "" ;
   this.A57BR_Demographics_Occupation = "" ;
   this.Z57BR_Demographics_Occupation = "" ;
   this.O57BR_Demographics_Occupation = "" ;
   this.A58BR_Demographics_Insurance = "" ;
   this.Z58BR_Demographics_Insurance = "" ;
   this.O58BR_Demographics_Insurance = "" ;
   this.A59BR_Demographics_Province = "" ;
   this.Z59BR_Demographics_Province = "" ;
   this.O59BR_Demographics_Province = "" ;
   this.A60BR_Demographics_City = "" ;
   this.Z60BR_Demographics_City = "" ;
   this.O60BR_Demographics_City = "" ;
   this.A85BR_Information_ID = 0 ;
   this.AV15tCurrentCode = "" ;
   this.AV7WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV13IsAuthorized = false ;
   this.AV16Pgmname = "" ;
   this.AV8TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV17GXV1 = 0 ;
   this.AV10Insert_BR_EncounterID = 0 ;
   this.AV11TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV12BR_Demographics_ID = 0 ;
   this.AV9WebSession = {} ;
   this.A61BR_Demographics_ID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A455BR_Demographics_Sex_Code = "" ;
   this.A456BR_Demographics_MarritalStatus_Code = "" ;
   this.A457BR_Demographics_Ethnic_Code = "" ;
   this.A458BR_Demographics_Education_Code = "" ;
   this.A459BR_Demographics_Insurance_Code = "" ;
   this.A36BR_Information_PatientNo = "" ;
   this.A53BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.A54BR_Demographics_Sex = "" ;
   this.A63BR_Demographics_MarritalStatus = "" ;
   this.A55BR_Demographics_Ethnic = "" ;
   this.A56BR_Demographics_Education = "" ;
   this.A57BR_Demographics_Occupation = "" ;
   this.A58BR_Demographics_Insurance = "" ;
   this.A59BR_Demographics_Province = "" ;
   this.A60BR_Demographics_City = "" ;
   this.Gx_mode = "" ;
   this.Events = {"e120b2_client": ["AFTER TRN", true] ,"e130b12_client": ["ENTER", true] ,"e140b12_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_Demographics_ID',fld:'vBR_DEMOGRAPHICS_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_Demographics_ID',fld:'vBR_DEMOGRAPHICS_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A61BR_Demographics_ID',fld:'BR_DEMOGRAPHICS_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV15tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV16Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV15tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV7WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV13IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV17GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV11TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.setPrompt("PROMPT_19", [29]);
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV12BR_Demographics_ID", "vBR_DEMOGRAPHICS_ID", 0, "int", 18, 0);
   this.setVCMap("AV10Insert_BR_EncounterID", "vINSERT_BR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("A455BR_Demographics_Sex_Code", "BR_DEMOGRAPHICS_SEX_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A456BR_Demographics_MarritalStatus_Code", "BR_DEMOGRAPHICS_MARRITALSTATUS_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A457BR_Demographics_Ethnic_Code", "BR_DEMOGRAPHICS_ETHNIC_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A458BR_Demographics_Education_Code", "BR_DEMOGRAPHICS_EDUCATION_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A459BR_Demographics_Insurance_Code", "BR_DEMOGRAPHICS_INSURANCE_CODE", 0, "svchar", 40, 0);
   this.setVCMap("AV15tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("A85BR_Information_ID", "BR_INFORMATION_ID", 0, "int", 18, 0);
   this.setVCMap("AV16Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV8TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_demographics);