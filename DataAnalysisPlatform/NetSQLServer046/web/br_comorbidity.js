/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 13:20:16.36
*/
gx.evt.autoSkip = false;
gx.define('br_comorbidity', false, function () {
   this.ServerClass =  "br_comorbidity" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.A487BR_Comorbidity_Hypertension_Code=gx.fn.getControlValue("BR_COMORBIDITY_HYPERTENSION_CODE") ;
      this.A488BR_Comorbidity_Diabetes_Code=gx.fn.getControlValue("BR_COMORBIDITY_DIABETES_CODE") ;
      this.A489BR_Comorbidity_CHD_Code=gx.fn.getControlValue("BR_COMORBIDITY_CHD_CODE") ;
      this.A490BR_Comorbidity_Hapetitis_Code=gx.fn.getControlValue("BR_COMORBIDITY_HAPETITIS_CODE") ;
      this.A491BR_Comorbidity_TB_Code=gx.fn.getControlValue("BR_COMORBIDITY_TB_CODE") ;
      this.A492BR_Comorbidity_KidneyDisease_Code=gx.fn.getControlValue("BR_COMORBIDITY_KIDNEYDISEASE_CODE") ;
      this.A493BR_Comorbidity_SurgeryHistory_Code=gx.fn.getControlValue("BR_COMORBIDITY_SURGERYHISTORY_CODE") ;
      this.A494BR_Comorbidity_InjuryHistory_Code=gx.fn.getControlValue("BR_COMORBIDITY_INJURYHISTORY_CODE") ;
      this.A495BR_Comorbidity_BloodHistory_Code=gx.fn.getControlValue("BR_COMORBIDITY_BLOODHISTORY_CODE") ;
      this.A496BR_Comorbidity_allergy_Code=gx.fn.getControlValue("BR_COMORBIDITY_ALLERGY_CODE") ;
      this.A259BR_Comorbidity_Others=gx.fn.getControlValue("BR_COMORBIDITY_OTHERS") ;
      this.A561BR_Comorbidity_HapetitisB=gx.fn.getControlValue("BR_COMORBIDITY_HAPETITISB") ;
      this.A562BR_Comorbidity_HapetitisB_Code=gx.fn.getControlValue("BR_COMORBIDITY_HAPETITISB_CODE") ;
      this.A563BR_Comorbidity_HapetitisC=gx.fn.getControlValue("BR_COMORBIDITY_HAPETITISC") ;
      this.A564BR_Comorbidity_HapetitisC_Code=gx.fn.getControlValue("BR_COMORBIDITY_HAPETITISC_CODE") ;
      this.A565BR_Comorbidity_LiverCirrhosis=gx.fn.getControlValue("BR_COMORBIDITY_LIVERCIRRHOSIS") ;
      this.A566BR_Comorbidity_LiverCirrhosis_Code=gx.fn.getControlValue("BR_COMORBIDITY_LIVERCIRRHOSIS_CODE") ;
      this.A567BR_Comorbidity_Druginducedliverinjury=gx.fn.getControlValue("BR_COMORBIDITY_DRUGINDUCEDLIVERINJURY") ;
      this.A568BR_Comorbidity_Druginducedliverinjury_Code=gx.fn.getControlValue("BR_COMORBIDITY_DRUGINDUCEDLIVERINJURY_CODE") ;
      this.A85BR_Information_ID=gx.fn.getIntegerValue("BR_INFORMATION_ID",',') ;
      this.A36BR_Information_PatientNo=gx.fn.getControlValue("BR_INFORMATION_PATIENTNO") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
   };
   this.Valid_Br_comorbidityid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_comorbidityid",["gx.num.urlDecimal(gx.O.A37BR_ComorbidityID,\',\',\'.\')", "gx.O.A487BR_Comorbidity_Hypertension_Code", "gx.O.A488BR_Comorbidity_Diabetes_Code", "gx.O.A489BR_Comorbidity_CHD_Code", "gx.O.A490BR_Comorbidity_Hapetitis_Code", "gx.O.A491BR_Comorbidity_TB_Code", "gx.O.A492BR_Comorbidity_KidneyDisease_Code", "gx.O.A493BR_Comorbidity_SurgeryHistory_Code", "gx.O.A494BR_Comorbidity_InjuryHistory_Code", "gx.O.A495BR_Comorbidity_BloodHistory_Code", "gx.O.A496BR_Comorbidity_allergy_Code", "gx.O.A38BR_Comorbidity_Hypertension", "gx.O.A39BR_Comorbidity_Diabetes", "gx.O.A40BR_Comorbidity_CHD", "gx.O.A41BR_Comorbidity_Hapetitis", "gx.O.A42BR_Comorbidity_TB", "gx.O.A43BR_Comorbidity_KidneyDisease", "gx.O.A44BR_Comorbidity_SurgeryHistory", "gx.O.A45BR_Comorbidity_InjuryHistory", "gx.O.A46BR_Comorbidity_BloodHistory", "gx.O.A47BR_Comorbidity_allergy", "gx.O.A259BR_Comorbidity_Others", "gx.O.A561BR_Comorbidity_HapetitisB", "gx.O.A562BR_Comorbidity_HapetitisB_Code", "gx.O.A563BR_Comorbidity_HapetitisC", "gx.O.A564BR_Comorbidity_HapetitisC_Code", "gx.O.A565BR_Comorbidity_LiverCirrhosis", "gx.O.A566BR_Comorbidity_LiverCirrhosis_Code", "gx.O.A567BR_Comorbidity_Druginducedliverinjury", "gx.O.A568BR_Comorbidity_Druginducedliverinjury_Code", "gx.num.urlDecimal(gx.O.A19BR_EncounterID,\',\',\'.\')"],["A487BR_Comorbidity_Hypertension_Code", "A488BR_Comorbidity_Diabetes_Code", "A489BR_Comorbidity_CHD_Code", "A490BR_Comorbidity_Hapetitis_Code", "A491BR_Comorbidity_TB_Code", "A492BR_Comorbidity_KidneyDisease_Code", "A493BR_Comorbidity_SurgeryHistory_Code", "A494BR_Comorbidity_InjuryHistory_Code", "A495BR_Comorbidity_BloodHistory_Code", "A496BR_Comorbidity_allergy_Code", "A19BR_EncounterID", "A38BR_Comorbidity_Hypertension", "A39BR_Comorbidity_Diabetes", "A40BR_Comorbidity_CHD", "A41BR_Comorbidity_Hapetitis", "A42BR_Comorbidity_TB", "A43BR_Comorbidity_KidneyDisease", "A44BR_Comorbidity_SurgeryHistory", "A45BR_Comorbidity_InjuryHistory", "A46BR_Comorbidity_BloodHistory", "A47BR_Comorbidity_allergy", "A259BR_Comorbidity_Others", "A561BR_Comorbidity_HapetitisB", "A562BR_Comorbidity_HapetitisB_Code", "A563BR_Comorbidity_HapetitisC", "A564BR_Comorbidity_HapetitisC_Code", "A565BR_Comorbidity_LiverCirrhosis", "A566BR_Comorbidity_LiverCirrhosis_Code", "A567BR_Comorbidity_Druginducedliverinjury", "A568BR_Comorbidity_Druginducedliverinjury_Code", "A85BR_Information_ID", "A36BR_Information_PatientNo", "Gx_mode", "Z37BR_ComorbidityID", "Z487BR_Comorbidity_Hypertension_Code", "Z488BR_Comorbidity_Diabetes_Code", "Z489BR_Comorbidity_CHD_Code", "Z490BR_Comorbidity_Hapetitis_Code", "Z491BR_Comorbidity_TB_Code", "Z492BR_Comorbidity_KidneyDisease_Code", "Z493BR_Comorbidity_SurgeryHistory_Code", "Z494BR_Comorbidity_InjuryHistory_Code", "Z495BR_Comorbidity_BloodHistory_Code", "Z496BR_Comorbidity_allergy_Code", "Z19BR_EncounterID", "Z38BR_Comorbidity_Hypertension", "Z39BR_Comorbidity_Diabetes", "Z40BR_Comorbidity_CHD", "Z41BR_Comorbidity_Hapetitis", "Z42BR_Comorbidity_TB", "Z43BR_Comorbidity_KidneyDisease", "Z44BR_Comorbidity_SurgeryHistory", "Z45BR_Comorbidity_InjuryHistory", "Z46BR_Comorbidity_BloodHistory", "Z47BR_Comorbidity_allergy", "Z259BR_Comorbidity_Others", "Z561BR_Comorbidity_HapetitisB", "Z562BR_Comorbidity_HapetitisB_Code", "Z563BR_Comorbidity_HapetitisC", "Z564BR_Comorbidity_HapetitisC_Code", "Z565BR_Comorbidity_LiverCirrhosis", "Z566BR_Comorbidity_LiverCirrhosis_Code", "Z567BR_Comorbidity_Druginducedliverinjury", "Z568BR_Comorbidity_Druginducedliverinjury_Code", "Z85BR_Information_ID", "Z36BR_Information_PatientNo", ["BTNTRN_DELETE","Enabled"], ["BTNTRN_ENTER","Enabled"]]);
      return true;
   }
   this.Valid_Br_encounterid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_encounterid",["gx.num.urlDecimal(gx.O.A19BR_EncounterID,\',\',\'.\')", "gx.num.urlDecimal(gx.O.A85BR_Information_ID,\',\',\'.\')", "gx.O.A36BR_Information_PatientNo"],["A85BR_Information_ID", "A36BR_Information_PatientNo"]);
      return true;
   }
   this.Valid_Br_comorbidity_hypertension=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_COMORBIDITY_HYPERTENSION");
         this.AnyError  = 0;
         if ( ! ( ( this.A38BR_Comorbidity_Hypertension == "鍚? ) || ( this.A38BR_Comorbidity_Hypertension == "鏄? ) || ( this.A38BR_Comorbidity_Hypertension == "涓嶈" ) || ((''==this.A38BR_Comorbidity_Hypertension)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
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
   this.Valid_Br_comorbidity_diabetes=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_COMORBIDITY_DIABETES");
         this.AnyError  = 0;
         if ( ! ( ( this.A39BR_Comorbidity_Diabetes == "鍚? ) || ( this.A39BR_Comorbidity_Diabetes == "鏄? ) || ( this.A39BR_Comorbidity_Diabetes == "涓嶈" ) || ((''==this.A39BR_Comorbidity_Diabetes)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
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
   this.Valid_Br_comorbidity_chd=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_COMORBIDITY_CHD");
         this.AnyError  = 0;
         if ( ! ( ( this.A40BR_Comorbidity_CHD == "鍚? ) || ( this.A40BR_Comorbidity_CHD == "鏄? ) || ( this.A40BR_Comorbidity_CHD == "涓嶈" ) || ((''==this.A40BR_Comorbidity_CHD)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
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
   this.Valid_Br_comorbidity_hapetitis=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_COMORBIDITY_HAPETITIS");
         this.AnyError  = 0;
         if ( ! ( ( this.A41BR_Comorbidity_Hapetitis == "鍚? ) || ( this.A41BR_Comorbidity_Hapetitis == "鏄? ) || ( this.A41BR_Comorbidity_Hapetitis == "涓嶈" ) || ((''==this.A41BR_Comorbidity_Hapetitis)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟借秴鐣?);
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
   this.Valid_Br_comorbidity_tb=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_COMORBIDITY_TB");
         this.AnyError  = 0;
         if ( ! ( ( this.A42BR_Comorbidity_TB == "鍚? ) || ( this.A42BR_Comorbidity_TB == "鏄? ) || ( this.A42BR_Comorbidity_TB == "涓嶈" ) || ((''==this.A42BR_Comorbidity_TB)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
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
   this.Valid_Br_comorbidity_kidneydisease=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_COMORBIDITY_KIDNEYDISEASE");
         this.AnyError  = 0;
         if ( ! ( ( this.A43BR_Comorbidity_KidneyDisease == "鍚? ) || ( this.A43BR_Comorbidity_KidneyDisease == "鏄? ) || ( this.A43BR_Comorbidity_KidneyDisease == "涓嶈" ) || ((''==this.A43BR_Comorbidity_KidneyDisease)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟借秴鐣?);
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
   this.Valid_Br_comorbidity_surgeryhistory=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_COMORBIDITY_SURGERYHISTORY");
         this.AnyError  = 0;
         if ( ! ( ( this.A44BR_Comorbidity_SurgeryHistory == "鍚? ) || ( this.A44BR_Comorbidity_SurgeryHistory == "鏄? ) || ( this.A44BR_Comorbidity_SurgeryHistory == "涓嶈" ) || ((''==this.A44BR_Comorbidity_SurgeryHistory)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
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
   this.Valid_Br_comorbidity_injuryhistory=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_COMORBIDITY_INJURYHISTORY");
         this.AnyError  = 0;
         if ( ! ( ( this.A45BR_Comorbidity_InjuryHistory == "鍚? ) || ( this.A45BR_Comorbidity_InjuryHistory == "鏄? ) || ( this.A45BR_Comorbidity_InjuryHistory == "涓嶈" ) || ((''==this.A45BR_Comorbidity_InjuryHistory)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
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
   this.Valid_Br_comorbidity_bloodhistory=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_COMORBIDITY_BLOODHISTORY");
         this.AnyError  = 0;
         if ( ! ( ( this.A46BR_Comorbidity_BloodHistory == "鍚? ) || ( this.A46BR_Comorbidity_BloodHistory == "鏄? ) || ( this.A46BR_Comorbidity_BloodHistory == "涓嶈" ) || ((''==this.A46BR_Comorbidity_BloodHistory)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
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
   this.Valid_Br_comorbidity_allergy=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_COMORBIDITY_ALLERGY");
         this.AnyError  = 0;
         if ( ! ( ( this.A47BR_Comorbidity_allergy == "鍚? ) || ( this.A47BR_Comorbidity_allergy == "鏄? ) || ( this.A47BR_Comorbidity_allergy == "涓嶈" ) || ((''==this.A47BR_Comorbidity_allergy)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
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
   this.e12092_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130910_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140910_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86];
   this.GXLastCtrlId =86;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鍩虹淇℃伅", "str");
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
   GXValidFnc[25]={ id:25 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[25],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 25 , function() {
   });
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id:32 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_comorbidity_hypertension,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_HYPERTENSION",gxz:"Z38BR_Comorbidity_Hypertension",gxold:"O38BR_Comorbidity_Hypertension",gxvar:"A38BR_Comorbidity_Hypertension",ucs:[],op:[32],ip:[32],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A38BR_Comorbidity_Hypertension=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z38BR_Comorbidity_Hypertension=Value},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_HYPERTENSION",gx.O.A38BR_Comorbidity_Hypertension);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A38BR_Comorbidity_Hypertension=this.val()},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_HYPERTENSION")},nac:gx.falseFn};
   this.declareDomainHdlr( 32 , function() {
   });
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_comorbidity_diabetes,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_DIABETES",gxz:"Z39BR_Comorbidity_Diabetes",gxold:"O39BR_Comorbidity_Diabetes",gxvar:"A39BR_Comorbidity_Diabetes",ucs:[],op:[37],ip:[37],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A39BR_Comorbidity_Diabetes=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z39BR_Comorbidity_Diabetes=Value},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_DIABETES",gx.O.A39BR_Comorbidity_Diabetes);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A39BR_Comorbidity_Diabetes=this.val()},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_DIABETES")},nac:gx.falseFn};
   this.declareDomainHdlr( 37 , function() {
   });
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id:41 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_comorbidity_chd,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_CHD",gxz:"Z40BR_Comorbidity_CHD",gxold:"O40BR_Comorbidity_CHD",gxvar:"A40BR_Comorbidity_CHD",ucs:[],op:[41],ip:[41],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A40BR_Comorbidity_CHD=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z40BR_Comorbidity_CHD=Value},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_CHD",gx.O.A40BR_Comorbidity_CHD);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A40BR_Comorbidity_CHD=this.val()},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_CHD")},nac:gx.falseFn};
   this.declareDomainHdlr( 41 , function() {
   });
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_comorbidity_hapetitis,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_HAPETITIS",gxz:"Z41BR_Comorbidity_Hapetitis",gxold:"O41BR_Comorbidity_Hapetitis",gxvar:"A41BR_Comorbidity_Hapetitis",ucs:[],op:[46],ip:[46],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A41BR_Comorbidity_Hapetitis=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z41BR_Comorbidity_Hapetitis=Value},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_HAPETITIS",gx.O.A41BR_Comorbidity_Hapetitis);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A41BR_Comorbidity_Hapetitis=this.val()},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_HAPETITIS")},nac:gx.falseFn};
   this.declareDomainHdlr( 46 , function() {
   });
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_comorbidity_tb,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_TB",gxz:"Z42BR_Comorbidity_TB",gxold:"O42BR_Comorbidity_TB",gxvar:"A42BR_Comorbidity_TB",ucs:[],op:[50],ip:[50],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A42BR_Comorbidity_TB=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z42BR_Comorbidity_TB=Value},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_TB",gx.O.A42BR_Comorbidity_TB);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A42BR_Comorbidity_TB=this.val()},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_TB")},nac:gx.falseFn};
   this.declareDomainHdlr( 50 , function() {
   });
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_comorbidity_kidneydisease,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_KIDNEYDISEASE",gxz:"Z43BR_Comorbidity_KidneyDisease",gxold:"O43BR_Comorbidity_KidneyDisease",gxvar:"A43BR_Comorbidity_KidneyDisease",ucs:[],op:[55],ip:[55],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A43BR_Comorbidity_KidneyDisease=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z43BR_Comorbidity_KidneyDisease=Value},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_KIDNEYDISEASE",gx.O.A43BR_Comorbidity_KidneyDisease);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A43BR_Comorbidity_KidneyDisease=this.val()},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_KIDNEYDISEASE")},nac:gx.falseFn};
   this.declareDomainHdlr( 55 , function() {
   });
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_comorbidity_surgeryhistory,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_SURGERYHISTORY",gxz:"Z44BR_Comorbidity_SurgeryHistory",gxold:"O44BR_Comorbidity_SurgeryHistory",gxvar:"A44BR_Comorbidity_SurgeryHistory",ucs:[],op:[59],ip:[59],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A44BR_Comorbidity_SurgeryHistory=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z44BR_Comorbidity_SurgeryHistory=Value},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_SURGERYHISTORY",gx.O.A44BR_Comorbidity_SurgeryHistory);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A44BR_Comorbidity_SurgeryHistory=this.val()},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_SURGERYHISTORY")},nac:gx.falseFn};
   this.declareDomainHdlr( 59 , function() {
   });
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"",grid:0};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_comorbidity_injuryhistory,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_INJURYHISTORY",gxz:"Z45BR_Comorbidity_InjuryHistory",gxold:"O45BR_Comorbidity_InjuryHistory",gxvar:"A45BR_Comorbidity_InjuryHistory",ucs:[],op:[64],ip:[64],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A45BR_Comorbidity_InjuryHistory=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z45BR_Comorbidity_InjuryHistory=Value},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_INJURYHISTORY",gx.O.A45BR_Comorbidity_InjuryHistory);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A45BR_Comorbidity_InjuryHistory=this.val()},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_INJURYHISTORY")},nac:gx.falseFn};
   this.declareDomainHdlr( 64 , function() {
   });
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_comorbidity_bloodhistory,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BLOODHISTORY",gxz:"Z46BR_Comorbidity_BloodHistory",gxold:"O46BR_Comorbidity_BloodHistory",gxvar:"A46BR_Comorbidity_BloodHistory",ucs:[],op:[68],ip:[68],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A46BR_Comorbidity_BloodHistory=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z46BR_Comorbidity_BloodHistory=Value},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_BLOODHISTORY",gx.O.A46BR_Comorbidity_BloodHistory);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A46BR_Comorbidity_BloodHistory=this.val()},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_BLOODHISTORY")},nac:gx.falseFn};
   this.declareDomainHdlr( 68 , function() {
   });
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id:73 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_comorbidity_allergy,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_ALLERGY",gxz:"Z47BR_Comorbidity_allergy",gxold:"O47BR_Comorbidity_allergy",gxvar:"A47BR_Comorbidity_allergy",ucs:[],op:[73],ip:[73],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A47BR_Comorbidity_allergy=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z47BR_Comorbidity_allergy=Value},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_ALLERGY",gx.O.A47BR_Comorbidity_allergy);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A47BR_Comorbidity_allergy=this.val()},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_ALLERGY")},nac:gx.falseFn};
   this.declareDomainHdlr( 73 , function() {
   });
   GXValidFnc[74]={ id: 74, fld:"",grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"",grid:0};
   GXValidFnc[78]={ id: 78, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id: 80, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[83]={ id: 83, fld:"",grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id: 85, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[86]={ id:86 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_comorbidityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITYID",gxz:"Z37BR_ComorbidityID",gxold:"O37BR_ComorbidityID",gxvar:"A37BR_ComorbidityID",ucs:[],op:[25,73,68,64,59,55,50,46,41,37,32],ip:[25,73,68,64,59,55,50,46,41,37,32,86],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A37BR_ComorbidityID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z37BR_ComorbidityID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_COMORBIDITYID",gx.O.A37BR_ComorbidityID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A37BR_ComorbidityID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_COMORBIDITYID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 86 , function() {
   });
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.A38BR_Comorbidity_Hypertension = "" ;
   this.Z38BR_Comorbidity_Hypertension = "" ;
   this.O38BR_Comorbidity_Hypertension = "" ;
   this.A39BR_Comorbidity_Diabetes = "" ;
   this.Z39BR_Comorbidity_Diabetes = "" ;
   this.O39BR_Comorbidity_Diabetes = "" ;
   this.A40BR_Comorbidity_CHD = "" ;
   this.Z40BR_Comorbidity_CHD = "" ;
   this.O40BR_Comorbidity_CHD = "" ;
   this.A41BR_Comorbidity_Hapetitis = "" ;
   this.Z41BR_Comorbidity_Hapetitis = "" ;
   this.O41BR_Comorbidity_Hapetitis = "" ;
   this.A42BR_Comorbidity_TB = "" ;
   this.Z42BR_Comorbidity_TB = "" ;
   this.O42BR_Comorbidity_TB = "" ;
   this.A43BR_Comorbidity_KidneyDisease = "" ;
   this.Z43BR_Comorbidity_KidneyDisease = "" ;
   this.O43BR_Comorbidity_KidneyDisease = "" ;
   this.A44BR_Comorbidity_SurgeryHistory = "" ;
   this.Z44BR_Comorbidity_SurgeryHistory = "" ;
   this.O44BR_Comorbidity_SurgeryHistory = "" ;
   this.A45BR_Comorbidity_InjuryHistory = "" ;
   this.Z45BR_Comorbidity_InjuryHistory = "" ;
   this.O45BR_Comorbidity_InjuryHistory = "" ;
   this.A46BR_Comorbidity_BloodHistory = "" ;
   this.Z46BR_Comorbidity_BloodHistory = "" ;
   this.O46BR_Comorbidity_BloodHistory = "" ;
   this.A47BR_Comorbidity_allergy = "" ;
   this.Z47BR_Comorbidity_allergy = "" ;
   this.O47BR_Comorbidity_allergy = "" ;
   this.A37BR_ComorbidityID = 0 ;
   this.Z37BR_ComorbidityID = 0 ;
   this.O37BR_ComorbidityID = 0 ;
   this.A85BR_Information_ID = 0 ;
   this.AV9WebSession = {} ;
   this.A37BR_ComorbidityID = 0 ;
   this.A487BR_Comorbidity_Hypertension_Code = "" ;
   this.A488BR_Comorbidity_Diabetes_Code = "" ;
   this.A489BR_Comorbidity_CHD_Code = "" ;
   this.A490BR_Comorbidity_Hapetitis_Code = "" ;
   this.A491BR_Comorbidity_TB_Code = "" ;
   this.A492BR_Comorbidity_KidneyDisease_Code = "" ;
   this.A493BR_Comorbidity_SurgeryHistory_Code = "" ;
   this.A494BR_Comorbidity_InjuryHistory_Code = "" ;
   this.A495BR_Comorbidity_BloodHistory_Code = "" ;
   this.A496BR_Comorbidity_allergy_Code = "" ;
   this.A19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.A38BR_Comorbidity_Hypertension = "" ;
   this.A39BR_Comorbidity_Diabetes = "" ;
   this.A40BR_Comorbidity_CHD = "" ;
   this.A41BR_Comorbidity_Hapetitis = "" ;
   this.A42BR_Comorbidity_TB = "" ;
   this.A43BR_Comorbidity_KidneyDisease = "" ;
   this.A44BR_Comorbidity_SurgeryHistory = "" ;
   this.A45BR_Comorbidity_InjuryHistory = "" ;
   this.A46BR_Comorbidity_BloodHistory = "" ;
   this.A47BR_Comorbidity_allergy = "" ;
   this.A259BR_Comorbidity_Others = "" ;
   this.A561BR_Comorbidity_HapetitisB = "" ;
   this.A562BR_Comorbidity_HapetitisB_Code = "" ;
   this.A563BR_Comorbidity_HapetitisC = "" ;
   this.A564BR_Comorbidity_HapetitisC_Code = "" ;
   this.A565BR_Comorbidity_LiverCirrhosis = "" ;
   this.A566BR_Comorbidity_LiverCirrhosis_Code = "" ;
   this.A567BR_Comorbidity_Druginducedliverinjury = "" ;
   this.A568BR_Comorbidity_Druginducedliverinjury_Code = "" ;
   this.Events = {"e12092_client": ["AFTER TRN", true] ,"e130910_client": ["ENTER", true] ,"e140910_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'A259BR_Comorbidity_Others',fld:'BR_COMORBIDITY_OTHERS',pic:''},{av:'A561BR_Comorbidity_HapetitisB',fld:'BR_COMORBIDITY_HAPETITISB',pic:''},{av:'A562BR_Comorbidity_HapetitisB_Code',fld:'BR_COMORBIDITY_HAPETITISB_CODE',pic:''},{av:'A563BR_Comorbidity_HapetitisC',fld:'BR_COMORBIDITY_HAPETITISC',pic:''},{av:'A564BR_Comorbidity_HapetitisC_Code',fld:'BR_COMORBIDITY_HAPETITISC_CODE',pic:''},{av:'A565BR_Comorbidity_LiverCirrhosis',fld:'BR_COMORBIDITY_LIVERCIRRHOSIS',pic:''},{av:'A566BR_Comorbidity_LiverCirrhosis_Code',fld:'BR_COMORBIDITY_LIVERCIRRHOSIS_CODE',pic:''},{av:'A567BR_Comorbidity_Druginducedliverinjury',fld:'BR_COMORBIDITY_DRUGINDUCEDLIVERINJURY',pic:''},{av:'A568BR_Comorbidity_Druginducedliverinjury_Code',fld:'BR_COMORBIDITY_DRUGINDUCEDLIVERINJURY_CODE',pic:''}],[]];
   this.EvtParms["START"] = [[],[]];
   this.EvtParms["AFTER TRN"] = [[],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("A487BR_Comorbidity_Hypertension_Code", "BR_COMORBIDITY_HYPERTENSION_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A488BR_Comorbidity_Diabetes_Code", "BR_COMORBIDITY_DIABETES_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A489BR_Comorbidity_CHD_Code", "BR_COMORBIDITY_CHD_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A490BR_Comorbidity_Hapetitis_Code", "BR_COMORBIDITY_HAPETITIS_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A491BR_Comorbidity_TB_Code", "BR_COMORBIDITY_TB_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A492BR_Comorbidity_KidneyDisease_Code", "BR_COMORBIDITY_KIDNEYDISEASE_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A493BR_Comorbidity_SurgeryHistory_Code", "BR_COMORBIDITY_SURGERYHISTORY_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A494BR_Comorbidity_InjuryHistory_Code", "BR_COMORBIDITY_INJURYHISTORY_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A495BR_Comorbidity_BloodHistory_Code", "BR_COMORBIDITY_BLOODHISTORY_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A496BR_Comorbidity_allergy_Code", "BR_COMORBIDITY_ALLERGY_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A259BR_Comorbidity_Others", "BR_COMORBIDITY_OTHERS", 0, "svchar", 255, 0);
   this.setVCMap("A561BR_Comorbidity_HapetitisB", "BR_COMORBIDITY_HAPETITISB", 0, "svchar", 40, 0);
   this.setVCMap("A562BR_Comorbidity_HapetitisB_Code", "BR_COMORBIDITY_HAPETITISB_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A563BR_Comorbidity_HapetitisC", "BR_COMORBIDITY_HAPETITISC", 0, "svchar", 40, 0);
   this.setVCMap("A564BR_Comorbidity_HapetitisC_Code", "BR_COMORBIDITY_HAPETITISC_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A565BR_Comorbidity_LiverCirrhosis", "BR_COMORBIDITY_LIVERCIRRHOSIS", 0, "svchar", 40, 0);
   this.setVCMap("A566BR_Comorbidity_LiverCirrhosis_Code", "BR_COMORBIDITY_LIVERCIRRHOSIS_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A567BR_Comorbidity_Druginducedliverinjury", "BR_COMORBIDITY_DRUGINDUCEDLIVERINJURY", 0, "svchar", 40, 0);
   this.setVCMap("A568BR_Comorbidity_Druginducedliverinjury_Code", "BR_COMORBIDITY_DRUGINDUCEDLIVERINJURY_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A85BR_Information_ID", "BR_INFORMATION_ID", 0, "int", 18, 0);
   this.setVCMap("A36BR_Information_PatientNo", "BR_INFORMATION_PATIENTNO", 0, "svchar", 2000, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.Initialize( );
});
gx.createParentObj(br_comorbidity);
