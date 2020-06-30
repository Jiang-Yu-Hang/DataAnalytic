/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:42:11.42
*/
gx.evt.autoSkip = false;
gx.define('br_procedureww', false, function () {
   this.ServerClass =  "br_procedureww" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV32TFBR_Procedure_PXSurgery_Sels=gx.fn.getControlValue("vTFBR_PROCEDURE_PXSURGERY_SELS") ;
      this.AV40TFBR_Procedure_PXRadiotherapy_Sels=gx.fn.getControlValue("vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS") ;
      this.AV124Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV75IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV77IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV78IsAuthorized_BR_Information_PatientNo=gx.fn.getControlValue("vISAUTHORIZED_BR_INFORMATION_PATIENTNO") ;
      this.A85BR_Information_ID=gx.fn.getIntegerValue("BR_INFORMATION_ID",',') ;
      this.AV32TFBR_Procedure_PXSurgery_Sels=gx.fn.getControlValue("vTFBR_PROCEDURE_PXSURGERY_SELS") ;
      this.AV40TFBR_Procedure_PXRadiotherapy_Sels=gx.fn.getControlValue("vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS") ;
      this.AV124Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV75IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV77IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV78IsAuthorized_BR_Information_PatientNo=gx.fn.getControlValue("vISAUTHORIZED_BR_INFORMATION_PATIENTNO") ;
   };
   this.Valid_Br_encounterid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(28) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTERID", gx.fn.currentGridRowImpl(28));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Tfbr_procedure_date=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_PROCEDURE_DATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV83TFBR_Procedure_Date)==0) || new gx.date.gxdate( this.AV83TFBR_Procedure_Date ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Procedure_Date瓒呯晫");
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
   this.Validv_Tfbr_procedure_date_to=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_PROCEDURE_DATE_TO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV84TFBR_Procedure_Date_To)==0) || new gx.date.gxdate( this.AV84TFBR_Procedure_Date_To ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Procedure_Date_To瓒呯晫");
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
   this.Validv_Ddo_br_procedure_dateauxdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_PROCEDURE_DATEAUXDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV85DDO_BR_Procedure_DateAuxDate)==0) || new gx.date.gxdate( this.AV85DDO_BR_Procedure_DateAuxDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Procedure_Date Aux Date瓒呯晫");
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
   this.Validv_Ddo_br_procedure_dateauxdateto=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_PROCEDURE_DATEAUXDATETO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV86DDO_BR_Procedure_DateAuxDateTo)==0) || new gx.date.gxdate( this.AV86DDO_BR_Procedure_DateAuxDateTo ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Procedure_Date Aux Date To瓒呯晫");
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
   this.Validv_Tfbr_procedure_radiodate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_PROCEDURE_RADIODATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV93TFBR_Procedure_RadioDate)==0) || new gx.date.gxdate( this.AV93TFBR_Procedure_RadioDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Procedure_Radio Date瓒呯晫");
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
   this.Validv_Tfbr_procedure_radiodate_to=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_PROCEDURE_RADIODATE_TO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV94TFBR_Procedure_RadioDate_To)==0) || new gx.date.gxdate( this.AV94TFBR_Procedure_RadioDate_To ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Procedure_Radio Date_To瓒呯晫");
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
   this.Validv_Ddo_br_procedure_radiodateauxdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_PROCEDURE_RADIODATEAUXDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV95DDO_BR_Procedure_RadioDateAuxDate)==0) || new gx.date.gxdate( this.AV95DDO_BR_Procedure_RadioDateAuxDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Procedure_Radio Date Aux Date瓒呯晫");
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
   this.Validv_Ddo_br_procedure_radiodateauxdateto=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_PROCEDURE_RADIODATEAUXDATETO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV96DDO_BR_Procedure_RadioDateAuxDateTo)==0) || new gx.date.gxdate( this.AV96DDO_BR_Procedure_RadioDateAuxDateTo ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Procedure_Radio Date Aux Date To瓒呯晫");
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
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_BR_PROCEDUREIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_ENCOUNTERIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_BR_PROCEDURE_PXIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 5 )
      {
         this.DDO_BR_PROCEDURE_PXSURGERYContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 6 )
      {
         this.DDO_BR_PROCEDURE_DATEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 7 )
      {
         this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 8 )
      {
         this.DDO_BR_PROCEDURE_RADIODATEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 9 )
      {
         this.DDO_BR_PROCEDURE_RADIOTIMEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_PROCEDUREIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTERIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus =  ""  ;
      this.DDO_BR_PROCEDURE_PXIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_PROCEDURE_PXSURGERYContainer.SortedStatus =  ""  ;
      this.DDO_BR_PROCEDURE_DATEContainer.SortedStatus =  ""  ;
      this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SortedStatus =  ""  ;
      this.DDO_BR_PROCEDURE_RADIODATEContainer.SortedStatus =  ""  ;
      this.DDO_BR_PROCEDURE_RADIOTIMEContainer.SortedStatus =  ""  ;
   };
   this.e113o2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e123o2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e133o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDUREID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e143o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e153o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e163o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDURE_PXID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e173o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDURE_PXSURGERY.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e183o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDURE_DATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e193o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDURE_PXRADIOTHERAPY.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e203o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDURE_RADIODATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e213o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDURE_RADIOTIME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e223o2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e263o2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e273o2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,49,51,53,55,57,59,61,63,65,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88];
   this.GXLastCtrlId =88;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",28,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_procedureww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",29,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",30,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",31,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(139,32,"BR_PROCEDUREID","","","BR_ProcedureID","int",0,"px",18,18,"right",null,[],139,"BR_ProcedureID",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(19,33,"BR_ENCOUNTERID","","","BR_EncounterID","int",0,"px",18,18,"right",null,[],19,"BR_EncounterID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(36,34,"BR_INFORMATION_PATIENTNO","","","BR_Information_PatientNo","svchar",410,"px",2000,80,"left",null,[],36,"BR_Information_PatientNo",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(140,35,"BR_PROCEDURE_PXID","","","BR_Procedure_PXID","int",0,"px",10,10,"right",null,[],140,"BR_Procedure_PXID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addComboBox(141,36,"BR_PROCEDURE_PXSURGERY","","BR_Procedure_PXSurgery","svchar",null,0,true,false,0,"px","WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(266,37,"BR_PROCEDURE_DATE","","","BR_Procedure_Date","date",0,"px",10,10,"right",null,[],266,"BR_Procedure_Date",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addComboBox(143,38,"BR_PROCEDURE_PXRADIOTHERAPY","","BR_Procedure_PXRadiotherapy","svchar",null,0,true,false,0,"px","WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(268,39,"BR_PROCEDURE_RADIODATE","","","BR_Procedure_RadioDate","date",0,"px",10,10,"right",null,[],268,"BR_Procedure_RadioDate",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(269,40,"BR_PROCEDURE_RADIOTIME","","","BR_Procedure_RadioTime","decimal",0,"px",15,15,"right",null,[],269,"BR_Procedure_RadioTime",true,5,false,false,"Attribute",1,"WWColumn hidden-xs");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.DVPANEL_TABLEHEADERContainer = gx.uc.getNew(this, 10, 0, "BootstrapPanel", "DVPANEL_TABLEHEADERContainer", "Dvpanel_tableheader", "DVPANEL_TABLEHEADER");
   var DVPANEL_TABLEHEADERContainer = this.DVPANEL_TABLEHEADERContainer;
   DVPANEL_TABLEHEADERContainer.setProp("Class", "Class", "", "char");
   DVPANEL_TABLEHEADERContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_TABLEHEADERContainer.setProp("Width", "Width", "100%", "str");
   DVPANEL_TABLEHEADERContainer.setProp("Height", "Height", "100", "str");
   DVPANEL_TABLEHEADERContainer.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Cls", "Cls", "PanelNoHeader", "str");
   DVPANEL_TABLEHEADERContainer.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Title", "Title", "閫夐」", "str");
   DVPANEL_TABLEHEADERContainer.setProp("Collapsible", "Collapsible", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("IconPosition", "Iconposition", "left", "str");
   DVPANEL_TABLEHEADERContainer.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Visible", "Visible", true, "bool");
   DVPANEL_TABLEHEADERContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_TABLEHEADERContainer);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 44, 29, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
   var GRIDPAGINATIONBARContainer = this.GRIDPAGINATIONBARContainer;
   GRIDPAGINATIONBARContainer.setProp("Enabled", "Enabled", true, "boolean");
   GRIDPAGINATIONBARContainer.setProp("Class", "Class", "PaginationBar", "str");
   GRIDPAGINATIONBARContainer.setProp("ShowFirst", "Showfirst", false, "bool");
   GRIDPAGINATIONBARContainer.setProp("ShowPrevious", "Showprevious", true, "bool");
   GRIDPAGINATIONBARContainer.setProp("ShowNext", "Shownext", true, "bool");
   GRIDPAGINATIONBARContainer.setProp("ShowLast", "Showlast", false, "bool");
   GRIDPAGINATIONBARContainer.setProp("PagesToShow", "Pagestoshow", 5, "num");
   GRIDPAGINATIONBARContainer.setProp("PagingButtonsPosition", "Pagingbuttonsposition", "Right", "str");
   GRIDPAGINATIONBARContainer.setProp("PagingCaptionPosition", "Pagingcaptionposition", "Left", "str");
   GRIDPAGINATIONBARContainer.setProp("EmptyGridClass", "Emptygridclass", "PaginationBarEmptyGrid", "str");
   GRIDPAGINATIONBARContainer.setProp("SelectedPage", "Selectedpage", "", "char");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageSelector", "Rowsperpageselector", true, "bool");
   GRIDPAGINATIONBARContainer.setDynProp("RowsPerPageSelectedValue", "Rowsperpageselectedvalue", 10, "num");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageOptions", "Rowsperpageoptions", "5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50", "str");
   GRIDPAGINATIONBARContainer.setProp("First", "First", "First", "str");
   GRIDPAGINATIONBARContainer.setProp("Previous", "Previous", "WWP_PagingPreviousCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("Next", "Next", "WWP_PagingNextCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("Last", "Last", "Last", "str");
   GRIDPAGINATIONBARContainer.setProp("Caption", "Caption", "<CURRENT_PAGE>椤?<TOTAL_PAGES>椤?璁板綍锛?TOTAL_RECORDS>鏉?, "str");
   GRIDPAGINATIONBARContainer.setProp("EmptyGridCaption", "Emptygridcaption", "WWP_PagingEmptyGridCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageCaption", "Rowsperpagecaption", "WWP_PagingRowsPerPage", "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV70GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV70GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV70GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV72GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV72GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV72GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV71GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV71GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV71GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e113o2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e123o2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_PROCEDUREIDContainer = gx.uc.getNew(this, 48, 29, "BootstrapDropDownOptions", "DDO_BR_PROCEDUREIDContainer", "Ddo_br_procedureid", "DDO_BR_PROCEDUREID");
   var DDO_BR_PROCEDUREIDContainer = this.DDO_BR_PROCEDUREIDContainer;
   DDO_BR_PROCEDUREIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDUREIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDUREIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDUREIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDUREIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDUREIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDUREIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PROCEDUREIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_PROCEDUREIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_PROCEDUREIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_PROCEDUREIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_PROCEDUREIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDUREIDContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDUREIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDUREIDContainer.addV2CFunction('AV16BR_ProcedureIDTitleFilterData', "vBR_PROCEDUREIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDUREIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16BR_ProcedureIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDUREIDTITLEFILTERDATA",UC.ParentObject.AV16BR_ProcedureIDTitleFilterData); });
   DDO_BR_PROCEDUREIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDUREIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDUREIDContainer.addEventHandler("OnOptionClicked", this.e133o2_client);
   this.setUserControl(DDO_BR_PROCEDUREIDContainer);
   this.DDO_BR_ENCOUNTERIDContainer = gx.uc.getNew(this, 50, 49, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTERIDContainer", "Ddo_br_encounterid", "DDO_BR_ENCOUNTERID");
   var DDO_BR_ENCOUNTERIDContainer = this.DDO_BR_ENCOUNTERIDContainer;
   DDO_BR_ENCOUNTERIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTERIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTERIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTERIDContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTERIDContainer.addV2CFunction('AV18BR_EncounterIDTitleFilterData', "vBR_ENCOUNTERIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV18BR_EncounterIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTERIDTITLEFILTERDATA",UC.ParentObject.AV18BR_EncounterIDTitleFilterData); });
   DDO_BR_ENCOUNTERIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTERIDContainer.addEventHandler("OnOptionClicked", this.e143o2_client);
   this.setUserControl(DDO_BR_ENCOUNTERIDContainer);
   this.DDO_BR_INFORMATION_PATIENTNOContainer = gx.uc.getNew(this, 52, 49, "BootstrapDropDownOptions", "DDO_BR_INFORMATION_PATIENTNOContainer", "Ddo_br_information_patientno", "DDO_BR_INFORMATION_PATIENTNO");
   var DDO_BR_INFORMATION_PATIENTNOContainer = this.DDO_BR_INFORMATION_PATIENTNOContainer;
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Class", "Class", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DataListProc", "Datalistproc", "BR_ProcedureWWGetFilterData", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_INFORMATION_PATIENTNOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_INFORMATION_PATIENTNOContainer.addV2CFunction('AV22BR_Information_PatientNoTitleFilterData', "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_INFORMATION_PATIENTNOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV22BR_Information_PatientNoTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_INFORMATION_PATIENTNOTITLEFILTERDATA",UC.ParentObject.AV22BR_Information_PatientNoTitleFilterData); });
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_INFORMATION_PATIENTNOContainer.addEventHandler("OnOptionClicked", this.e153o2_client);
   this.setUserControl(DDO_BR_INFORMATION_PATIENTNOContainer);
   this.DDO_BR_PROCEDURE_PXIDContainer = gx.uc.getNew(this, 54, 49, "BootstrapDropDownOptions", "DDO_BR_PROCEDURE_PXIDContainer", "Ddo_br_procedure_pxid", "DDO_BR_PROCEDURE_PXID");
   var DDO_BR_PROCEDURE_PXIDContainer = this.DDO_BR_PROCEDURE_PXIDContainer;
   DDO_BR_PROCEDURE_PXIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDURE_PXIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PROCEDURE_PXIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDURE_PXIDContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDURE_PXIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDURE_PXIDContainer.addV2CFunction('AV26BR_Procedure_PXIDTitleFilterData', "vBR_PROCEDURE_PXIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDURE_PXIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26BR_Procedure_PXIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDURE_PXIDTITLEFILTERDATA",UC.ParentObject.AV26BR_Procedure_PXIDTitleFilterData); });
   DDO_BR_PROCEDURE_PXIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDURE_PXIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDURE_PXIDContainer.addEventHandler("OnOptionClicked", this.e163o2_client);
   this.setUserControl(DDO_BR_PROCEDURE_PXIDContainer);
   this.DDO_BR_PROCEDURE_PXSURGERYContainer = gx.uc.getNew(this, 56, 49, "BootstrapDropDownOptions", "DDO_BR_PROCEDURE_PXSURGERYContainer", "Ddo_br_procedure_pxsurgery", "DDO_BR_PROCEDURE_PXSURGERY");
   var DDO_BR_PROCEDURE_PXSURGERYContainer = this.DDO_BR_PROCEDURE_PXSURGERYContainer;
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("DataListType", "Datalisttype", "FixedValues", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", true, "bool");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "鍚?鍚?鏄?鏄?涓嶈:涓嶈", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_FilterSelected", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDURE_PXSURGERYContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDURE_PXSURGERYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDURE_PXSURGERYContainer.addV2CFunction('AV30BR_Procedure_PXSurgeryTitleFilterData', "vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDURE_PXSURGERYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV30BR_Procedure_PXSurgeryTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA",UC.ParentObject.AV30BR_Procedure_PXSurgeryTitleFilterData); });
   DDO_BR_PROCEDURE_PXSURGERYContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDURE_PXSURGERYContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDURE_PXSURGERYContainer.addEventHandler("OnOptionClicked", this.e173o2_client);
   this.setUserControl(DDO_BR_PROCEDURE_PXSURGERYContainer);
   this.DDO_BR_PROCEDURE_DATEContainer = gx.uc.getNew(this, 58, 49, "BootstrapDropDownOptions", "DDO_BR_PROCEDURE_DATEContainer", "Ddo_br_procedure_date", "DDO_BR_PROCEDURE_DATE");
   var DDO_BR_PROCEDURE_DATEContainer = this.DDO_BR_PROCEDURE_DATEContainer;
   DDO_BR_PROCEDURE_DATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDURE_DATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDURE_DATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDURE_DATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDURE_DATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDURE_DATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDURE_DATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDURE_DATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDURE_DATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDURE_DATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PROCEDURE_DATEContainer.setProp("FilterType", "Filtertype", "Date", "str");
   DDO_BR_PROCEDURE_DATEContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_PROCEDURE_DATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_PROCEDURE_DATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_PROCEDURE_DATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_PROCEDURE_DATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDURE_DATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDURE_DATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDURE_DATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDURE_DATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_PROCEDURE_DATEContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_PROCEDURE_DATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_PROCEDURE_DATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PROCEDURE_DATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDURE_DATEContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDURE_DATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDURE_DATEContainer.addV2CFunction('AV82BR_Procedure_DateTitleFilterData', "vBR_PROCEDURE_DATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDURE_DATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV82BR_Procedure_DateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDURE_DATETITLEFILTERDATA",UC.ParentObject.AV82BR_Procedure_DateTitleFilterData); });
   DDO_BR_PROCEDURE_DATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDURE_DATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDURE_DATEContainer.addEventHandler("OnOptionClicked", this.e183o2_client);
   this.setUserControl(DDO_BR_PROCEDURE_DATEContainer);
   this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer = gx.uc.getNew(this, 60, 49, "BootstrapDropDownOptions", "DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer", "Ddo_br_procedure_pxradiotherapy", "DDO_BR_PROCEDURE_PXRADIOTHERAPY");
   var DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer = this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer;
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("DataListType", "Datalisttype", "FixedValues", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", true, "bool");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "鍚?鍚?鏄?鏄?涓嶈:涓嶈", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_FilterSelected", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.addV2CFunction('AV38BR_Procedure_PXRadiotherapyTitleFilterData', "vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV38BR_Procedure_PXRadiotherapyTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA",UC.ParentObject.AV38BR_Procedure_PXRadiotherapyTitleFilterData); });
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.addEventHandler("OnOptionClicked", this.e193o2_client);
   this.setUserControl(DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer);
   this.DDO_BR_PROCEDURE_RADIODATEContainer = gx.uc.getNew(this, 62, 49, "BootstrapDropDownOptions", "DDO_BR_PROCEDURE_RADIODATEContainer", "Ddo_br_procedure_radiodate", "DDO_BR_PROCEDURE_RADIODATE");
   var DDO_BR_PROCEDURE_RADIODATEContainer = this.DDO_BR_PROCEDURE_RADIODATEContainer;
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDURE_RADIODATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("FilterType", "Filtertype", "Date", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDURE_RADIODATEContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDURE_RADIODATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDURE_RADIODATEContainer.addV2CFunction('AV92BR_Procedure_RadioDateTitleFilterData', "vBR_PROCEDURE_RADIODATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDURE_RADIODATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV92BR_Procedure_RadioDateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDURE_RADIODATETITLEFILTERDATA",UC.ParentObject.AV92BR_Procedure_RadioDateTitleFilterData); });
   DDO_BR_PROCEDURE_RADIODATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDURE_RADIODATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDURE_RADIODATEContainer.addEventHandler("OnOptionClicked", this.e203o2_client);
   this.setUserControl(DDO_BR_PROCEDURE_RADIODATEContainer);
   this.DDO_BR_PROCEDURE_RADIOTIMEContainer = gx.uc.getNew(this, 64, 49, "BootstrapDropDownOptions", "DDO_BR_PROCEDURE_RADIOTIMEContainer", "Ddo_br_procedure_radiotime", "DDO_BR_PROCEDURE_RADIOTIME");
   var DDO_BR_PROCEDURE_RADIOTIMEContainer = this.DDO_BR_PROCEDURE_RADIOTIMEContainer;
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDURE_RADIOTIMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDURE_RADIOTIMEContainer.addV2CFunction('AV98BR_Procedure_RadioTimeTitleFilterData', "vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDURE_RADIOTIMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV98BR_Procedure_RadioTimeTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA",UC.ParentObject.AV98BR_Procedure_RadioTimeTitleFilterData); });
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDURE_RADIOTIMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDURE_RADIOTIMEContainer.addEventHandler("OnOptionClicked", this.e213o2_client);
   this.setUserControl(DDO_BR_PROCEDURE_RADIOTIMEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 66, 49, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
   var WORKWITHPLUSUTILITIES1Container = this.WORKWITHPLUSUTILITIES1Container;
   WORKWITHPLUSUTILITIES1Container.setProp("Class", "Class", "", "char");
   WORKWITHPLUSUTILITIES1Container.setProp("Enabled", "Enabled", true, "boolean");
   WORKWITHPLUSUTILITIES1Container.setProp("Width", "Width", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Height", "Height", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Visible", "Visible", true, "bool");
   WORKWITHPLUSUTILITIES1Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(WORKWITHPLUSUTILITIES1Container);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"HTML_DVPANEL_TABLEHEADER",grid:0};
   GXValidFnc[12]={ id: 12, fld:"LAYOUT_TABLEHEADER",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"TABLEHEADER",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"TABLEACTIONS",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"BTNINSERT",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV73Display",gxold:"OV73Display",gxvar:"AV73Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV73Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV73Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28),gx.O.AV73Display,gx.O.AV121Display_GXI)},c2v:function(){gx.O.AV121Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV73Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV121Display_GXI',nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV74Update",gxold:"OV74Update",gxvar:"AV74Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV74Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV74Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(28),gx.O.AV74Update,gx.O.AV122Update_GXI)},c2v:function(){gx.O.AV122Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV74Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV122Update_GXI',nac:gx.falseFn};
   GXValidFnc[31]={ id:31 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV76Delete",gxold:"OV76Delete",gxvar:"AV76Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV76Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV76Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(28),gx.O.AV76Delete,gx.O.AV123Delete_GXI)},c2v:function(){gx.O.AV123Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV76Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV123Delete_GXI',nac:gx.falseFn};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDUREID",gxz:"Z139BR_ProcedureID",gxold:"O139BR_ProcedureID",gxvar:"A139BR_ProcedureID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A139BR_ProcedureID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z139BR_ProcedureID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_PROCEDUREID",row || gx.fn.currentGridRowImpl(28),gx.O.A139BR_ProcedureID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A139BR_ProcedureID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_PROCEDUREID",row || gx.fn.currentGridRowImpl(28),',')},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(28),gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(28),',')},nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"svchar",len:2000,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A36BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z36BR_Information_PatientNo=Value},v2c:function(row){gx.fn.setGridControlValue("BR_INFORMATION_PATIENTNO",row || gx.fn.currentGridRowImpl(28),gx.O.A36BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A36BR_Information_PatientNo=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_INFORMATION_PATIENTNO",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_PXID",gxz:"Z140BR_Procedure_PXID",gxold:"O140BR_Procedure_PXID",gxvar:"A140BR_Procedure_PXID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A140BR_Procedure_PXID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z140BR_Procedure_PXID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_PROCEDURE_PXID",row || gx.fn.currentGridRowImpl(28),gx.O.A140BR_Procedure_PXID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A140BR_Procedure_PXID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_PROCEDURE_PXID",row || gx.fn.currentGridRowImpl(28),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_PXSURGERY",gxz:"Z141BR_Procedure_PXSurgery",gxold:"O141BR_Procedure_PXSurgery",gxvar:"A141BR_Procedure_PXSurgery",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A141BR_Procedure_PXSurgery=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z141BR_Procedure_PXSurgery=Value},v2c:function(row){gx.fn.setGridComboBoxValue("BR_PROCEDURE_PXSURGERY",row || gx.fn.currentGridRowImpl(28),gx.O.A141BR_Procedure_PXSurgery);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A141BR_Procedure_PXSurgery=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_PROCEDURE_PXSURGERY",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_DATE",gxz:"Z266BR_Procedure_Date",gxold:"O266BR_Procedure_Date",gxvar:"A266BR_Procedure_Date",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A266BR_Procedure_Date=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z266BR_Procedure_Date=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_PROCEDURE_DATE",row || gx.fn.currentGridRowImpl(28),gx.O.A266BR_Procedure_Date,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A266BR_Procedure_Date=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("BR_PROCEDURE_DATE",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_PXRADIOTHERAPY",gxz:"Z143BR_Procedure_PXRadiotherapy",gxold:"O143BR_Procedure_PXRadiotherapy",gxvar:"A143BR_Procedure_PXRadiotherapy",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A143BR_Procedure_PXRadiotherapy=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z143BR_Procedure_PXRadiotherapy=Value},v2c:function(row){gx.fn.setGridComboBoxValue("BR_PROCEDURE_PXRADIOTHERAPY",row || gx.fn.currentGridRowImpl(28),gx.O.A143BR_Procedure_PXRadiotherapy);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A143BR_Procedure_PXRadiotherapy=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_PROCEDURE_PXRADIOTHERAPY",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_RADIODATE",gxz:"Z268BR_Procedure_RadioDate",gxold:"O268BR_Procedure_RadioDate",gxvar:"A268BR_Procedure_RadioDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A268BR_Procedure_RadioDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z268BR_Procedure_RadioDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_PROCEDURE_RADIODATE",row || gx.fn.currentGridRowImpl(28),gx.O.A268BR_Procedure_RadioDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A268BR_Procedure_RadioDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("BR_PROCEDURE_RADIODATE",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_RADIOTIME",gxz:"Z269BR_Procedure_RadioTime",gxold:"O269BR_Procedure_RadioTime",gxvar:"A269BR_Procedure_RadioTime",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A269BR_Procedure_RadioTime=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z269BR_Procedure_RadioTime=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_PROCEDURE_RADIOTIME",row || gx.fn.currentGridRowImpl(28),gx.O.A269BR_Procedure_RadioTime,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A269BR_Procedure_RadioTime=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_PROCEDURE_RADIOTIME",row || gx.fn.currentGridRowImpl(28),',','.')},nac:gx.falseFn};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE",gxz:"ZV17ddo_BR_ProcedureIDTitleControlIdToReplace",gxold:"OV17ddo_BR_ProcedureIDTitleControlIdToReplace",gxvar:"AV17ddo_BR_ProcedureIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17ddo_BR_ProcedureIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV17ddo_BR_ProcedureIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE",gx.O.AV17ddo_BR_ProcedureIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17ddo_BR_ProcedureIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gxz:"ZV21ddo_BR_EncounterIDTitleControlIdToReplace",gxold:"OV21ddo_BR_EncounterIDTitleControlIdToReplace",gxvar:"AV21ddo_BR_EncounterIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21ddo_BR_EncounterIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV21ddo_BR_EncounterIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gx.O.AV21ddo_BR_EncounterIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21ddo_BR_EncounterIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE",gxz:"ZV25ddo_BR_Information_PatientNoTitleControlIdToReplace",gxold:"OV25ddo_BR_Information_PatientNoTitleControlIdToReplace",gxvar:"AV25ddo_BR_Information_PatientNoTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25ddo_BR_Information_PatientNoTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25ddo_BR_Information_PatientNoTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE",gx.O.AV25ddo_BR_Information_PatientNoTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25ddo_BR_Information_PatientNoTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE",gxz:"ZV29ddo_BR_Procedure_PXIDTitleControlIdToReplace",gxold:"OV29ddo_BR_Procedure_PXIDTitleControlIdToReplace",gxvar:"AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29ddo_BR_Procedure_PXIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE",gx.O.AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE",gxz:"ZV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace",gxold:"OV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace",gxvar:"AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE",gx.O.AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE",gxz:"ZV87ddo_BR_Procedure_DateTitleControlIdToReplace",gxold:"OV87ddo_BR_Procedure_DateTitleControlIdToReplace",gxvar:"AV87ddo_BR_Procedure_DateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV87ddo_BR_Procedure_DateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV87ddo_BR_Procedure_DateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE",gx.O.AV87ddo_BR_Procedure_DateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV87ddo_BR_Procedure_DateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE",gxz:"ZV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace",gxold:"OV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace",gxvar:"AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE",gx.O.AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE",gxz:"ZV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace",gxold:"OV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace",gxvar:"AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE",gx.O.AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE",gxz:"ZV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace",gxold:"OV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace",gxvar:"AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE",gx.O.AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDUREID",gxz:"ZV80TFBR_ProcedureID",gxold:"OV80TFBR_ProcedureID",gxvar:"AV80TFBR_ProcedureID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV80TFBR_ProcedureID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV80TFBR_ProcedureID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDUREID",gx.O.AV80TFBR_ProcedureID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV80TFBR_ProcedureID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PROCEDUREID",',')},nac:gx.falseFn};
   GXValidFnc[70]={ id:70 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDUREID_TO",gxz:"ZV81TFBR_ProcedureID_To",gxold:"OV81TFBR_ProcedureID_To",gxvar:"AV81TFBR_ProcedureID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV81TFBR_ProcedureID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV81TFBR_ProcedureID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDUREID_TO",gx.O.AV81TFBR_ProcedureID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV81TFBR_ProcedureID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PROCEDUREID_TO",',')},nac:gx.falseFn};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERID",gxz:"ZV19TFBR_EncounterID",gxold:"OV19TFBR_EncounterID",gxvar:"AV19TFBR_EncounterID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19TFBR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV19TFBR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERID",gx.O.AV19TFBR_EncounterID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19TFBR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTERID",',')},nac:gx.falseFn};
   GXValidFnc[72]={ id:72 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERID_TO",gxz:"ZV20TFBR_EncounterID_To",gxold:"OV20TFBR_EncounterID_To",gxvar:"AV20TFBR_EncounterID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20TFBR_EncounterID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV20TFBR_EncounterID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERID_TO",gx.O.AV20TFBR_EncounterID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20TFBR_EncounterID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTERID_TO",',')},nac:gx.falseFn};
   GXValidFnc[73]={ id:73 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_INFORMATION_PATIENTNO",gxz:"ZV23TFBR_Information_PatientNo",gxold:"OV23TFBR_Information_PatientNo",gxvar:"AV23TFBR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23TFBR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23TFBR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("vTFBR_INFORMATION_PATIENTNO",gx.O.AV23TFBR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23TFBR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[74]={ id:74 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_INFORMATION_PATIENTNO_SEL",gxz:"ZV24TFBR_Information_PatientNo_Sel",gxold:"OV24TFBR_Information_PatientNo_Sel",gxvar:"AV24TFBR_Information_PatientNo_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV24TFBR_Information_PatientNo_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24TFBR_Information_PatientNo_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_INFORMATION_PATIENTNO_SEL",gx.O.AV24TFBR_Information_PatientNo_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV24TFBR_Information_PatientNo_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_INFORMATION_PATIENTNO_SEL")},nac:gx.falseFn};
   GXValidFnc[75]={ id:75 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_PXID",gxz:"ZV27TFBR_Procedure_PXID",gxold:"OV27TFBR_Procedure_PXID",gxvar:"AV27TFBR_Procedure_PXID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27TFBR_Procedure_PXID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV27TFBR_Procedure_PXID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_PXID",gx.O.AV27TFBR_Procedure_PXID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27TFBR_Procedure_PXID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PROCEDURE_PXID",',')},nac:gx.falseFn};
   GXValidFnc[76]={ id:76 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_PXID_TO",gxz:"ZV28TFBR_Procedure_PXID_To",gxold:"OV28TFBR_Procedure_PXID_To",gxvar:"AV28TFBR_Procedure_PXID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV28TFBR_Procedure_PXID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV28TFBR_Procedure_PXID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_PXID_TO",gx.O.AV28TFBR_Procedure_PXID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV28TFBR_Procedure_PXID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PROCEDURE_PXID_TO",',')},nac:gx.falseFn};
   GXValidFnc[77]={ id:77 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_procedure_date,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_DATE",gxz:"ZV83TFBR_Procedure_Date",gxold:"OV83TFBR_Procedure_Date",gxvar:"AV83TFBR_Procedure_Date",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[77],ip:[77],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV83TFBR_Procedure_Date=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV83TFBR_Procedure_Date=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_DATE",gx.O.AV83TFBR_Procedure_Date,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV83TFBR_Procedure_Date=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vTFBR_PROCEDURE_DATE")},nac:gx.falseFn};
   GXValidFnc[78]={ id:78 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_procedure_date_to,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_DATE_TO",gxz:"ZV84TFBR_Procedure_Date_To",gxold:"OV84TFBR_Procedure_Date_To",gxvar:"AV84TFBR_Procedure_Date_To",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[78],ip:[78],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV84TFBR_Procedure_Date_To=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV84TFBR_Procedure_Date_To=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_DATE_TO",gx.O.AV84TFBR_Procedure_Date_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV84TFBR_Procedure_Date_To=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vTFBR_PROCEDURE_DATE_TO")},nac:gx.falseFn};
   GXValidFnc[79]={ id: 79, fld:"DDO_BR_PROCEDURE_DATEAUXDATES",grid:0};
   GXValidFnc[80]={ id:80 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_procedure_dateauxdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_DATEAUXDATE",gxz:"ZV85DDO_BR_Procedure_DateAuxDate",gxold:"OV85DDO_BR_Procedure_DateAuxDate",gxvar:"AV85DDO_BR_Procedure_DateAuxDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[80],ip:[80],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV85DDO_BR_Procedure_DateAuxDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV85DDO_BR_Procedure_DateAuxDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_DATEAUXDATE",gx.O.AV85DDO_BR_Procedure_DateAuxDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV85DDO_BR_Procedure_DateAuxDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_DATEAUXDATE")},nac:gx.falseFn};
   GXValidFnc[81]={ id:81 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_procedure_dateauxdateto,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_DATEAUXDATETO",gxz:"ZV86DDO_BR_Procedure_DateAuxDateTo",gxold:"OV86DDO_BR_Procedure_DateAuxDateTo",gxvar:"AV86DDO_BR_Procedure_DateAuxDateTo",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[81],ip:[81],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV86DDO_BR_Procedure_DateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV86DDO_BR_Procedure_DateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_DATEAUXDATETO",gx.O.AV86DDO_BR_Procedure_DateAuxDateTo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV86DDO_BR_Procedure_DateAuxDateTo=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_DATEAUXDATETO")},nac:gx.falseFn};
   GXValidFnc[82]={ id:82 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_procedure_radiodate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_RADIODATE",gxz:"ZV93TFBR_Procedure_RadioDate",gxold:"OV93TFBR_Procedure_RadioDate",gxvar:"AV93TFBR_Procedure_RadioDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[82],ip:[82],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV93TFBR_Procedure_RadioDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV93TFBR_Procedure_RadioDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_RADIODATE",gx.O.AV93TFBR_Procedure_RadioDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV93TFBR_Procedure_RadioDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vTFBR_PROCEDURE_RADIODATE")},nac:gx.falseFn};
   GXValidFnc[83]={ id:83 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_procedure_radiodate_to,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_RADIODATE_TO",gxz:"ZV94TFBR_Procedure_RadioDate_To",gxold:"OV94TFBR_Procedure_RadioDate_To",gxvar:"AV94TFBR_Procedure_RadioDate_To",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[83],ip:[83],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV94TFBR_Procedure_RadioDate_To=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV94TFBR_Procedure_RadioDate_To=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_RADIODATE_TO",gx.O.AV94TFBR_Procedure_RadioDate_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV94TFBR_Procedure_RadioDate_To=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vTFBR_PROCEDURE_RADIODATE_TO")},nac:gx.falseFn};
   GXValidFnc[84]={ id: 84, fld:"DDO_BR_PROCEDURE_RADIODATEAUXDATES",grid:0};
   GXValidFnc[85]={ id:85 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_procedure_radiodateauxdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_RADIODATEAUXDATE",gxz:"ZV95DDO_BR_Procedure_RadioDateAuxDate",gxold:"OV95DDO_BR_Procedure_RadioDateAuxDate",gxvar:"AV95DDO_BR_Procedure_RadioDateAuxDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[85],ip:[85],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV95DDO_BR_Procedure_RadioDateAuxDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV95DDO_BR_Procedure_RadioDateAuxDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_RADIODATEAUXDATE",gx.O.AV95DDO_BR_Procedure_RadioDateAuxDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV95DDO_BR_Procedure_RadioDateAuxDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_RADIODATEAUXDATE")},nac:gx.falseFn};
   GXValidFnc[86]={ id:86 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_procedure_radiodateauxdateto,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_RADIODATEAUXDATETO",gxz:"ZV96DDO_BR_Procedure_RadioDateAuxDateTo",gxold:"OV96DDO_BR_Procedure_RadioDateAuxDateTo",gxvar:"AV96DDO_BR_Procedure_RadioDateAuxDateTo",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[86],ip:[86],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV96DDO_BR_Procedure_RadioDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV96DDO_BR_Procedure_RadioDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_RADIODATEAUXDATETO",gx.O.AV96DDO_BR_Procedure_RadioDateAuxDateTo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV96DDO_BR_Procedure_RadioDateAuxDateTo=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_RADIODATEAUXDATETO")},nac:gx.falseFn};
   GXValidFnc[87]={ id:87 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_RADIOTIME",gxz:"ZV99TFBR_Procedure_RadioTime",gxold:"OV99TFBR_Procedure_RadioTime",gxvar:"AV99TFBR_Procedure_RadioTime",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV99TFBR_Procedure_RadioTime=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV99TFBR_Procedure_RadioTime=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_PROCEDURE_RADIOTIME",gx.O.AV99TFBR_Procedure_RadioTime,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV99TFBR_Procedure_RadioTime=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_PROCEDURE_RADIOTIME",',','.')},nac:gx.falseFn};
   GXValidFnc[88]={ id:88 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_RADIOTIME_TO",gxz:"ZV100TFBR_Procedure_RadioTime_To",gxold:"OV100TFBR_Procedure_RadioTime_To",gxvar:"AV100TFBR_Procedure_RadioTime_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV100TFBR_Procedure_RadioTime_To=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV100TFBR_Procedure_RadioTime_To=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_PROCEDURE_RADIOTIME_TO",gx.O.AV100TFBR_Procedure_RadioTime_To,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV100TFBR_Procedure_RadioTime_To=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_PROCEDURE_RADIOTIME_TO",',','.')},nac:gx.falseFn};
   this.ZV73Display = "" ;
   this.OV73Display = "" ;
   this.ZV74Update = "" ;
   this.OV74Update = "" ;
   this.ZV76Delete = "" ;
   this.OV76Delete = "" ;
   this.Z139BR_ProcedureID = 0 ;
   this.O139BR_ProcedureID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.Z36BR_Information_PatientNo = "" ;
   this.O36BR_Information_PatientNo = "" ;
   this.Z140BR_Procedure_PXID = 0 ;
   this.O140BR_Procedure_PXID = 0 ;
   this.Z141BR_Procedure_PXSurgery = "" ;
   this.O141BR_Procedure_PXSurgery = "" ;
   this.Z266BR_Procedure_Date = gx.date.nullDate() ;
   this.O266BR_Procedure_Date = gx.date.nullDate() ;
   this.Z143BR_Procedure_PXRadiotherapy = "" ;
   this.O143BR_Procedure_PXRadiotherapy = "" ;
   this.Z268BR_Procedure_RadioDate = gx.date.nullDate() ;
   this.O268BR_Procedure_RadioDate = gx.date.nullDate() ;
   this.Z269BR_Procedure_RadioTime = 0 ;
   this.O269BR_Procedure_RadioTime = 0 ;
   this.AV17ddo_BR_ProcedureIDTitleControlIdToReplace = "" ;
   this.ZV17ddo_BR_ProcedureIDTitleControlIdToReplace = "" ;
   this.OV17ddo_BR_ProcedureIDTitleControlIdToReplace = "" ;
   this.AV21ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.ZV21ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.OV21ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.AV25ddo_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.ZV25ddo_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.OV25ddo_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace = "" ;
   this.ZV29ddo_BR_Procedure_PXIDTitleControlIdToReplace = "" ;
   this.OV29ddo_BR_Procedure_PXIDTitleControlIdToReplace = "" ;
   this.AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = "" ;
   this.ZV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = "" ;
   this.OV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = "" ;
   this.AV87ddo_BR_Procedure_DateTitleControlIdToReplace = "" ;
   this.ZV87ddo_BR_Procedure_DateTitleControlIdToReplace = "" ;
   this.OV87ddo_BR_Procedure_DateTitleControlIdToReplace = "" ;
   this.AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = "" ;
   this.ZV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = "" ;
   this.OV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = "" ;
   this.AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace = "" ;
   this.ZV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace = "" ;
   this.OV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace = "" ;
   this.AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace = "" ;
   this.ZV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace = "" ;
   this.OV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV80TFBR_ProcedureID = 0 ;
   this.ZV80TFBR_ProcedureID = 0 ;
   this.OV80TFBR_ProcedureID = 0 ;
   this.AV81TFBR_ProcedureID_To = 0 ;
   this.ZV81TFBR_ProcedureID_To = 0 ;
   this.OV81TFBR_ProcedureID_To = 0 ;
   this.AV19TFBR_EncounterID = 0 ;
   this.ZV19TFBR_EncounterID = 0 ;
   this.OV19TFBR_EncounterID = 0 ;
   this.AV20TFBR_EncounterID_To = 0 ;
   this.ZV20TFBR_EncounterID_To = 0 ;
   this.OV20TFBR_EncounterID_To = 0 ;
   this.AV23TFBR_Information_PatientNo = "" ;
   this.ZV23TFBR_Information_PatientNo = "" ;
   this.OV23TFBR_Information_PatientNo = "" ;
   this.AV24TFBR_Information_PatientNo_Sel = "" ;
   this.ZV24TFBR_Information_PatientNo_Sel = "" ;
   this.OV24TFBR_Information_PatientNo_Sel = "" ;
   this.AV27TFBR_Procedure_PXID = 0 ;
   this.ZV27TFBR_Procedure_PXID = 0 ;
   this.OV27TFBR_Procedure_PXID = 0 ;
   this.AV28TFBR_Procedure_PXID_To = 0 ;
   this.ZV28TFBR_Procedure_PXID_To = 0 ;
   this.OV28TFBR_Procedure_PXID_To = 0 ;
   this.AV83TFBR_Procedure_Date = gx.date.nullDate() ;
   this.ZV83TFBR_Procedure_Date = gx.date.nullDate() ;
   this.OV83TFBR_Procedure_Date = gx.date.nullDate() ;
   this.AV84TFBR_Procedure_Date_To = gx.date.nullDate() ;
   this.ZV84TFBR_Procedure_Date_To = gx.date.nullDate() ;
   this.OV84TFBR_Procedure_Date_To = gx.date.nullDate() ;
   this.AV85DDO_BR_Procedure_DateAuxDate = gx.date.nullDate() ;
   this.ZV85DDO_BR_Procedure_DateAuxDate = gx.date.nullDate() ;
   this.OV85DDO_BR_Procedure_DateAuxDate = gx.date.nullDate() ;
   this.AV86DDO_BR_Procedure_DateAuxDateTo = gx.date.nullDate() ;
   this.ZV86DDO_BR_Procedure_DateAuxDateTo = gx.date.nullDate() ;
   this.OV86DDO_BR_Procedure_DateAuxDateTo = gx.date.nullDate() ;
   this.AV93TFBR_Procedure_RadioDate = gx.date.nullDate() ;
   this.ZV93TFBR_Procedure_RadioDate = gx.date.nullDate() ;
   this.OV93TFBR_Procedure_RadioDate = gx.date.nullDate() ;
   this.AV94TFBR_Procedure_RadioDate_To = gx.date.nullDate() ;
   this.ZV94TFBR_Procedure_RadioDate_To = gx.date.nullDate() ;
   this.OV94TFBR_Procedure_RadioDate_To = gx.date.nullDate() ;
   this.AV95DDO_BR_Procedure_RadioDateAuxDate = gx.date.nullDate() ;
   this.ZV95DDO_BR_Procedure_RadioDateAuxDate = gx.date.nullDate() ;
   this.OV95DDO_BR_Procedure_RadioDateAuxDate = gx.date.nullDate() ;
   this.AV96DDO_BR_Procedure_RadioDateAuxDateTo = gx.date.nullDate() ;
   this.ZV96DDO_BR_Procedure_RadioDateAuxDateTo = gx.date.nullDate() ;
   this.OV96DDO_BR_Procedure_RadioDateAuxDateTo = gx.date.nullDate() ;
   this.AV99TFBR_Procedure_RadioTime = 0 ;
   this.ZV99TFBR_Procedure_RadioTime = 0 ;
   this.OV99TFBR_Procedure_RadioTime = 0 ;
   this.AV100TFBR_Procedure_RadioTime_To = 0 ;
   this.ZV100TFBR_Procedure_RadioTime_To = 0 ;
   this.OV100TFBR_Procedure_RadioTime_To = 0 ;
   this.AV70GridCurrentPage = 0 ;
   this.AV68DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV17ddo_BR_ProcedureIDTitleControlIdToReplace = "" ;
   this.AV21ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.AV25ddo_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace = "" ;
   this.AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = "" ;
   this.AV87ddo_BR_Procedure_DateTitleControlIdToReplace = "" ;
   this.AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = "" ;
   this.AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace = "" ;
   this.AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV80TFBR_ProcedureID = 0 ;
   this.AV81TFBR_ProcedureID_To = 0 ;
   this.AV19TFBR_EncounterID = 0 ;
   this.AV20TFBR_EncounterID_To = 0 ;
   this.AV23TFBR_Information_PatientNo = "" ;
   this.AV24TFBR_Information_PatientNo_Sel = "" ;
   this.AV27TFBR_Procedure_PXID = 0 ;
   this.AV28TFBR_Procedure_PXID_To = 0 ;
   this.AV83TFBR_Procedure_Date = gx.date.nullDate() ;
   this.AV84TFBR_Procedure_Date_To = gx.date.nullDate() ;
   this.AV85DDO_BR_Procedure_DateAuxDate = gx.date.nullDate() ;
   this.AV86DDO_BR_Procedure_DateAuxDateTo = gx.date.nullDate() ;
   this.AV93TFBR_Procedure_RadioDate = gx.date.nullDate() ;
   this.AV94TFBR_Procedure_RadioDate_To = gx.date.nullDate() ;
   this.AV95DDO_BR_Procedure_RadioDateAuxDate = gx.date.nullDate() ;
   this.AV96DDO_BR_Procedure_RadioDateAuxDateTo = gx.date.nullDate() ;
   this.AV99TFBR_Procedure_RadioTime = 0 ;
   this.AV100TFBR_Procedure_RadioTime_To = 0 ;
   this.A85BR_Information_ID = 0 ;
   this.AV73Display = "" ;
   this.AV74Update = "" ;
   this.AV76Delete = "" ;
   this.A139BR_ProcedureID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.A140BR_Procedure_PXID = 0 ;
   this.A141BR_Procedure_PXSurgery = "" ;
   this.A266BR_Procedure_Date = gx.date.nullDate() ;
   this.A143BR_Procedure_PXRadiotherapy = "" ;
   this.A268BR_Procedure_RadioDate = gx.date.nullDate() ;
   this.A269BR_Procedure_RadioTime = 0 ;
   this.AV32TFBR_Procedure_PXSurgery_Sels = [ ] ;
   this.AV40TFBR_Procedure_PXRadiotherapy_Sels = [ ] ;
   this.AV124Pgmname = "" ;
   this.AV75IsAuthorized_Update = false ;
   this.AV77IsAuthorized_Delete = false ;
   this.AV78IsAuthorized_BR_Information_PatientNo = false ;
   this.Events = {"e113o2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e123o2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e133o2_client": ["DDO_BR_PROCEDUREID.ONOPTIONCLICKED", true] ,"e143o2_client": ["DDO_BR_ENCOUNTERID.ONOPTIONCLICKED", true] ,"e153o2_client": ["DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED", true] ,"e163o2_client": ["DDO_BR_PROCEDURE_PXID.ONOPTIONCLICKED", true] ,"e173o2_client": ["DDO_BR_PROCEDURE_PXSURGERY.ONOPTIONCLICKED", true] ,"e183o2_client": ["DDO_BR_PROCEDURE_DATE.ONOPTIONCLICKED", true] ,"e193o2_client": ["DDO_BR_PROCEDURE_PXRADIOTHERAPY.ONOPTIONCLICKED", true] ,"e203o2_client": ["DDO_BR_PROCEDURE_RADIODATE.ONOPTIONCLICKED", true] ,"e213o2_client": ["DDO_BR_PROCEDURE_RADIOTIME.ONOPTIONCLICKED", true] ,"e223o2_client": ["'DOINSERT'", true] ,"e263o2_client": ["ENTER", true] ,"e273o2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true}],[{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDUREID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_PXID","Title")',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{ctrl:'BR_PROCEDURE_PXSURGERY'},{ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_DATE","Title")',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{ctrl:'BR_PROCEDURE_PXRADIOTHERAPY'},{ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIODATE","Title")',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOTIME","Title")',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDUREID","Visible")',ctrl:'vTFBR_PROCEDUREID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDUREID_TO","Visible")',ctrl:'vTFBR_PROCEDUREID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERID","Visible")',ctrl:'vTFBR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERID_TO","Visible")',ctrl:'vTFBR_ENCOUNTERID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_INFORMATION_PATIENTNO","Visible")',ctrl:'vTFBR_INFORMATION_PATIENTNO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_INFORMATION_PATIENTNO_SEL","Visible")',ctrl:'vTFBR_INFORMATION_PATIENTNO_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_PXID","Visible")',ctrl:'vTFBR_PROCEDURE_PXID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_PXID_TO","Visible")',ctrl:'vTFBR_PROCEDURE_PXID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_DATE","Visible")',ctrl:'vTFBR_PROCEDURE_DATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_DATE_TO","Visible")',ctrl:'vTFBR_PROCEDURE_DATE_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_RADIODATE","Visible")',ctrl:'vTFBR_PROCEDURE_RADIODATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_RADIODATE_TO","Visible")',ctrl:'vTFBR_PROCEDURE_RADIODATE_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_RADIOTIME","Visible")',ctrl:'vTFBR_PROCEDURE_RADIOTIME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_RADIOTIME_TO","Visible")',ctrl:'vTFBR_PROCEDURE_RADIOTIME_TO',prop:'Visible'},{av:'this.DDO_BR_PROCEDUREIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDUREID',prop:'TitleControlIdToReplace'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTERIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTERID',prop:'TitleControlIdToReplace'},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.TitleControlIdToReplace',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'TitleControlIdToReplace'},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'TitleControlIdToReplace'},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'TitleControlIdToReplace'},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PROCEDURE_DATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'TitleControlIdToReplace'},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'TitleControlIdToReplace'},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'TitleControlIdToReplace'},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'TitleControlIdToReplace'},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV68DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.FilteredText_set',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'FilteredText_set'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.FilteredTextTo_set',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'FilteredTextTo_set'},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.FilteredText_set',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'FilteredText_set'},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.FilteredTextTo_set',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'FilteredTextTo_set'},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SelectedValue_set',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SelectedValue_set'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'this.DDO_BR_PROCEDURE_DATEContainer.FilteredText_set',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'FilteredText_set'},{av:'this.DDO_BR_PROCEDURE_DATEContainer.FilteredTextTo_set',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'FilteredTextTo_set'},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.SelectedValue_set',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SelectedValue_set'},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.FilteredText_set',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'FilteredText_set'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'FilteredTextTo_set'},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SelectedValue_set',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SelectedValue_set'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.FilteredText_set',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'FilteredText_set'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_set'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_set'},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PROCEDUREIDContainer.FilteredText_set',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredText_set'},{av:'this.DDO_BR_PROCEDUREIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_DATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_PROCEDUREID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'this.DDO_BR_PROCEDUREIDContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDUREID',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDUREIDContainer.FilteredText_get',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredText_get'},{av:'this.DDO_BR_PROCEDUREIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_DATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDUREID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_PXID","Title")',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{ctrl:'BR_PROCEDURE_PXSURGERY'},{ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_DATE","Title")',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{ctrl:'BR_PROCEDURE_PXRADIOTHERAPY'},{ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIODATE","Title")',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOTIME","Title")',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTERID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'this.DDO_BR_ENCOUNTERIDContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_DATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDUREID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_PXID","Title")',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{ctrl:'BR_PROCEDURE_PXSURGERY'},{ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_DATE","Title")',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{ctrl:'BR_PROCEDURE_PXRADIOTHERAPY'},{ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIODATE","Title")',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOTIME","Title")',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.ActiveEventKey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.FilteredText_get',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'FilteredText_get'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SelectedValue_get',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_DATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDUREID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_PXID","Title")',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{ctrl:'BR_PROCEDURE_PXSURGERY'},{ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_DATE","Title")',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{ctrl:'BR_PROCEDURE_PXRADIOTHERAPY'},{ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIODATE","Title")',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOTIME","Title")',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PROCEDURE_PXID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.FilteredText_get',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'FilteredText_get'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_DATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDUREID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_PXID","Title")',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{ctrl:'BR_PROCEDURE_PXSURGERY'},{ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_DATE","Title")',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{ctrl:'BR_PROCEDURE_PXRADIOTHERAPY'},{ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIODATE","Title")',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOTIME","Title")',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PROCEDURE_PXSURGERY.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.SelectedValue_get',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_DATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDUREID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_PXID","Title")',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{ctrl:'BR_PROCEDURE_PXSURGERY'},{ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_DATE","Title")',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{ctrl:'BR_PROCEDURE_PXRADIOTHERAPY'},{ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIODATE","Title")',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOTIME","Title")',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PROCEDURE_DATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'this.DDO_BR_PROCEDURE_DATEContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDURE_DATEContainer.FilteredText_get',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'FilteredText_get'},{av:'this.DDO_BR_PROCEDURE_DATEContainer.FilteredTextTo_get',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDURE_DATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDUREID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_PXID","Title")',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{ctrl:'BR_PROCEDURE_PXSURGERY'},{ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_DATE","Title")',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{ctrl:'BR_PROCEDURE_PXRADIOTHERAPY'},{ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIODATE","Title")',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOTIME","Title")',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PROCEDURE_PXRADIOTHERAPY.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SelectedValue_get',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_DATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDUREID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_PXID","Title")',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{ctrl:'BR_PROCEDURE_PXSURGERY'},{ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_DATE","Title")',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{ctrl:'BR_PROCEDURE_PXRADIOTHERAPY'},{ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIODATE","Title")',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOTIME","Title")',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PROCEDURE_RADIODATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.FilteredText_get',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'FilteredText_get'},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.FilteredTextTo_get',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_DATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDUREID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_PXID","Title")',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{ctrl:'BR_PROCEDURE_PXSURGERY'},{ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_DATE","Title")',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{ctrl:'BR_PROCEDURE_PXRADIOTHERAPY'},{ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIODATE","Title")',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOTIME","Title")',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PROCEDURE_RADIOTIME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.FilteredText_get',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'FilteredText_get'},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.FilteredTextTo_get',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIOTIMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXSURGERYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_DATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIODATEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDUREID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_PXID","Title")',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{ctrl:'BR_PROCEDURE_PXSURGERY'},{ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_DATE","Title")',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{ctrl:'BR_PROCEDURE_PXRADIOTHERAPY'},{ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIODATE","Title")',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOTIME","Title")',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'AV73Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV74Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV76Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Link")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV32TFBR_Procedure_PXSurgery_Sels", "vTFBR_PROCEDURE_PXSURGERY_SELS", 0, "Collsvchar", 0, 0);
   this.setVCMap("AV40TFBR_Procedure_PXRadiotherapy_Sels", "vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS", 0, "Collsvchar", 0, 0);
   this.setVCMap("AV124Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV75IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV77IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV78IsAuthorized_BR_Information_PatientNo", "vISAUTHORIZED_BR_INFORMATION_PATIENTNO", 0, "boolean", 4, 0);
   this.setVCMap("A85BR_Information_ID", "BR_INFORMATION_ID", 0, "int", 18, 0);
   this.setVCMap("AV32TFBR_Procedure_PXSurgery_Sels", "vTFBR_PROCEDURE_PXSURGERY_SELS", 0, "Collsvchar", 0, 0);
   this.setVCMap("AV40TFBR_Procedure_PXRadiotherapy_Sels", "vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS", 0, "Collsvchar", 0, 0);
   this.setVCMap("AV124Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV75IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV77IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV78IsAuthorized_BR_Information_PatientNo", "vISAUTHORIZED_BR_INFORMATION_PATIENTNO", 0, "boolean", 4, 0);
   this.setVCMap("AV32TFBR_Procedure_PXSurgery_Sels", "vTFBR_PROCEDURE_PXSURGERY_SELS", 0, "Collsvchar", 0, 0);
   this.setVCMap("AV40TFBR_Procedure_PXRadiotherapy_Sels", "vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS", 0, "Collsvchar", 0, 0);
   this.setVCMap("AV124Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV75IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV77IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV78IsAuthorized_BR_Information_PatientNo", "vISAUTHORIZED_BR_INFORMATION_PATIENTNO", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[67]);
   GridContainer.addRefreshingVar(this.GXValidFnc[68]);
   GridContainer.addRefreshingVar(this.GXValidFnc[69]);
   GridContainer.addRefreshingVar(this.GXValidFnc[70]);
   GridContainer.addRefreshingVar(this.GXValidFnc[71]);
   GridContainer.addRefreshingVar(this.GXValidFnc[72]);
   GridContainer.addRefreshingVar(this.GXValidFnc[73]);
   GridContainer.addRefreshingVar(this.GXValidFnc[74]);
   GridContainer.addRefreshingVar(this.GXValidFnc[75]);
   GridContainer.addRefreshingVar(this.GXValidFnc[76]);
   GridContainer.addRefreshingVar(this.GXValidFnc[77]);
   GridContainer.addRefreshingVar(this.GXValidFnc[78]);
   GridContainer.addRefreshingVar(this.GXValidFnc[82]);
   GridContainer.addRefreshingVar(this.GXValidFnc[83]);
   GridContainer.addRefreshingVar(this.GXValidFnc[87]);
   GridContainer.addRefreshingVar(this.GXValidFnc[88]);
   GridContainer.addRefreshingVar(this.GXValidFnc[49]);
   GridContainer.addRefreshingVar(this.GXValidFnc[51]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar(this.GXValidFnc[55]);
   GridContainer.addRefreshingVar(this.GXValidFnc[57]);
   GridContainer.addRefreshingVar(this.GXValidFnc[59]);
   GridContainer.addRefreshingVar(this.GXValidFnc[61]);
   GridContainer.addRefreshingVar(this.GXValidFnc[63]);
   GridContainer.addRefreshingVar(this.GXValidFnc[65]);
   GridContainer.addRefreshingVar({rfrVar:"AV32TFBR_Procedure_PXSurgery_Sels"});
   GridContainer.addRefreshingVar({rfrVar:"AV40TFBR_Procedure_PXRadiotherapy_Sels"});
   GridContainer.addRefreshingVar({rfrVar:"AV124Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV75IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV77IsAuthorized_Delete"});
   GridContainer.addRefreshingVar({rfrVar:"AV78IsAuthorized_BR_Information_PatientNo"});
   this.Initialize( );
});
gx.createParentObj(br_procedureww);
