/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:57:43.38
*/
gx.evt.autoSkip = false;
gx.define('br_pathology_other', false, function () {
   this.ServerClass =  "br_pathology_other" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7BR_Pathology_OtherID=gx.fn.getIntegerValue("vBR_PATHOLOGY_OTHERID",',') ;
      this.AV13Insert_BR_PathologyID=gx.fn.getIntegerValue("vINSERT_BR_PATHOLOGYID",',') ;
      this.A509BR_Pathology_Other_AbnInd_Code=gx.fn.getControlValue("BR_PATHOLOGY_OTHER_ABNIND_CODE") ;
      this.AV19tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.A480BR_Pathology_Other_Bio_Code=gx.fn.getControlValue("BR_PATHOLOGY_OTHER_BIO_CODE") ;
      this.A481BR_Pathology_Other_BioNum_Code=gx.fn.getControlValue("BR_PATHOLOGY_OTHER_BIONUM_CODE") ;
      this.A482BR_Pathology_Other_BioQual_Code=gx.fn.getControlValue("BR_PATHOLOGY_OTHER_BIOQUAL_CODE") ;
      this.AV20Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_pathology_otherid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGY_OTHERID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_pathology_other_bio=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGY_OTHER_BIO");
         this.AnyError  = 0;
         try {
            gx.fn.setCtrlProperty("vBZNAME","Visible", (this.A289BR_Pathology_Other_Bio=="鍏跺畠") );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A289BR_Pathology_Other_Bio == "鍏跺畠" ) ) )
            {
               gx.fn.setCtrlProperty("BZNAME_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A289BR_Pathology_Other_Bio == "鍏跺畠" )
               {
                  gx.fn.setCtrlProperty("BZNAME_CELL","Class", "RequiredDataContentCell" );
               }
            }
         }
         catch(e){}
         if ( ((''==this.A289BR_Pathology_Other_Bio)) )
         {
            try {
               gxballoon.setError("鑲跨槫鏍囧織鐗╂槸蹇呴』濉啓鐨勩€?);
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
   this.Validv_Bzname=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vBZNAME");
         this.AnyError  = 0;
         if ( ( ( this.A289BR_Pathology_Other_Bio == "鍏跺畠" ) ) && ((''==this.AV15bzName)) )
         {
            try {
               gxballoon.setError("鍏跺畠鑲跨槫鏍囧織鐗╂槸蹇呭～鐨?);
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
   this.Valid_Br_pathology_other_abnind=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGY_OTHER_ABNIND");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_pathology_other_bioqual=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGY_OTHER_BIOQUAL");
         this.AnyError  = 0;
         try {
            gx.fn.setCtrlProperty("vVNAME","Visible", (this.A292BR_Pathology_Other_BioQual=="鍏跺畠") );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A292BR_Pathology_Other_BioQual == "鍏跺畠" ) ) )
            {
               gx.fn.setCtrlProperty("VNAME_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A292BR_Pathology_Other_BioQual == "鍏跺畠" )
               {
                  gx.fn.setCtrlProperty("VNAME_CELL","Class", "RequiredDataContentCell" );
               }
            }
         }
         catch(e){}
         if ( ((''==this.A292BR_Pathology_Other_BioQual)) )
         {
            try {
               gxballoon.setError("瀹氭€х粨鏋滄槸蹇呴』濉啓鐨勩€?);
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
         if ( ( ( this.A292BR_Pathology_Other_BioQual == "鍏跺畠" ) ) && ((''==this.AV17vname)) )
         {
            try {
               gxballoon.setError("鍏跺畠瀹氭€х粨鏋滄槸蹇呭～鐨?);
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
   this.Valid_Br_pathologyid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_pathologyid",["gx.num.urlDecimal(gx.O.A226BR_PathologyID,\',\',\'.\')"],[]);
      return true;
   }
   this.s112_client=function()
   {
      gx.fn.setCtrlProperty("vBZNAME","Visible", false );
      gx.fn.setCtrlProperty("BZNAME_CELL","Class", "Invisible" );
      gx.fn.setCtrlProperty("vVNAME","Visible", false );
      gx.fn.setCtrlProperty("VNAME_CELL","Class", "Invisible" );
   };
   this.e110y35_client=function()
   {
      this.clearMessages();
      this.popupOpenUrl(gx.http.formatLink("beizhu.aspx",[]), []);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e130y2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e140y35_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e150y35_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,31,32,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,88,89,91,92,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108];
   this.GXLastCtrlId =108;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鐥呯悊瀛﹀叾瀹冧俊鎭?, "str");
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
   GXValidFnc[23]={ id: 23, fld:"TABLESPLITTEDBR_PATHOLOGY_OTHER_BIO",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_BIO", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"TABLEMERGEDBR_PATHOLOGY_OTHER_BIO",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id:32 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathology_other_bio,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BIO",gxz:"Z289BR_Pathology_Other_Bio",gxold:"O289BR_Pathology_Other_Bio",gxvar:"A289BR_Pathology_Other_Bio",ucs:[],op:[32],ip:[32],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A289BR_Pathology_Other_Bio=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z289BR_Pathology_Other_Bio=Value},v2c:function(){gx.fn.setComboBoxValue("BR_PATHOLOGY_OTHER_BIO",gx.O.A289BR_Pathology_Other_Bio)},c2v:function(){if(this.val()!==undefined)gx.O.A289BR_Pathology_Other_Bio=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_OTHER_BIO")},nac:gx.falseFn};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id:35 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Bzname,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vBZNAME",gxz:"ZV15bzName",gxold:"OV15bzName",gxvar:"AV15bzName",ucs:[],op:[35,32],ip:[35,32],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15bzName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV15bzName=Value},v2c:function(){gx.fn.setControlValue("vBZNAME",gx.O.AV15bzName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15bzName=this.val()},val:function(){return gx.fn.getControlValue("vBZNAME")},nac:gx.falseFn};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BIONUM",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_BIONUM", format:0,grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id:43 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BIONUM",gxz:"Z290BR_Pathology_Other_BioNum",gxold:"O290BR_Pathology_Other_BioNum",gxvar:"A290BR_Pathology_Other_BioNum",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A290BR_Pathology_Other_BioNum=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z290BR_Pathology_Other_BioNum=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PATHOLOGY_OTHER_BIONUM",gx.O.A290BR_Pathology_Other_BioNum,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A290BR_Pathology_Other_BioNum=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PATHOLOGY_OTHER_BIONUM",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 43 , function() {
   });
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BIONUMUNIT",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_BIONUMUNIT", format:0,grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BIONUMUNIT",gxz:"Z291BR_Pathology_Other_BioNumUnit",gxold:"O291BR_Pathology_Other_BioNumUnit",gxvar:"A291BR_Pathology_Other_BioNumUnit",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A291BR_Pathology_Other_BioNumUnit=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z291BR_Pathology_Other_BioNumUnit=Value},v2c:function(){gx.fn.setComboBoxValue("BR_PATHOLOGY_OTHER_BIONUMUNIT",gx.O.A291BR_Pathology_Other_BioNumUnit)},c2v:function(){if(this.val()!==undefined)gx.O.A291BR_Pathology_Other_BioNumUnit=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_OTHER_BIONUMUNIT")},nac:gx.falseFn};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_LOW",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id: 58, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_LOW", format:0,grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_LOW",gxz:"Z293BR_Pathology_Other_Low",gxold:"O293BR_Pathology_Other_Low",gxvar:"A293BR_Pathology_Other_Low",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A293BR_Pathology_Other_Low=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z293BR_Pathology_Other_Low=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PATHOLOGY_OTHER_LOW",gx.O.A293BR_Pathology_Other_Low,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A293BR_Pathology_Other_Low=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PATHOLOGY_OTHER_LOW",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 61 , function() {
   });
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_HIGH",grid:0};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id: 66, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_HIGH", format:0,grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_HIGH",gxz:"Z294BR_Pathology_Other_High",gxold:"O294BR_Pathology_Other_High",gxvar:"A294BR_Pathology_Other_High",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A294BR_Pathology_Other_High=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z294BR_Pathology_Other_High=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PATHOLOGY_OTHER_HIGH",gx.O.A294BR_Pathology_Other_High,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A294BR_Pathology_Other_High=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PATHOLOGY_OTHER_HIGH",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 69 , function() {
   });
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id: 72, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_ABNIND",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id: 74, fld:"",grid:0};
   GXValidFnc[75]={ id: 75, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_ABNIND", format:0,grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"",grid:0};
   GXValidFnc[78]={ id:78 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathology_other_abnind,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_ABNIND",gxz:"Z295BR_Pathology_Other_AbnInd",gxold:"O295BR_Pathology_Other_AbnInd",gxvar:"A295BR_Pathology_Other_AbnInd",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A295BR_Pathology_Other_AbnInd=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z295BR_Pathology_Other_AbnInd=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_OTHER_ABNIND",gx.O.A295BR_Pathology_Other_AbnInd,0)},c2v:function(){if(this.val()!==undefined)gx.O.A295BR_Pathology_Other_AbnInd=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_OTHER_ABNIND")},nac:gx.falseFn};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id: 80, fld:"TABLESPLITTEDBR_PATHOLOGY_OTHER_BIOQUAL",grid:0};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"",grid:0};
   GXValidFnc[83]={ id: 83, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_BIOQUAL", format:0,grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id: 85, fld:"TABLEMERGEDBR_PATHOLOGY_OTHER_BIOQUAL",grid:0};
   GXValidFnc[88]={ id: 88, fld:"",grid:0};
   GXValidFnc[89]={ id:89 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathology_other_bioqual,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BIOQUAL",gxz:"Z292BR_Pathology_Other_BioQual",gxold:"O292BR_Pathology_Other_BioQual",gxvar:"A292BR_Pathology_Other_BioQual",ucs:[],op:[89],ip:[89],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A292BR_Pathology_Other_BioQual=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z292BR_Pathology_Other_BioQual=Value},v2c:function(){gx.fn.setComboBoxValue("BR_PATHOLOGY_OTHER_BIOQUAL",gx.O.A292BR_Pathology_Other_BioQual)},c2v:function(){if(this.val()!==undefined)gx.O.A292BR_Pathology_Other_BioQual=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_OTHER_BIOQUAL")},nac:gx.falseFn};
   GXValidFnc[91]={ id: 91, fld:"",grid:0};
   GXValidFnc[92]={ id:92 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vname,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVNAME",gxz:"ZV17vname",gxold:"OV17vname",gxvar:"AV17vname",ucs:[],op:[92,89],ip:[92,89],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17vname=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV17vname=Value},v2c:function(){gx.fn.setControlValue("vVNAME",gx.O.AV17vname,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17vname=this.val()},val:function(){return gx.fn.getControlValue("vVNAME")},nac:gx.falseFn};
   GXValidFnc[94]={ id: 94, fld:"BTNBEIZHU",grid:0};
   GXValidFnc[95]={ id: 95, fld:"",grid:0};
   GXValidFnc[96]={ id: 96, fld:"",grid:0};
   GXValidFnc[97]={ id: 97, fld:"",grid:0};
   GXValidFnc[98]={ id: 98, fld:"",grid:0};
   GXValidFnc[99]={ id: 99, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[100]={ id: 100, fld:"",grid:0};
   GXValidFnc[101]={ id: 101, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[102]={ id: 102, fld:"",grid:0};
   GXValidFnc[103]={ id: 103, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[104]={ id: 104, fld:"",grid:0};
   GXValidFnc[105]={ id: 105, fld:"",grid:0};
   GXValidFnc[106]={ id: 106, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[107]={ id:107 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_pathology_otherid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHERID",gxz:"Z288BR_Pathology_OtherID",gxold:"O288BR_Pathology_OtherID",gxvar:"A288BR_Pathology_OtherID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A288BR_Pathology_OtherID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z288BR_Pathology_OtherID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_OTHERID",gx.O.A288BR_Pathology_OtherID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A288BR_Pathology_OtherID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_OTHERID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 107 , function() {
   });
   GXValidFnc[108]={ id:108 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathologyid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGYID",gxz:"Z226BR_PathologyID",gxold:"O226BR_PathologyID",gxvar:"A226BR_PathologyID",ucs:[],op:[],ip:[108],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A226BR_PathologyID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z226BR_PathologyID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGYID",gx.O.A226BR_PathologyID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A226BR_PathologyID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGYID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV13Insert_BR_PathologyID))}};
   this.declareDomainHdlr( 108 , function() {
   });
   this.A289BR_Pathology_Other_Bio = "" ;
   this.Z289BR_Pathology_Other_Bio = "" ;
   this.O289BR_Pathology_Other_Bio = "" ;
   this.AV15bzName = "" ;
   this.ZV15bzName = "" ;
   this.OV15bzName = "" ;
   this.A290BR_Pathology_Other_BioNum = 0 ;
   this.Z290BR_Pathology_Other_BioNum = 0 ;
   this.O290BR_Pathology_Other_BioNum = 0 ;
   this.A291BR_Pathology_Other_BioNumUnit = "" ;
   this.Z291BR_Pathology_Other_BioNumUnit = "" ;
   this.O291BR_Pathology_Other_BioNumUnit = "" ;
   this.A293BR_Pathology_Other_Low = 0 ;
   this.Z293BR_Pathology_Other_Low = 0 ;
   this.O293BR_Pathology_Other_Low = 0 ;
   this.A294BR_Pathology_Other_High = 0 ;
   this.Z294BR_Pathology_Other_High = 0 ;
   this.O294BR_Pathology_Other_High = 0 ;
   this.A295BR_Pathology_Other_AbnInd = "" ;
   this.Z295BR_Pathology_Other_AbnInd = "" ;
   this.O295BR_Pathology_Other_AbnInd = "" ;
   this.A292BR_Pathology_Other_BioQual = "" ;
   this.Z292BR_Pathology_Other_BioQual = "" ;
   this.O292BR_Pathology_Other_BioQual = "" ;
   this.AV17vname = "" ;
   this.ZV17vname = "" ;
   this.OV17vname = "" ;
   this.A288BR_Pathology_OtherID = 0 ;
   this.Z288BR_Pathology_OtherID = 0 ;
   this.O288BR_Pathology_OtherID = 0 ;
   this.A226BR_PathologyID = 0 ;
   this.Z226BR_PathologyID = 0 ;
   this.O226BR_PathologyID = 0 ;
   this.AV19tCurrentCode = "" ;
   this.AV8WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV9IsAuthorized = false ;
   this.AV20Pgmname = "" ;
   this.AV11TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV21GXV1 = 0 ;
   this.AV13Insert_BR_PathologyID = 0 ;
   this.AV18TempBoolean = false ;
   this.AV14TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV7BR_Pathology_OtherID = 0 ;
   this.AV12WebSession = {} ;
   this.A288BR_Pathology_OtherID = 0 ;
   this.A226BR_PathologyID = 0 ;
   this.AV15bzName = "" ;
   this.AV17vname = "" ;
   this.A509BR_Pathology_Other_AbnInd_Code = "" ;
   this.A289BR_Pathology_Other_Bio = "" ;
   this.A480BR_Pathology_Other_Bio_Code = "" ;
   this.A290BR_Pathology_Other_BioNum = 0 ;
   this.A481BR_Pathology_Other_BioNum_Code = "" ;
   this.A291BR_Pathology_Other_BioNumUnit = "" ;
   this.A292BR_Pathology_Other_BioQual = "" ;
   this.A482BR_Pathology_Other_BioQual_Code = "" ;
   this.A293BR_Pathology_Other_Low = 0 ;
   this.A294BR_Pathology_Other_High = 0 ;
   this.A295BR_Pathology_Other_AbnInd = "" ;
   this.Gx_mode = "" ;
   this.Events = {"e130y2_client": ["AFTER TRN", true] ,"e140y35_client": ["ENTER", true] ,"e150y35_client": ["CANCEL", true] ,"e110y35_client": ["'DOBEIZHU'", false]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Pathology_OtherID',fld:'vBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Pathology_OtherID',fld:'vBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A288BR_Pathology_OtherID',fld:'BR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV13Insert_BR_PathologyID',fld:'vINSERT_BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A480BR_Pathology_Other_Bio_Code',fld:'BR_PATHOLOGY_OTHER_BIO_CODE',pic:''},{av:'A481BR_Pathology_Other_BioNum_Code',fld:'BR_PATHOLOGY_OTHER_BIONUM_CODE',pic:''},{av:'A482BR_Pathology_Other_BioQual_Code',fld:'BR_PATHOLOGY_OTHER_BIOQUAL_CODE',pic:''}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV20Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV19tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV8WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV9IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV21GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV14TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV13Insert_BR_PathologyID',fld:'vINSERT_BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_OTHERID","Visible")',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Visible")',ctrl:'BR_PATHOLOGYID',prop:'Visible'},{av:'AV18TempBoolean',fld:'vTEMPBOOLEAN',pic:''},{ctrl:'BTNTRN_ENTER',prop:'Visible'},{ctrl:'BTNTRN_CANCEL',prop:'Visible'},{ctrl:'BTNTRN_DELETE',prop:'Visible'},{ctrl:'BTNBEIZHU',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vBZNAME","Visible")',ctrl:'vBZNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BZNAME_CELL","Class")',ctrl:'BZNAME_CELL',prop:'Class'},{av:'gx.fn.getCtrlProperty("vVNAME","Visible")',ctrl:'vVNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("VNAME_CELL","Class")',ctrl:'VNAME_CELL',prop:'Class'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EvtParms["'DOBEIZHU'"] = [[],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7BR_Pathology_OtherID", "vBR_PATHOLOGY_OTHERID", 0, "int", 18, 0);
   this.setVCMap("AV13Insert_BR_PathologyID", "vINSERT_BR_PATHOLOGYID", 0, "int", 18, 0);
   this.setVCMap("A509BR_Pathology_Other_AbnInd_Code", "BR_PATHOLOGY_OTHER_ABNIND_CODE", 0, "svchar", 40, 0);
   this.setVCMap("AV19tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("A480BR_Pathology_Other_Bio_Code", "BR_PATHOLOGY_OTHER_BIO_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A481BR_Pathology_Other_BioNum_Code", "BR_PATHOLOGY_OTHER_BIONUM_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A482BR_Pathology_Other_BioQual_Code", "BR_PATHOLOGY_OTHER_BIOQUAL_CODE", 0, "svchar", 40, 0);
   this.setVCMap("AV20Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV11TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_pathology_other);
