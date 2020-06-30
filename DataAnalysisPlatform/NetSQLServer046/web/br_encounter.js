/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:56:13.76
*/
gx.evt.autoSkip = false;
gx.define('br_encounter', false, function () {
   this.ServerClass =  "br_encounter" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
      this.AV8Insert_BR_Information_ID=gx.fn.getIntegerValue("vINSERT_BR_INFORMATION_ID",',') ;
      this.AV29Insert_BAS_TenantTenantCode=gx.fn.getControlValue("vINSERT_BAS_TENANTTENANTCODE") ;
      this.A360BAS_TenantTenantCode=gx.fn.getControlValue("BAS_TENANTTENANTCODE") ;
      this.A512BR_Encounter_CrtDisplayName=gx.fn.getControlValue("BR_ENCOUNTER_CRTDISPLAYNAME") ;
      this.A470BR_Encounter_Department_Code=gx.fn.getControlValue("BR_ENCOUNTER_DEPARTMENT_CODE") ;
      this.A471BR_Encounter_ENCType_Code=gx.fn.getControlValue("BR_ENCOUNTER_ENCTYPE_CODE") ;
      this.A472BR_Encounter_AdmitSource_Code=gx.fn.getControlValue("BR_ENCOUNTER_ADMITSOURCE_CODE") ;
      this.A473BR_Encounter_DischargeStatus_Code=gx.fn.getControlValue("BR_ENCOUNTER_DISCHARGESTATUS_CODE") ;
      this.AV30tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.A570BR_Encounter_Departmentadm=gx.fn.getControlValue("BR_ENCOUNTER_DEPARTMENTADM") ;
      this.A571BR_Encounter_Departmentadm_Code=gx.fn.getControlValue("BR_ENCOUNTER_DEPARTMENTADM_CODE") ;
      this.A572BR_Encounter_Departmentdisch=gx.fn.getControlValue("BR_ENCOUNTER_DEPARTMENTDISCH") ;
      this.A573BR_Encounter_Departmentdisch_Code=gx.fn.getControlValue("BR_ENCOUNTER_DEPARTMENTDISCH_CODE") ;
      this.A574BR_Encounter_Insurance=gx.fn.getControlValue("BR_ENCOUNTER_INSURANCE") ;
      this.A575BR_Encounter_Insurance_Code=gx.fn.getControlValue("BR_ENCOUNTER_INSURANCE_CODE") ;
      this.A333BR_Encounter_IsDLT=gx.fn.getControlValue("BR_ENCOUNTER_ISDLT") ;
      this.A184BR_Encounter_SubmitUser=gx.fn.getControlValue("BR_ENCOUNTER_SUBMITUSER") ;
      this.A335BR_Encounter_Reason=gx.fn.getControlValue("BR_ENCOUNTER_REASON") ;
      this.A185BR_Encounter_SubmitDate=gx.fn.getDateTimeValue("BR_ENCOUNTER_SUBMITDATE") ;
      this.A188BR_Encounter_RecheckUser=gx.fn.getControlValue("BR_ENCOUNTER_RECHECKUSER") ;
      this.A336BR_Encounter_FReason=gx.fn.getControlValue("BR_ENCOUNTER_FREASON") ;
      this.A189BR_Encounter_RecheckDate=gx.fn.getDateTimeValue("BR_ENCOUNTER_RECHECKDATE") ;
      this.A190BR_Encounter_Approver=gx.fn.getControlValue("BR_ENCOUNTER_APPROVER") ;
      this.A191BR_Encounter_ApproveDate=gx.fn.getDateTimeValue("BR_ENCOUNTER_APPROVEDATE") ;
      this.A192BR_Encounter_IsRandApprove=gx.fn.getControlValue("BR_ENCOUNTER_ISRANDAPPROVE") ;
      this.A203BR_Encounter_IsRandApprover=gx.fn.getControlValue("BR_ENCOUNTER_ISRANDAPPROVER") ;
      this.A204BR_Encounter_IsRandNoApprover=gx.fn.getControlValue("BR_ENCOUNTER_ISRANDNOAPPROVER") ;
      this.A205BR_Encounter_IsRandApproveDate=gx.fn.getDateTimeValue("BR_ENCOUNTER_ISRANDAPPROVEDATE") ;
      this.A206BR_Encounter_IsRandNoApproveDate=gx.fn.getDateTimeValue("BR_ENCOUNTER_ISRANDNOAPPROVEDATE") ;
      this.A193BR_Encounter_IsRandRecheck=gx.fn.getControlValue("BR_ENCOUNTER_ISRANDRECHECK") ;
      this.A207BR_Encounter_IsRandRecheckr=gx.fn.getControlValue("BR_ENCOUNTER_ISRANDRECHECKR") ;
      this.A208BR_Encounter_IsRandNoRecheckr=gx.fn.getControlValue("BR_ENCOUNTER_ISRANDNORECHECKR") ;
      this.A209BR_Encounter_IsRandRecheckDate=gx.fn.getDateTimeValue("BR_ENCOUNTER_ISRANDRECHECKDATE") ;
      this.A210BR_Encounter_IsRandNoRecheckDate=gx.fn.getDateTimeValue("BR_ENCOUNTER_ISRANDNORECHECKDATE") ;
      this.A202BR_Encounter_IsUpdate=gx.fn.getControlValue("BR_ENCOUNTER_ISUPDATE") ;
      this.A537BR_Encounter_Datasource=gx.fn.getIntegerValue("BR_ENCOUNTER_DATASOURCE",',') ;
      this.A560EncounterIDEncrypt=gx.fn.getControlValue("ENCOUNTERIDENCRYPT") ;
      this.AV32Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV31Pgmdesc=gx.fn.getControlValue("vPGMDESC") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_encounterid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTERID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_information_id=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_information_id",["gx.num.urlDecimal(gx.O.A85BR_Information_ID,\',\',\'.\')", "gx.O.A36BR_Information_PatientNo"],["A36BR_Information_PatientNo"]);
      return true;
   }
   this.Valid_Br_encounter_department=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTER_DEPARTMENT");
         this.AnyError  = 0;
         try {
            gx.fn.setCtrlProperty("vVDEPARTMENT","Visible", (this.A84BR_Encounter_Department=="鍏跺畠") );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A84BR_Encounter_Department == "鍏跺畠" ) ) )
            {
               gx.fn.setCtrlProperty("VDEPARTMENT_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A84BR_Encounter_Department == "鍏跺畠" )
               {
                  gx.fn.setCtrlProperty("VDEPARTMENT_CELL","Class", "RequiredDataContentCell" );
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
   this.Validv_Vdepartment=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVDEPARTMENT");
         this.AnyError  = 0;
         if ( ( ( this.A84BR_Encounter_Department == "鍏跺畠" ) ) && ((''==this.AV24vDepartment)) )
         {
            try {
               gxballoon.setError("鍏朵粬灏辫瘖绉戝鏄繀濉殑");
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
   this.Valid_Br_encounter_enctype=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTER_ENCTYPE");
         this.AnyError  = 0;
         try {
            gx.fn.setCtrlProperty("vVENCTYPE","Visible", (this.A90BR_Encounter_ENCType=="鍏跺畠") );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A90BR_Encounter_ENCType == "鍏跺畠" ) ) )
            {
               gx.fn.setCtrlProperty("VENCTYPE_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A90BR_Encounter_ENCType == "鍏跺畠" )
               {
                  gx.fn.setCtrlProperty("VENCTYPE_CELL","Class", "RequiredDataContentCell" );
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
   this.Validv_Venctype=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVENCTYPE");
         this.AnyError  = 0;
         if ( ( ( this.A90BR_Encounter_ENCType == "鍏跺畠" ) ) && ((''==this.AV26vENCType)) )
         {
            try {
               gxballoon.setError("鍏跺畠灏辫瘖鏂瑰紡鏄繀濉殑");
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
   this.Valid_Br_encounter_admitdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTER_ADMITDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A91BR_Encounter_AdmitDate)==0) || new gx.date.gxdate( this.A91BR_Encounter_AdmitDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟?锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
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
   this.Valid_Br_encounter_admitsource=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTER_ADMITSOURCE");
         this.AnyError  = 0;
         try {
            gx.fn.setCtrlProperty("vVREASON","Visible", (this.A92BR_Encounter_AdmitSource=="鍏跺畠") );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A92BR_Encounter_AdmitSource == "鍏跺畠" ) ) )
            {
               gx.fn.setCtrlProperty("VREASON_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A92BR_Encounter_AdmitSource == "鍏跺畠" )
               {
                  gx.fn.setCtrlProperty("VREASON_CELL","Class", "RequiredDataContentCell" );
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
   this.Validv_Vreason=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVREASON");
         this.AnyError  = 0;
         if ( ( ( this.A92BR_Encounter_AdmitSource == "鍏跺畠" ) ) && ((''==this.AV27vReason)) )
         {
            try {
               gxballoon.setError("鍏跺畠鍏ラ櫌鍘熷洜鏄繀濉殑");
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
   this.Valid_Br_encounter_dischargedate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTER_DISCHARGEDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A93BR_Encounter_DischargeDate)==0) || new gx.date.gxdate( this.A93BR_Encounter_DischargeDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
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
   this.Valid_Br_encounter_dischargestatus=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTER_DISCHARGESTATUS");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_encounter_status=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTER_STATUS");
         this.AnyError  = 0;
         if ( ! ( ( this.A172BR_Encounter_Status == 1 ) || ( this.A172BR_Encounter_Status == 2 ) || ( this.A172BR_Encounter_Status == 3 ) || ( this.A172BR_Encounter_Status == 4 ) || ( this.A172BR_Encounter_Status == 5 ) || ( this.A172BR_Encounter_Status == 6 ) || ((0==this.A172BR_Encounter_Status)) ) )
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
   this.Valid_Br_encounter_crtdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTER_CRTDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A182BR_Encounter_CrtDate)==0) || new gx.date.gxdate( this.A182BR_Encounter_CrtDate ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
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
   this.Valid_Br_encounter_upddate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTER_UPDDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A187BR_Encounter_UpdDate)==0) || new gx.date.gxdate( this.A187BR_Encounter_UpdDate ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
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
   this.s112_client=function()
   {
      gx.fn.setCtrlProperty("vVDEPARTMENT","Visible", false );
      gx.fn.setCtrlProperty("VDEPARTMENT_CELL","Class", "Invisible" );
      gx.fn.setCtrlProperty("vVENCTYPE","Visible", false );
      gx.fn.setCtrlProperty("VENCTYPE_CELL","Class", "Invisible" );
      gx.fn.setCtrlProperty("vVREASON","Visible", false );
      gx.fn.setCtrlProperty("VREASON_CELL","Class", "Invisible" );
   };
   this.e120e2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130e15_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140e15_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,40,41,43,44,45,46,47,48,49,50,51,54,55,57,58,59,60,61,62,63,64,65,66,67,68,69,70,73,74,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106];
   this.GXLastCtrlId =106;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "灏辫瘖鍩虹淇℃伅", "str");
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
   GXValidFnc[25]={ id:25 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_information_id,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_ID",gxz:"Z85BR_Information_ID",gxold:"O85BR_Information_ID",gxvar:"A85BR_Information_ID",ucs:[],op:[25,29],ip:[29,25],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A85BR_Information_ID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z85BR_Information_ID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_ID",gx.O.A85BR_Information_ID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A85BR_Information_ID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_INFORMATION_ID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV8Insert_BR_Information_ID))}};
   this.declareDomainHdlr( 25 , function() {
   });
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A36BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z36BR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_PATIENTNO",gx.O.A36BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A36BR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"TABLESPLITTEDBR_ENCOUNTER_DEPARTMENT",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"TEXTBLOCKBR_ENCOUNTER_DEPARTMENT", format:0,grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"TABLEMERGEDBR_ENCOUNTER_DEPARTMENT",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id:41 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounter_department,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_DEPARTMENT",gxz:"Z84BR_Encounter_Department",gxold:"O84BR_Encounter_Department",gxvar:"A84BR_Encounter_Department",ucs:[],op:[],ip:[41],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A84BR_Encounter_Department=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z84BR_Encounter_Department=Value},v2c:function(){gx.fn.setComboBoxValue("BR_ENCOUNTER_DEPARTMENT",gx.O.A84BR_Encounter_Department)},c2v:function(){if(this.val()!==undefined)gx.O.A84BR_Encounter_Department=this.val()},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_DEPARTMENT")},nac:gx.falseFn};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vdepartment,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVDEPARTMENT",gxz:"ZV24vDepartment",gxold:"OV24vDepartment",gxvar:"AV24vDepartment",ucs:[],op:[44,41],ip:[44,41],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV24vDepartment=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24vDepartment=Value},v2c:function(){gx.fn.setControlValue("vVDEPARTMENT",gx.O.AV24vDepartment,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV24vDepartment=this.val()},val:function(){return gx.fn.getControlValue("vVDEPARTMENT")},nac:gx.falseFn};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"TABLESPLITTEDBR_ENCOUNTER_ENCTYPE",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"TEXTBLOCKBR_ENCOUNTER_ENCTYPE", format:0,grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"TABLEMERGEDBR_ENCOUNTER_ENCTYPE",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounter_enctype,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ENCTYPE",gxz:"Z90BR_Encounter_ENCType",gxold:"O90BR_Encounter_ENCType",gxvar:"A90BR_Encounter_ENCType",ucs:[],op:[],ip:[55],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A90BR_Encounter_ENCType=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z90BR_Encounter_ENCType=Value},v2c:function(){gx.fn.setComboBoxValue("BR_ENCOUNTER_ENCTYPE",gx.O.A90BR_Encounter_ENCType)},c2v:function(){if(this.val()!==undefined)gx.O.A90BR_Encounter_ENCType=this.val()},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_ENCTYPE")},nac:gx.falseFn};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Venctype,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVENCTYPE",gxz:"ZV26vENCType",gxold:"OV26vENCType",gxvar:"AV26vENCType",ucs:[],op:[58,55],ip:[58,55],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26vENCType=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26vENCType=Value},v2c:function(){gx.fn.setControlValue("vVENCTYPE",gx.O.AV26vENCType,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26vENCType=this.val()},val:function(){return gx.fn.getControlValue("vVENCTYPE")},nac:gx.falseFn};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounter_admitdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ADMITDATE",gxz:"Z91BR_Encounter_AdmitDate",gxold:"O91BR_Encounter_AdmitDate",gxvar:"A91BR_Encounter_AdmitDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[63],ip:[63],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A91BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z91BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_ADMITDATE",gx.O.A91BR_Encounter_AdmitDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A91BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_ADMITDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 63 , function() {
   });
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"TABLESPLITTEDBR_ENCOUNTER_ADMITSOURCE",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"TEXTBLOCKBR_ENCOUNTER_ADMITSOURCE", format:0,grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"TABLEMERGEDBR_ENCOUNTER_ADMITSOURCE",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id:74 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounter_admitsource,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ADMITSOURCE",gxz:"Z92BR_Encounter_AdmitSource",gxold:"O92BR_Encounter_AdmitSource",gxvar:"A92BR_Encounter_AdmitSource",ucs:[],op:[],ip:[74],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A92BR_Encounter_AdmitSource=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z92BR_Encounter_AdmitSource=Value},v2c:function(){gx.fn.setComboBoxValue("BR_ENCOUNTER_ADMITSOURCE",gx.O.A92BR_Encounter_AdmitSource)},c2v:function(){if(this.val()!==undefined)gx.O.A92BR_Encounter_AdmitSource=this.val()},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_ADMITSOURCE")},nac:gx.falseFn};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id:77 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vreason,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVREASON",gxz:"ZV27vReason",gxold:"OV27vReason",gxvar:"AV27vReason",ucs:[],op:[77,74],ip:[77,74],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27vReason=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27vReason=Value},v2c:function(){gx.fn.setControlValue("vVREASON",gx.O.AV27vReason,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27vReason=this.val()},val:function(){return gx.fn.getControlValue("vVREASON")},nac:gx.falseFn};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id: 80, fld:"",grid:0};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id:82 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounter_dischargedate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_DISCHARGEDATE",gxz:"Z93BR_Encounter_DischargeDate",gxold:"O93BR_Encounter_DischargeDate",gxvar:"A93BR_Encounter_DischargeDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[82],ip:[82],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A93BR_Encounter_DischargeDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z93BR_Encounter_DischargeDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_DISCHARGEDATE",gx.O.A93BR_Encounter_DischargeDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A93BR_Encounter_DischargeDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_DISCHARGEDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 82 , function() {
   });
   GXValidFnc[83]={ id: 83, fld:"",grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id: 85, fld:"",grid:0};
   GXValidFnc[86]={ id:86 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounter_dischargestatus,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_DISCHARGESTATUS",gxz:"Z94BR_Encounter_DischargeStatus",gxold:"O94BR_Encounter_DischargeStatus",gxvar:"A94BR_Encounter_DischargeStatus",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A94BR_Encounter_DischargeStatus=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z94BR_Encounter_DischargeStatus=Value},v2c:function(){gx.fn.setComboBoxValue("BR_ENCOUNTER_DISCHARGESTATUS",gx.O.A94BR_Encounter_DischargeStatus)},c2v:function(){if(this.val()!==undefined)gx.O.A94BR_Encounter_DischargeStatus=this.val()},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_DISCHARGESTATUS")},nac:gx.falseFn};
   GXValidFnc[87]={ id: 87, fld:"",grid:0};
   GXValidFnc[88]={ id: 88, fld:"",grid:0};
   GXValidFnc[89]={ id: 89, fld:"",grid:0};
   GXValidFnc[90]={ id: 90, fld:"",grid:0};
   GXValidFnc[91]={ id: 91, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id: 93, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[94]={ id: 94, fld:"",grid:0};
   GXValidFnc[95]={ id: 95, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[96]={ id: 96, fld:"",grid:0};
   GXValidFnc[97]={ id: 97, fld:"",grid:0};
   GXValidFnc[98]={ id: 98, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[99]={ id:99 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 99 , function() {
   });
   GXValidFnc[100]={ id:100 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ENCID",gxz:"Z35BR_Encounter_EncID",gxold:"O35BR_Encounter_EncID",gxvar:"A35BR_Encounter_EncID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A35BR_Encounter_EncID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z35BR_Encounter_EncID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_ENCID",gx.O.A35BR_Encounter_EncID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A35BR_Encounter_EncID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTER_ENCID",',')},nac:gx.falseFn};
   GXValidFnc[101]={ id:101 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounter_status,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_STATUS",gxz:"Z172BR_Encounter_Status",gxold:"O172BR_Encounter_Status",gxvar:"A172BR_Encounter_Status",ucs:[],op:[101],ip:[101],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A172BR_Encounter_Status=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z172BR_Encounter_Status=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("BR_ENCOUNTER_STATUS",gx.O.A172BR_Encounter_Status);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A172BR_Encounter_Status=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTER_STATUS",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 101 , function() {
   });
   GXValidFnc[102]={ id:102 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounter_crtdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_CRTDATE",gxz:"Z182BR_Encounter_CrtDate",gxold:"O182BR_Encounter_CrtDate",gxvar:"A182BR_Encounter_CrtDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[102],ip:[102],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A182BR_Encounter_CrtDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z182BR_Encounter_CrtDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_CRTDATE",gx.O.A182BR_Encounter_CrtDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A182BR_Encounter_CrtDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("BR_ENCOUNTER_CRTDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 102 , function() {
   });
   GXValidFnc[103]={ id:103 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounter_upddate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_UPDDATE",gxz:"Z187BR_Encounter_UpdDate",gxold:"O187BR_Encounter_UpdDate",gxvar:"A187BR_Encounter_UpdDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[103],ip:[103],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A187BR_Encounter_UpdDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z187BR_Encounter_UpdDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_UPDDATE",gx.O.A187BR_Encounter_UpdDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A187BR_Encounter_UpdDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("BR_ENCOUNTER_UPDDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 103 , function() {
   });
   GXValidFnc[104]={ id:104 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_CRTUSER",gxz:"Z183BR_Encounter_CrtUser",gxold:"O183BR_Encounter_CrtUser",gxvar:"A183BR_Encounter_CrtUser",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A183BR_Encounter_CrtUser=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z183BR_Encounter_CrtUser=Value},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_CRTUSER",gx.O.A183BR_Encounter_CrtUser,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A183BR_Encounter_CrtUser=this.val()},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_CRTUSER")},nac:gx.falseFn};
   this.declareDomainHdlr( 104 , function() {
   });
   GXValidFnc[105]={ id:105 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_UPDUSER",gxz:"Z186BR_Encounter_UpdUser",gxold:"O186BR_Encounter_UpdUser",gxvar:"A186BR_Encounter_UpdUser",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A186BR_Encounter_UpdUser=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z186BR_Encounter_UpdUser=Value},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_UPDUSER",gx.O.A186BR_Encounter_UpdUser,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A186BR_Encounter_UpdUser=this.val()},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_UPDUSER")},nac:gx.falseFn};
   this.declareDomainHdlr( 105 , function() {
   });
   GXValidFnc[106]={ id: 106, fld:"PROMPT_85",grid:15};
   this.A85BR_Information_ID = 0 ;
   this.Z85BR_Information_ID = 0 ;
   this.O85BR_Information_ID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.Z36BR_Information_PatientNo = "" ;
   this.O36BR_Information_PatientNo = "" ;
   this.A84BR_Encounter_Department = "" ;
   this.Z84BR_Encounter_Department = "" ;
   this.O84BR_Encounter_Department = "" ;
   this.AV24vDepartment = "" ;
   this.ZV24vDepartment = "" ;
   this.OV24vDepartment = "" ;
   this.A90BR_Encounter_ENCType = "" ;
   this.Z90BR_Encounter_ENCType = "" ;
   this.O90BR_Encounter_ENCType = "" ;
   this.AV26vENCType = "" ;
   this.ZV26vENCType = "" ;
   this.OV26vENCType = "" ;
   this.A91BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.Z91BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.O91BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.A92BR_Encounter_AdmitSource = "" ;
   this.Z92BR_Encounter_AdmitSource = "" ;
   this.O92BR_Encounter_AdmitSource = "" ;
   this.AV27vReason = "" ;
   this.ZV27vReason = "" ;
   this.OV27vReason = "" ;
   this.A93BR_Encounter_DischargeDate = gx.date.nullDate() ;
   this.Z93BR_Encounter_DischargeDate = gx.date.nullDate() ;
   this.O93BR_Encounter_DischargeDate = gx.date.nullDate() ;
   this.A94BR_Encounter_DischargeStatus = "" ;
   this.Z94BR_Encounter_DischargeStatus = "" ;
   this.O94BR_Encounter_DischargeStatus = "" ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.A35BR_Encounter_EncID = 0 ;
   this.Z35BR_Encounter_EncID = 0 ;
   this.O35BR_Encounter_EncID = 0 ;
   this.A172BR_Encounter_Status = 0 ;
   this.Z172BR_Encounter_Status = 0 ;
   this.O172BR_Encounter_Status = 0 ;
   this.A182BR_Encounter_CrtDate = gx.date.nullDate() ;
   this.Z182BR_Encounter_CrtDate = gx.date.nullDate() ;
   this.O182BR_Encounter_CrtDate = gx.date.nullDate() ;
   this.A187BR_Encounter_UpdDate = gx.date.nullDate() ;
   this.Z187BR_Encounter_UpdDate = gx.date.nullDate() ;
   this.O187BR_Encounter_UpdDate = gx.date.nullDate() ;
   this.A183BR_Encounter_CrtUser = "" ;
   this.Z183BR_Encounter_CrtUser = "" ;
   this.O183BR_Encounter_CrtUser = "" ;
   this.A186BR_Encounter_UpdUser = "" ;
   this.Z186BR_Encounter_UpdUser = "" ;
   this.O186BR_Encounter_UpdUser = "" ;
   this.AV30tCurrentCode = "" ;
   this.AV31Pgmdesc = "" ;
   this.AV14WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV16IsAuthorized = false ;
   this.AV32Pgmname = "" ;
   this.AV11TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV33GXV1 = 0 ;
   this.AV8Insert_BR_Information_ID = 0 ;
   this.AV29Insert_BAS_TenantTenantCode = "" ;
   this.AV12TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV7BR_EncounterID = 0 ;
   this.AV13WebSession = {} ;
   this.A19BR_EncounterID = 0 ;
   this.A85BR_Information_ID = 0 ;
   this.A360BAS_TenantTenantCode = "" ;
   this.AV24vDepartment = "" ;
   this.AV26vENCType = "" ;
   this.AV27vReason = "" ;
   this.A35BR_Encounter_EncID = 0 ;
   this.A172BR_Encounter_Status = 0 ;
   this.A183BR_Encounter_CrtUser = "" ;
   this.A512BR_Encounter_CrtDisplayName = "" ;
   this.A182BR_Encounter_CrtDate = gx.date.nullDate() ;
   this.A470BR_Encounter_Department_Code = "" ;
   this.A471BR_Encounter_ENCType_Code = "" ;
   this.A472BR_Encounter_AdmitSource_Code = "" ;
   this.A473BR_Encounter_DischargeStatus_Code = "" ;
   this.A84BR_Encounter_Department = "" ;
   this.A570BR_Encounter_Departmentadm = "" ;
   this.A571BR_Encounter_Departmentadm_Code = "" ;
   this.A572BR_Encounter_Departmentdisch = "" ;
   this.A573BR_Encounter_Departmentdisch_Code = "" ;
   this.A90BR_Encounter_ENCType = "" ;
   this.A91BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.A92BR_Encounter_AdmitSource = "" ;
   this.A93BR_Encounter_DischargeDate = gx.date.nullDate() ;
   this.A94BR_Encounter_DischargeStatus = "" ;
   this.A574BR_Encounter_Insurance = "" ;
   this.A575BR_Encounter_Insurance_Code = "" ;
   this.A36BR_Information_PatientNo = "" ;
   this.A187BR_Encounter_UpdDate = gx.date.nullDate() ;
   this.A186BR_Encounter_UpdUser = "" ;
   this.A333BR_Encounter_IsDLT = false ;
   this.A184BR_Encounter_SubmitUser = "" ;
   this.A335BR_Encounter_Reason = "" ;
   this.A185BR_Encounter_SubmitDate = gx.date.nullDate() ;
   this.A188BR_Encounter_RecheckUser = "" ;
   this.A336BR_Encounter_FReason = "" ;
   this.A189BR_Encounter_RecheckDate = gx.date.nullDate() ;
   this.A190BR_Encounter_Approver = "" ;
   this.A191BR_Encounter_ApproveDate = gx.date.nullDate() ;
   this.A192BR_Encounter_IsRandApprove = false ;
   this.A203BR_Encounter_IsRandApprover = "" ;
   this.A204BR_Encounter_IsRandNoApprover = "" ;
   this.A205BR_Encounter_IsRandApproveDate = gx.date.nullDate() ;
   this.A206BR_Encounter_IsRandNoApproveDate = gx.date.nullDate() ;
   this.A193BR_Encounter_IsRandRecheck = false ;
   this.A207BR_Encounter_IsRandRecheckr = "" ;
   this.A208BR_Encounter_IsRandNoRecheckr = "" ;
   this.A209BR_Encounter_IsRandRecheckDate = gx.date.nullDate() ;
   this.A210BR_Encounter_IsRandNoRecheckDate = gx.date.nullDate() ;
   this.A202BR_Encounter_IsUpdate = false ;
   this.A537BR_Encounter_Datasource = 0 ;
   this.A560EncounterIDEncrypt = "" ;
   this.Gx_mode = "" ;
   this.Events = {"e120e2_client": ["AFTER TRN", true] ,"e130e15_client": ["ENTER", true] ,"e140e15_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV30tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV8Insert_BR_Information_ID',fld:'vINSERT_BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29Insert_BAS_TenantTenantCode',fld:'vINSERT_BAS_TENANTTENANTCODE',pic:''},{av:'A570BR_Encounter_Departmentadm',fld:'BR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'A571BR_Encounter_Departmentadm_Code',fld:'BR_ENCOUNTER_DEPARTMENTADM_CODE',pic:''},{av:'A572BR_Encounter_Departmentdisch',fld:'BR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'A573BR_Encounter_Departmentdisch_Code',fld:'BR_ENCOUNTER_DEPARTMENTDISCH_CODE',pic:''},{av:'A574BR_Encounter_Insurance',fld:'BR_ENCOUNTER_INSURANCE',pic:''},{av:'A575BR_Encounter_Insurance_Code',fld:'BR_ENCOUNTER_INSURANCE_CODE',pic:''},{av:'A333BR_Encounter_IsDLT',fld:'BR_ENCOUNTER_ISDLT',pic:''},{av:'A184BR_Encounter_SubmitUser',fld:'BR_ENCOUNTER_SUBMITUSER',pic:''},{av:'A335BR_Encounter_Reason',fld:'BR_ENCOUNTER_REASON',pic:''},{av:'A185BR_Encounter_SubmitDate',fld:'BR_ENCOUNTER_SUBMITDATE',pic:'9999/99/99 99:99:99'},{av:'A188BR_Encounter_RecheckUser',fld:'BR_ENCOUNTER_RECHECKUSER',pic:''},{av:'A336BR_Encounter_FReason',fld:'BR_ENCOUNTER_FREASON',pic:''},{av:'A189BR_Encounter_RecheckDate',fld:'BR_ENCOUNTER_RECHECKDATE',pic:'9999/99/99 99:99:99'},{av:'A190BR_Encounter_Approver',fld:'BR_ENCOUNTER_APPROVER',pic:''},{av:'A191BR_Encounter_ApproveDate',fld:'BR_ENCOUNTER_APPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'A192BR_Encounter_IsRandApprove',fld:'BR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'A203BR_Encounter_IsRandApprover',fld:'BR_ENCOUNTER_ISRANDAPPROVER',pic:''},{av:'A204BR_Encounter_IsRandNoApprover',fld:'BR_ENCOUNTER_ISRANDNOAPPROVER',pic:''},{av:'A205BR_Encounter_IsRandApproveDate',fld:'BR_ENCOUNTER_ISRANDAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'A206BR_Encounter_IsRandNoApproveDate',fld:'BR_ENCOUNTER_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'A193BR_Encounter_IsRandRecheck',fld:'BR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'A207BR_Encounter_IsRandRecheckr',fld:'BR_ENCOUNTER_ISRANDRECHECKR',pic:''},{av:'A208BR_Encounter_IsRandNoRecheckr',fld:'BR_ENCOUNTER_ISRANDNORECHECKR',pic:''},{av:'A209BR_Encounter_IsRandRecheckDate',fld:'BR_ENCOUNTER_ISRANDRECHECKDATE',pic:'9999/99/99 99:99:99'},{av:'A210BR_Encounter_IsRandNoRecheckDate',fld:'BR_ENCOUNTER_ISRANDNORECHECKDATE',pic:'9999/99/99 99:99:99'},{av:'A202BR_Encounter_IsUpdate',fld:'BR_ENCOUNTER_ISUPDATE',pic:''},{av:'A537BR_Encounter_Datasource',fld:'BR_ENCOUNTER_DATASOURCE',pic:'ZZZ9'},{av:'A560EncounterIDEncrypt',fld:'ENCOUNTERIDENCRYPT',pic:''}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV32Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV30tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV31Pgmdesc',fld:'vPGMDESC',pic:''},{av:'AV14WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV16IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV33GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV12TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV8Insert_BR_Information_ID',fld:'vINSERT_BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29Insert_BAS_TenantTenantCode',fld:'vINSERT_BAS_TENANTTENANTCODE',pic:''},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCID","Visible")',ctrl:'BR_ENCOUNTER_ENCID',prop:'Visible'},{ctrl:'BR_ENCOUNTER_STATUS'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_CRTDATE","Visible")',ctrl:'BR_ENCOUNTER_CRTDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_UPDDATE","Visible")',ctrl:'BR_ENCOUNTER_UPDDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_CRTUSER","Visible")',ctrl:'BR_ENCOUNTER_CRTUSER',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_UPDUSER","Visible")',ctrl:'BR_ENCOUNTER_UPDUSER',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vVDEPARTMENT","Visible")',ctrl:'vVDEPARTMENT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("VDEPARTMENT_CELL","Class")',ctrl:'VDEPARTMENT_CELL',prop:'Class'},{av:'gx.fn.getCtrlProperty("vVENCTYPE","Visible")',ctrl:'vVENCTYPE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("VENCTYPE_CELL","Class")',ctrl:'VENCTYPE_CELL',prop:'Class'},{av:'gx.fn.getCtrlProperty("vVREASON","Visible")',ctrl:'vVREASON',prop:'Visible'},{av:'gx.fn.getCtrlProperty("VREASON_CELL","Class")',ctrl:'VREASON_CELL',prop:'Class'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.setPrompt("PROMPT_85", [25]);
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV8Insert_BR_Information_ID", "vINSERT_BR_INFORMATION_ID", 0, "int", 18, 0);
   this.setVCMap("AV29Insert_BAS_TenantTenantCode", "vINSERT_BAS_TENANTTENANTCODE", 0, "svchar", 20, 0);
   this.setVCMap("A360BAS_TenantTenantCode", "BAS_TENANTTENANTCODE", 0, "svchar", 20, 0);
   this.setVCMap("A512BR_Encounter_CrtDisplayName", "BR_ENCOUNTER_CRTDISPLAYNAME", 0, "svchar", 100, 0);
   this.setVCMap("A470BR_Encounter_Department_Code", "BR_ENCOUNTER_DEPARTMENT_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A471BR_Encounter_ENCType_Code", "BR_ENCOUNTER_ENCTYPE_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A472BR_Encounter_AdmitSource_Code", "BR_ENCOUNTER_ADMITSOURCE_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A473BR_Encounter_DischargeStatus_Code", "BR_ENCOUNTER_DISCHARGESTATUS_CODE", 0, "svchar", 40, 0);
   this.setVCMap("AV30tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("A570BR_Encounter_Departmentadm", "BR_ENCOUNTER_DEPARTMENTADM", 0, "svchar", 100, 0);
   this.setVCMap("A571BR_Encounter_Departmentadm_Code", "BR_ENCOUNTER_DEPARTMENTADM_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A572BR_Encounter_Departmentdisch", "BR_ENCOUNTER_DEPARTMENTDISCH", 0, "svchar", 100, 0);
   this.setVCMap("A573BR_Encounter_Departmentdisch_Code", "BR_ENCOUNTER_DEPARTMENTDISCH_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A574BR_Encounter_Insurance", "BR_ENCOUNTER_INSURANCE", 0, "svchar", 100, 0);
   this.setVCMap("A575BR_Encounter_Insurance_Code", "BR_ENCOUNTER_INSURANCE_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A333BR_Encounter_IsDLT", "BR_ENCOUNTER_ISDLT", 0, "boolean", 4, 0);
   this.setVCMap("A184BR_Encounter_SubmitUser", "BR_ENCOUNTER_SUBMITUSER", 0, "svchar", 40, 0);
   this.setVCMap("A335BR_Encounter_Reason", "BR_ENCOUNTER_REASON", 0, "svchar", 300, 0);
   this.setVCMap("A185BR_Encounter_SubmitDate", "BR_ENCOUNTER_SUBMITDATE", 0, "dtime", 10, 8);
   this.setVCMap("A188BR_Encounter_RecheckUser", "BR_ENCOUNTER_RECHECKUSER", 0, "svchar", 40, 0);
   this.setVCMap("A336BR_Encounter_FReason", "BR_ENCOUNTER_FREASON", 0, "svchar", 300, 0);
   this.setVCMap("A189BR_Encounter_RecheckDate", "BR_ENCOUNTER_RECHECKDATE", 0, "dtime", 10, 8);
   this.setVCMap("A190BR_Encounter_Approver", "BR_ENCOUNTER_APPROVER", 0, "svchar", 40, 0);
   this.setVCMap("A191BR_Encounter_ApproveDate", "BR_ENCOUNTER_APPROVEDATE", 0, "dtime", 10, 8);
   this.setVCMap("A192BR_Encounter_IsRandApprove", "BR_ENCOUNTER_ISRANDAPPROVE", 0, "boolean", 4, 0);
   this.setVCMap("A203BR_Encounter_IsRandApprover", "BR_ENCOUNTER_ISRANDAPPROVER", 0, "svchar", 40, 0);
   this.setVCMap("A204BR_Encounter_IsRandNoApprover", "BR_ENCOUNTER_ISRANDNOAPPROVER", 0, "svchar", 40, 0);
   this.setVCMap("A205BR_Encounter_IsRandApproveDate", "BR_ENCOUNTER_ISRANDAPPROVEDATE", 0, "dtime", 10, 8);
   this.setVCMap("A206BR_Encounter_IsRandNoApproveDate", "BR_ENCOUNTER_ISRANDNOAPPROVEDATE", 0, "dtime", 10, 8);
   this.setVCMap("A193BR_Encounter_IsRandRecheck", "BR_ENCOUNTER_ISRANDRECHECK", 0, "boolean", 4, 0);
   this.setVCMap("A207BR_Encounter_IsRandRecheckr", "BR_ENCOUNTER_ISRANDRECHECKR", 0, "svchar", 40, 0);
   this.setVCMap("A208BR_Encounter_IsRandNoRecheckr", "BR_ENCOUNTER_ISRANDNORECHECKR", 0, "svchar", 40, 0);
   this.setVCMap("A209BR_Encounter_IsRandRecheckDate", "BR_ENCOUNTER_ISRANDRECHECKDATE", 0, "dtime", 10, 8);
   this.setVCMap("A210BR_Encounter_IsRandNoRecheckDate", "BR_ENCOUNTER_ISRANDNORECHECKDATE", 0, "dtime", 10, 8);
   this.setVCMap("A202BR_Encounter_IsUpdate", "BR_ENCOUNTER_ISUPDATE", 0, "boolean", 4, 0);
   this.setVCMap("A537BR_Encounter_Datasource", "BR_ENCOUNTER_DATASOURCE", 0, "int", 4, 0);
   this.setVCMap("A560EncounterIDEncrypt", "ENCOUNTERIDENCRYPT", 0, "svchar", 500, 0);
   this.setVCMap("AV32Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV31Pgmdesc", "vPGMDESC", 0, "char", 30, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV11TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_encounter);
