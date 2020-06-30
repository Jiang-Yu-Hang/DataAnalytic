/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:36:58.95
*/
gx.evt.autoSkip = false;
gx.define('br_medication', false, function () {
   this.ServerClass =  "br_medication" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV12BR_MedicationID=gx.fn.getIntegerValue("vBR_MEDICATIONID",',') ;
      this.AV10Insert_BR_EncounterID=gx.fn.getIntegerValue("vINSERT_BR_ENCOUNTERID",',') ;
      this.A478BR_Medication_RXFrequency_Code=gx.fn.getControlValue("BR_MEDICATION_RXFREQUENCY_CODE") ;
      this.A477BR_Medication_RXRoute_Code=gx.fn.getControlValue("BR_MEDICATION_RXROUTE_CODE") ;
      this.A507BR_Medication_InpatientChemo_Code=gx.fn.getControlValue("BR_MEDICATION_INPATIENTCHEMO_CODE") ;
      this.AV21tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.A120BR_Medication_RXID=gx.fn.getIntegerValue("BR_MEDICATION_RXID",',') ;
      this.A499BR_Medication_RXName_Code=gx.fn.getControlValue("BR_MEDICATION_RXNAME_CODE") ;
      this.A85BR_Information_ID=gx.fn.getIntegerValue("BR_INFORMATION_ID",',') ;
      this.AV22Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV8TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_medicationid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATIONID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_medication_rxname=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATION_RXNAME");
         this.AnyError  = 0;
         try {
            gx.fn.setCtrlProperty("vVMEDICATIONNAME","Visible", (this.A121BR_Medication_RXName=="鍏跺畠") );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A121BR_Medication_RXName == "鍏跺畠" ) ) )
            {
               gx.fn.setCtrlProperty("VMEDICATIONNAME_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A121BR_Medication_RXName == "鍏跺畠" )
               {
                  gx.fn.setCtrlProperty("VMEDICATIONNAME_CELL","Class", "RequiredDataContentCell" );
               }
            }
         }
         catch(e){}
         if ( ((''==this.A121BR_Medication_RXName)) )
         {
            try {
               gxballoon.setError("鑽墿鍚嶇О鏄繀椤诲～鍐欑殑銆?);
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
   this.Validv_Vmedicationname=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVMEDICATIONNAME");
         this.AnyError  = 0;
         if ( ( ( this.A121BR_Medication_RXName == "鍏跺畠" ) ) && ((''==this.AV20vMedicationName)) )
         {
            try {
               gxballoon.setError("鍏跺畠鑽墿鍚嶇О鏄繀濉殑");
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
   this.Valid_Br_medication_rxfrequency=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATION_RXFREQUENCY");
         this.AnyError  = 0;
         try {
            gx.fn.setCtrlProperty("vVFREQUENCY","Visible", (this.A126BR_Medication_RXFrequency=="鍏跺畠") );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A126BR_Medication_RXFrequency == "鍏跺畠" ) ) )
            {
               gx.fn.setCtrlProperty("VFREQUENCY_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A126BR_Medication_RXFrequency == "鍏跺畠" )
               {
                  gx.fn.setCtrlProperty("VFREQUENCY_CELL","Class", "RequiredDataContentCell" );
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
   this.Validv_Vfrequency=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVFREQUENCY");
         this.AnyError  = 0;
         if ( ( ( this.A126BR_Medication_RXFrequency == "鍏跺畠" ) ) && ((''==this.AV19vFrequency)) )
         {
            try {
               gxballoon.setError("鍏跺畠鏈嶈嵂棰戠巼鏄繀濉殑");
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
   this.Valid_Br_medication_rxroute=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATION_RXROUTE");
         this.AnyError  = 0;
         try {
            gx.fn.setCtrlProperty("vVRXROUTE","Visible", (this.A129BR_Medication_RXRoute=="鍏跺畠") );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A129BR_Medication_RXRoute == "鍏跺畠" ) ) )
            {
               gx.fn.setCtrlProperty("VRXROUTE_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A129BR_Medication_RXRoute == "鍏跺畠" )
               {
                  gx.fn.setCtrlProperty("VRXROUTE_CELL","Class", "RequiredDataContentCell" );
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
   this.Validv_Vrxroute=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVRXROUTE");
         this.AnyError  = 0;
         if ( ( ( this.A129BR_Medication_RXRoute == "鍏跺畠" ) ) && ((''==this.AV15vRXRoute)) )
         {
            try {
               gxballoon.setError("鍏跺畠缁欒嵂閫斿緞鏄繀濉殑");
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
   this.Valid_Br_medication_prescriptiondate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATION_PRESCRIPTIONDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A130BR_Medication_PrescriptionDate)==0) || new gx.date.gxdate( this.A130BR_Medication_PrescriptionDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
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
   this.Valid_Br_medication_admitstartdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATION_ADMITSTARTDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A132BR_Medication_AdmitStartDate)==0) || new gx.date.gxdate( this.A132BR_Medication_AdmitStartDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }
         if ( (new gx.date.gxdate('').compare(this.A132BR_Medication_AdmitStartDate)==0) )
         {
            try {
               gxballoon.setError("鏈嶈嵂鏃ユ湡鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_medication_admitenddate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATION_ADMITENDDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A133BR_Medication_AdmitEndDate)==0) || new gx.date.gxdate( this.A133BR_Medication_AdmitEndDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
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
   this.Valid_Br_medication_inpatientchemo=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATION_INPATIENTCHEMO");
         this.AnyError  = 0;
         if ( ! ( ( this.A131BR_Medication_InpatientChemo == "鍚? ) || ( this.A131BR_Medication_InpatientChemo == "鏄? ) || ( this.A131BR_Medication_InpatientChemo == "涓嶈" ) || ((''==this.A131BR_Medication_InpatientChemo)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
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
      gx.fn.setCtrlProperty("vVMEDICATIONNAME","Visible", false );
      gx.fn.setCtrlProperty("VMEDICATIONNAME_CELL","Class", "Invisible" );
      gx.fn.setCtrlProperty("vVFREQUENCY","Visible", false );
      gx.fn.setCtrlProperty("VFREQUENCY_CELL","Class", "Invisible" );
      gx.fn.setCtrlProperty("vVRXROUTE","Visible", false );
      gx.fn.setCtrlProperty("VRXROUTE_CELL","Class", "Invisible" );
   };
   this.e120h2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130h18_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140h18_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,31,32,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,63,64,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,87,88,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124];
   this.GXLastCtrlId =124;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鑽墿娌荤枟", "str");
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
   GXValidFnc[23]={ id: 23, fld:"TABLESPLITTEDBR_MEDICATION_RXNAME",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_MEDICATION_RXNAME", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"TABLEMERGEDBR_MEDICATION_RXNAME",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id:32 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_rxname,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXNAME",gxz:"Z121BR_Medication_RXName",gxold:"O121BR_Medication_RXName",gxvar:"A121BR_Medication_RXName",ucs:[],op:[32],ip:[32],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A121BR_Medication_RXName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z121BR_Medication_RXName=Value},v2c:function(){gx.fn.setComboBoxValue("BR_MEDICATION_RXNAME",gx.O.A121BR_Medication_RXName)},c2v:function(){if(this.val()!==undefined)gx.O.A121BR_Medication_RXName=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXNAME")},nac:gx.falseFn};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id:35 ,lvl:0,type:"svchar",len:99,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vmedicationname,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVMEDICATIONNAME",gxz:"ZV20vMedicationName",gxold:"OV20vMedicationName",gxvar:"AV20vMedicationName",ucs:[],op:[35,32],ip:[35,32],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20vMedicationName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20vMedicationName=Value},v2c:function(){gx.fn.setControlValue("vVMEDICATIONNAME",gx.O.AV20vMedicationName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20vMedicationName=this.val()},val:function(){return gx.fn.getControlValue("vVMEDICATIONNAME")},nac:gx.falseFn};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXCODE",gxz:"Z122BR_Medication_RXCode",gxold:"O122BR_Medication_RXCode",gxvar:"A122BR_Medication_RXCode",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A122BR_Medication_RXCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z122BR_Medication_RXCode=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXCODE",gx.O.A122BR_Medication_RXCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.A122BR_Medication_RXCode=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXCODE")},nac:gx.falseFn};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXTYPE",gxz:"Z123BR_Medication_RXType",gxold:"O123BR_Medication_RXType",gxvar:"A123BR_Medication_RXType",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A123BR_Medication_RXType=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z123BR_Medication_RXType=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXTYPE",gx.O.A123BR_Medication_RXType,0)},c2v:function(){if(this.val()!==undefined)gx.O.A123BR_Medication_RXType=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXTYPE")},nac:gx.falseFn};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXDOSE",gxz:"Z124BR_Medication_RXDose",gxold:"O124BR_Medication_RXDose",gxvar:"A124BR_Medication_RXDose",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A124BR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z124BR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_MEDICATION_RXDOSE",gx.O.A124BR_Medication_RXDose,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A124BR_Medication_RXDose=this.val()},val:function(){return gx.fn.getDecimalValue("BR_MEDICATION_RXDOSE",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 48 , function() {
   });
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXUNIT",gxz:"Z125BR_Medication_RXUnit",gxold:"O125BR_Medication_RXUnit",gxvar:"A125BR_Medication_RXUnit",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A125BR_Medication_RXUnit=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z125BR_Medication_RXUnit=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXUNIT",gx.O.A125BR_Medication_RXUnit,0)},c2v:function(){if(this.val()!==undefined)gx.O.A125BR_Medication_RXUnit=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXUNIT")},nac:gx.falseFn};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"TABLESPLITTEDBR_MEDICATION_RXFREQUENCY",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id: 58, fld:"TEXTBLOCKBR_MEDICATION_RXFREQUENCY", format:0,grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"TABLEMERGEDBR_MEDICATION_RXFREQUENCY",grid:0};
   GXValidFnc[63]={ id: 63, fld:"",grid:0};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_rxfrequency,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXFREQUENCY",gxz:"Z126BR_Medication_RXFrequency",gxold:"O126BR_Medication_RXFrequency",gxvar:"A126BR_Medication_RXFrequency",ucs:[],op:[],ip:[64],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A126BR_Medication_RXFrequency=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z126BR_Medication_RXFrequency=Value},v2c:function(){gx.fn.setComboBoxValue("BR_MEDICATION_RXFREQUENCY",gx.O.A126BR_Medication_RXFrequency)},c2v:function(){if(this.val()!==undefined)gx.O.A126BR_Medication_RXFrequency=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXFREQUENCY")},nac:gx.falseFn};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vfrequency,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVFREQUENCY",gxz:"ZV19vFrequency",gxold:"OV19vFrequency",gxvar:"AV19vFrequency",ucs:[],op:[67,64],ip:[67,64],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19vFrequency=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19vFrequency=Value},v2c:function(){gx.fn.setControlValue("vVFREQUENCY",gx.O.AV19vFrequency,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19vFrequency=this.val()},val:function(){return gx.fn.getControlValue("vVFREQUENCY")},nac:gx.falseFn};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id:72 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXQUANTITY",gxz:"Z127BR_Medication_RXQuantity",gxold:"O127BR_Medication_RXQuantity",gxvar:"A127BR_Medication_RXQuantity",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A127BR_Medication_RXQuantity=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z127BR_Medication_RXQuantity=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXQUANTITY",gx.O.A127BR_Medication_RXQuantity,0)},c2v:function(){if(this.val()!==undefined)gx.O.A127BR_Medication_RXQuantity=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXQUANTITY")},nac:gx.falseFn};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id: 74, fld:"",grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id:76 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXDAYSSUPPLY",gxz:"Z128BR_Medication_RXDaysSupply",gxold:"O128BR_Medication_RXDaysSupply",gxvar:"A128BR_Medication_RXDaysSupply",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A128BR_Medication_RXDaysSupply=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z128BR_Medication_RXDaysSupply=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_MEDICATION_RXDAYSSUPPLY",gx.O.A128BR_Medication_RXDaysSupply,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A128BR_Medication_RXDaysSupply=this.val()},val:function(){return gx.fn.getDecimalValue("BR_MEDICATION_RXDAYSSUPPLY",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 76 , function() {
   });
   GXValidFnc[77]={ id: 77, fld:"",grid:0};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"TABLESPLITTEDBR_MEDICATION_RXROUTE",grid:0};
   GXValidFnc[80]={ id: 80, fld:"",grid:0};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"TEXTBLOCKBR_MEDICATION_RXROUTE", format:0,grid:0};
   GXValidFnc[83]={ id: 83, fld:"",grid:0};
   GXValidFnc[84]={ id: 84, fld:"TABLEMERGEDBR_MEDICATION_RXROUTE",grid:0};
   GXValidFnc[87]={ id: 87, fld:"",grid:0};
   GXValidFnc[88]={ id:88 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_rxroute,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXROUTE",gxz:"Z129BR_Medication_RXRoute",gxold:"O129BR_Medication_RXRoute",gxvar:"A129BR_Medication_RXRoute",ucs:[],op:[],ip:[88],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A129BR_Medication_RXRoute=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z129BR_Medication_RXRoute=Value},v2c:function(){gx.fn.setComboBoxValue("BR_MEDICATION_RXROUTE",gx.O.A129BR_Medication_RXRoute)},c2v:function(){if(this.val()!==undefined)gx.O.A129BR_Medication_RXRoute=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXROUTE")},nac:gx.falseFn};
   GXValidFnc[90]={ id: 90, fld:"",grid:0};
   GXValidFnc[91]={ id:91 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vrxroute,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVRXROUTE",gxz:"ZV15vRXRoute",gxold:"OV15vRXRoute",gxvar:"AV15vRXRoute",ucs:[],op:[91,88],ip:[91,88],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15vRXRoute=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV15vRXRoute=Value},v2c:function(){gx.fn.setControlValue("vVRXROUTE",gx.O.AV15vRXRoute,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15vRXRoute=this.val()},val:function(){return gx.fn.getControlValue("vVRXROUTE")},nac:gx.falseFn};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id: 93, fld:"",grid:0};
   GXValidFnc[94]={ id: 94, fld:"",grid:0};
   GXValidFnc[95]={ id:95 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_prescriptiondate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_PRESCRIPTIONDATE",gxz:"Z130BR_Medication_PrescriptionDate",gxold:"O130BR_Medication_PrescriptionDate",gxvar:"A130BR_Medication_PrescriptionDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[95],ip:[95],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A130BR_Medication_PrescriptionDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z130BR_Medication_PrescriptionDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_PRESCRIPTIONDATE",gx.O.A130BR_Medication_PrescriptionDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A130BR_Medication_PrescriptionDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_PRESCRIPTIONDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 95 , function() {
   });
   GXValidFnc[96]={ id: 96, fld:"",grid:0};
   GXValidFnc[97]={ id: 97, fld:"",grid:0};
   GXValidFnc[98]={ id: 98, fld:"",grid:0};
   GXValidFnc[99]={ id: 99, fld:"",grid:0};
   GXValidFnc[100]={ id:100 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_admitstartdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_ADMITSTARTDATE",gxz:"Z132BR_Medication_AdmitStartDate",gxold:"O132BR_Medication_AdmitStartDate",gxvar:"A132BR_Medication_AdmitStartDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[100],ip:[100],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A132BR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z132BR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_ADMITSTARTDATE",gx.O.A132BR_Medication_AdmitStartDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A132BR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_ADMITSTARTDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 100 , function() {
   });
   GXValidFnc[101]={ id: 101, fld:"",grid:0};
   GXValidFnc[102]={ id: 102, fld:"",grid:0};
   GXValidFnc[103]={ id: 103, fld:"",grid:0};
   GXValidFnc[104]={ id:104 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_admitenddate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_ADMITENDDATE",gxz:"Z133BR_Medication_AdmitEndDate",gxold:"O133BR_Medication_AdmitEndDate",gxvar:"A133BR_Medication_AdmitEndDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[104],ip:[104],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A133BR_Medication_AdmitEndDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z133BR_Medication_AdmitEndDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_ADMITENDDATE",gx.O.A133BR_Medication_AdmitEndDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A133BR_Medication_AdmitEndDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_ADMITENDDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 104 , function() {
   });
   GXValidFnc[105]={ id: 105, fld:"",grid:0};
   GXValidFnc[106]={ id: 106, fld:"",grid:0};
   GXValidFnc[107]={ id: 107, fld:"",grid:0};
   GXValidFnc[108]={ id: 108, fld:"",grid:0};
   GXValidFnc[109]={ id:109 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_inpatientchemo,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_INPATIENTCHEMO",gxz:"Z131BR_Medication_InpatientChemo",gxold:"O131BR_Medication_InpatientChemo",gxvar:"A131BR_Medication_InpatientChemo",ucs:[],op:[109],ip:[109],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A131BR_Medication_InpatientChemo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z131BR_Medication_InpatientChemo=Value},v2c:function(){gx.fn.setComboBoxValue("BR_MEDICATION_INPATIENTCHEMO",gx.O.A131BR_Medication_InpatientChemo);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A131BR_Medication_InpatientChemo=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICATION_INPATIENTCHEMO")},nac:gx.falseFn};
   this.declareDomainHdlr( 109 , function() {
   });
   GXValidFnc[110]={ id: 110, fld:"",grid:0};
   GXValidFnc[111]={ id: 111, fld:"",grid:0};
   GXValidFnc[112]={ id: 112, fld:"",grid:0};
   GXValidFnc[113]={ id: 113, fld:"",grid:0};
   GXValidFnc[114]={ id: 114, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[115]={ id: 115, fld:"",grid:0};
   GXValidFnc[116]={ id: 116, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[117]={ id: 117, fld:"",grid:0};
   GXValidFnc[118]={ id: 118, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[119]={ id: 119, fld:"",grid:0};
   GXValidFnc[120]={ id: 120, fld:"",grid:0};
   GXValidFnc[121]={ id: 121, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[122]={ id:122 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_medicationid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATIONID",gxz:"Z119BR_MedicationID",gxold:"O119BR_MedicationID",gxvar:"A119BR_MedicationID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z119BR_MedicationID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICATIONID",gx.O.A119BR_MedicationID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICATIONID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 122 , function() {
   });
   GXValidFnc[123]={ id:123 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[124],ip:[124,123],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV10Insert_BR_EncounterID))}};
   this.declareDomainHdlr( 123 , function() {
   });
   GXValidFnc[124]={ id:124 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A36BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z36BR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_PATIENTNO",gx.O.A36BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A36BR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   this.A121BR_Medication_RXName = "" ;
   this.Z121BR_Medication_RXName = "" ;
   this.O121BR_Medication_RXName = "" ;
   this.AV20vMedicationName = "" ;
   this.ZV20vMedicationName = "" ;
   this.OV20vMedicationName = "" ;
   this.A122BR_Medication_RXCode = "" ;
   this.Z122BR_Medication_RXCode = "" ;
   this.O122BR_Medication_RXCode = "" ;
   this.A123BR_Medication_RXType = "" ;
   this.Z123BR_Medication_RXType = "" ;
   this.O123BR_Medication_RXType = "" ;
   this.A124BR_Medication_RXDose = 0 ;
   this.Z124BR_Medication_RXDose = 0 ;
   this.O124BR_Medication_RXDose = 0 ;
   this.A125BR_Medication_RXUnit = "" ;
   this.Z125BR_Medication_RXUnit = "" ;
   this.O125BR_Medication_RXUnit = "" ;
   this.A126BR_Medication_RXFrequency = "" ;
   this.Z126BR_Medication_RXFrequency = "" ;
   this.O126BR_Medication_RXFrequency = "" ;
   this.AV19vFrequency = "" ;
   this.ZV19vFrequency = "" ;
   this.OV19vFrequency = "" ;
   this.A127BR_Medication_RXQuantity = "" ;
   this.Z127BR_Medication_RXQuantity = "" ;
   this.O127BR_Medication_RXQuantity = "" ;
   this.A128BR_Medication_RXDaysSupply = 0 ;
   this.Z128BR_Medication_RXDaysSupply = 0 ;
   this.O128BR_Medication_RXDaysSupply = 0 ;
   this.A129BR_Medication_RXRoute = "" ;
   this.Z129BR_Medication_RXRoute = "" ;
   this.O129BR_Medication_RXRoute = "" ;
   this.AV15vRXRoute = "" ;
   this.ZV15vRXRoute = "" ;
   this.OV15vRXRoute = "" ;
   this.A130BR_Medication_PrescriptionDate = gx.date.nullDate() ;
   this.Z130BR_Medication_PrescriptionDate = gx.date.nullDate() ;
   this.O130BR_Medication_PrescriptionDate = gx.date.nullDate() ;
   this.A132BR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.Z132BR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.O132BR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.A133BR_Medication_AdmitEndDate = gx.date.nullDate() ;
   this.Z133BR_Medication_AdmitEndDate = gx.date.nullDate() ;
   this.O133BR_Medication_AdmitEndDate = gx.date.nullDate() ;
   this.A131BR_Medication_InpatientChemo = "" ;
   this.Z131BR_Medication_InpatientChemo = "" ;
   this.O131BR_Medication_InpatientChemo = "" ;
   this.A119BR_MedicationID = 0 ;
   this.Z119BR_MedicationID = 0 ;
   this.O119BR_MedicationID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.Z36BR_Information_PatientNo = "" ;
   this.O36BR_Information_PatientNo = "" ;
   this.A85BR_Information_ID = 0 ;
   this.AV21tCurrentCode = "" ;
   this.AV7WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV13IsAuthorized = false ;
   this.AV22Pgmname = "" ;
   this.AV8TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV23GXV1 = 0 ;
   this.AV10Insert_BR_EncounterID = 0 ;
   this.AV11TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV12BR_MedicationID = 0 ;
   this.AV9WebSession = {} ;
   this.A119BR_MedicationID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.AV20vMedicationName = "" ;
   this.AV19vFrequency = "" ;
   this.AV15vRXRoute = "" ;
   this.A478BR_Medication_RXFrequency_Code = "" ;
   this.A477BR_Medication_RXRoute_Code = "" ;
   this.A507BR_Medication_InpatientChemo_Code = "" ;
   this.A36BR_Information_PatientNo = "" ;
   this.A120BR_Medication_RXID = 0 ;
   this.A121BR_Medication_RXName = "" ;
   this.A499BR_Medication_RXName_Code = "" ;
   this.A122BR_Medication_RXCode = "" ;
   this.A123BR_Medication_RXType = "" ;
   this.A124BR_Medication_RXDose = 0 ;
   this.A125BR_Medication_RXUnit = "" ;
   this.A126BR_Medication_RXFrequency = "" ;
   this.A127BR_Medication_RXQuantity = "" ;
   this.A128BR_Medication_RXDaysSupply = 0 ;
   this.A129BR_Medication_RXRoute = "" ;
   this.A130BR_Medication_PrescriptionDate = gx.date.nullDate() ;
   this.A132BR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.A133BR_Medication_AdmitEndDate = gx.date.nullDate() ;
   this.A131BR_Medication_InpatientChemo = "" ;
   this.Gx_mode = "" ;
   this.Events = {"e120h2_client": ["AFTER TRN", true] ,"e130h18_client": ["ENTER", true] ,"e140h18_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_MedicationID',fld:'vBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_MedicationID',fld:'vBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A119BR_MedicationID',fld:'BR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A120BR_Medication_RXID',fld:'BR_MEDICATION_RXID',pic:'ZZZZ'},{av:'A499BR_Medication_RXName_Code',fld:'BR_MEDICATION_RXNAME_CODE',pic:''}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV22Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV21tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV7WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV13IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV23GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV11TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Visible")',ctrl:'BR_MEDICATIONID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Visible")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vVMEDICATIONNAME","Visible")',ctrl:'vVMEDICATIONNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("VMEDICATIONNAME_CELL","Class")',ctrl:'VMEDICATIONNAME_CELL',prop:'Class'},{av:'gx.fn.getCtrlProperty("vVFREQUENCY","Visible")',ctrl:'vVFREQUENCY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("VFREQUENCY_CELL","Class")',ctrl:'VFREQUENCY_CELL',prop:'Class'},{av:'gx.fn.getCtrlProperty("vVRXROUTE","Visible")',ctrl:'vVRXROUTE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("VRXROUTE_CELL","Class")',ctrl:'VRXROUTE_CELL',prop:'Class'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV12BR_MedicationID", "vBR_MEDICATIONID", 0, "int", 18, 0);
   this.setVCMap("AV10Insert_BR_EncounterID", "vINSERT_BR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("A478BR_Medication_RXFrequency_Code", "BR_MEDICATION_RXFREQUENCY_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A477BR_Medication_RXRoute_Code", "BR_MEDICATION_RXROUTE_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A507BR_Medication_InpatientChemo_Code", "BR_MEDICATION_INPATIENTCHEMO_CODE", 0, "svchar", 40, 0);
   this.setVCMap("AV21tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("A120BR_Medication_RXID", "BR_MEDICATION_RXID", 0, "int", 4, 0);
   this.setVCMap("A499BR_Medication_RXName_Code", "BR_MEDICATION_RXNAME_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A85BR_Information_ID", "BR_INFORMATION_ID", 0, "int", 18, 0);
   this.setVCMap("AV22Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV8TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_medication);
