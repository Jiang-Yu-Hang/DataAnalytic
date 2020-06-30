/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:6:21.33
*/
gx.evt.autoSkip = false;
gx.define('br_enteringsubmitdetail', false, function () {
   this.ServerClass =  "br_enteringsubmitdetail" ;
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
      this.AV70Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV20IsAuthorized_BR_Encounter_RefuseReason_Reason=gx.fn.getControlValue("vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON") ;
      this.AV13BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
      this.AV13BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
      this.AV70Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV20IsAuthorized_BR_Encounter_RefuseReason_Reason=gx.fn.getControlValue("vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON") ;
   };
   this.Validv_Br_encounterreason_vstatus=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vBR_ENCOUNTERREASON_VSTATUS");
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
      try {
         if(  gx.fn.currentGridRowImpl(17) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTERID", gx.fn.currentGridRowImpl(17));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Tfbr_encounter_refusereason_noapprovedate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV38TFBR_Encounter_RefuseReason_NoApproveDate)==0) || new gx.date.gxdate( this.AV38TFBR_Encounter_RefuseReason_NoApproveDate ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Encounter_Refuse Reason_No Approve Date瓒呯晫");
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
   this.Validv_Tfbr_encounter_refusereason_noapprovedate_to=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV39TFBR_Encounter_RefuseReason_NoApproveDate_To)==0) || new gx.date.gxdate( this.AV39TFBR_Encounter_RefuseReason_NoApproveDate_To ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Encounter_Refuse Reason_No Approve Date_To瓒呯晫");
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
   this.Validv_Ddo_br_encounter_refusereason_noapprovedateauxdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate)==0) || new gx.date.gxdate( this.AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Encounter_Refuse Reason_No Approve Date Aux Date瓒呯晫");
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
   this.Validv_Ddo_br_encounter_refusereason_noapprovedateauxdateto=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo)==0) || new gx.date.gxdate( this.AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Encounter_Refuse Reason_No Approve Date Aux Date To瓒呯晫");
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
   this.Validv_Tfbr_encounter_refusereason_fapprovedate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV54TFBR_Encounter_RefuseReason_FApproveDate)==0) || new gx.date.gxdate( this.AV54TFBR_Encounter_RefuseReason_FApproveDate ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Encounter_Refuse Reason_FApprove Date瓒呯晫");
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
   this.Validv_Tfbr_encounter_refusereason_fapprovedate_to=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV55TFBR_Encounter_RefuseReason_FApproveDate_To)==0) || new gx.date.gxdate( this.AV55TFBR_Encounter_RefuseReason_FApproveDate_To ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Encounter_Refuse Reason_FApprove Date_To瓒呯晫");
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
   this.Validv_Ddo_br_encounter_refusereason_fapprovedateauxdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate)==0) || new gx.date.gxdate( this.AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Encounter_Refuse Reason_FApprove Date Aux Date瓒呯晫");
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
   this.Validv_Ddo_br_encounter_refusereason_fapprovedateauxdateto=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATETO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo)==0) || new gx.date.gxdate( this.AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Encounter_Refuse Reason_FApprove Date Aux Date To瓒呯晫");
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
      this.s152_client();
      if ( this.AV26OrderedBy == 2 )
      {
         this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus =  (this.AV27OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV26OrderedBy == 1 )
      {
         this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus =  (this.AV27OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV26OrderedBy == 3 )
      {
         this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.SortedStatus =  (this.AV27OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV26OrderedBy == 4 )
      {
         this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.SortedStatus =  (this.AV27OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s152_client=function()
   {
      this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.SortedStatus =  ""  ;
   };
   this.e117d2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e127d2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e137d2_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e147d2_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e157d2_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_REFUSEREASON_FREASON.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e167d2_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e207d2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e217d2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,20,21,22,23,24,25,26,27,28,29,30,32,33,34,36,38,40,42,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59];
   this.GXLastCtrlId =59;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",17,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_enteringsubmitdetail",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addSingleLineEdit(348,18,"BR_ENCOUNTER_REFUSEREASONID","Reason ID","","BR_Encounter_RefuseReasonID","int",0,"px",18,18,"right",null,[],348,"BR_Encounter_RefuseReasonID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(19,19,"BR_ENCOUNTERID","灏辫瘖搴忓彿","","BR_EncounterID","int",0,"px",18,18,"right",null,[],19,"BR_EncounterID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(349,20,"BR_ENCOUNTER_REFUSEREASON_REASON","","","BR_Encounter_RefuseReason_Reason","svchar",0,"px",300,80,"left",null,[],349,"BR_Encounter_RefuseReason_Reason",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(350,21,"BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","","","BR_Encounter_RefuseReason_NoApproveDate","dtime",0,"px",19,19,"right",null,[],350,"BR_Encounter_RefuseReason_NoApproveDate",true,8,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addComboBox(351,22,"BR_ENCOUNTER_REFUSEREASON_STATUS","鍒濆涓嶉€氳繃鐘舵€?,"BR_Encounter_RefuseReason_Status","int",null,0,false,false,0,"px","WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(352,23,"BR_ENCOUNTER_REFUSEREASON_APPROVER","鍒濆鎶芥煡閫氳繃鎿嶄綔浜?,"","BR_Encounter_RefuseReason_Approver","svchar",0,"px",40,40,"left",null,[],352,"BR_Encounter_RefuseReason_Approver",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addCheckBox(353,24,"BR_ENCOUNTERREASON_ISAPPROVE","鏄惁鍒濆鎶芥煡","","BR_EncounterReason_IsApprove","boolean","true","false",null,false,false,0,"px","WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(85,25,"BR_INFORMATION_ID","鎮ｈ€呭熀鏈俊鎭富閿甀D","","BR_Information_ID","int",0,"px",18,18,"right",null,[],85,"BR_Information_ID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(355,26,"BR_ENCOUNTER_REFUSEREASON_FREASON","","","BR_Encounter_RefuseReason_FReason","svchar",0,"px",300,80,"left",null,[],355,"BR_Encounter_RefuseReason_FReason",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(354,27,"BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE","","","BR_Encounter_RefuseReason_FApproveDate","dtime",0,"px",19,19,"right",null,[],354,"BR_Encounter_RefuseReason_FApproveDate",true,8,false,false,"Attribute",1,"WWColumn");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 31, 11, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV17GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV17GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV17GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV19GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV19GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV19GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV18GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV18GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV18GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e117d2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e127d2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer = gx.uc.getNew(this, 35, 11, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer", "Ddo_br_encounter_refusereason_reason", "DDO_BR_ENCOUNTER_REFUSEREASON_REASON");
   var DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer = this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer;
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("DataListProc", "Datalistproc", "BR_EnteringSubmitDetailGetFilterData", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.addV2CFunction('AV43DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV43DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV43DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.addV2CFunction('AV33BR_Encounter_RefuseReason_ReasonTitleFilterData', "vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV33BR_Encounter_RefuseReason_ReasonTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA",UC.ParentObject.AV33BR_Encounter_RefuseReason_ReasonTitleFilterData); });
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.addEventHandler("OnOptionClicked", this.e137d2_client);
   this.setUserControl(DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer);
   this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer = gx.uc.getNew(this, 37, 11, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer", "Ddo_br_encounter_refusereason_noapprovedate", "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE");
   var DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer = this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer;
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("FilterType", "Filtertype", "Date", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.addV2CFunction('AV43DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV43DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV43DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.addV2CFunction('AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData', "vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA",UC.ParentObject.AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData); });
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.addEventHandler("OnOptionClicked", this.e147d2_client);
   this.setUserControl(DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer);
   this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer = gx.uc.getNew(this, 39, 11, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer", "Ddo_br_encounter_refusereason_freason", "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON");
   var DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer = this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer;
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("DataListProc", "Datalistproc", "BR_EnteringSubmitDetailGetFilterData", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.addV2CFunction('AV43DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV43DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV43DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.addV2CFunction('AV49BR_Encounter_RefuseReason_FReasonTitleFilterData', "vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV49BR_Encounter_RefuseReason_FReasonTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA",UC.ParentObject.AV49BR_Encounter_RefuseReason_FReasonTitleFilterData); });
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.addEventHandler("OnOptionClicked", this.e157d2_client);
   this.setUserControl(DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer);
   this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer = gx.uc.getNew(this, 41, 11, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer", "Ddo_br_encounter_refusereason_fapprovedate", "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE");
   var DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer = this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer;
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("FilterType", "Filtertype", "Date", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.addV2CFunction('AV43DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV43DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV43DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.addV2CFunction('AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData', "vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA",UC.ParentObject.AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData); });
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.addEventHandler("OnOptionClicked", this.e167d2_client);
   this.setUserControl(DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 43, 11, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[9]={ id: 9, fld:"",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id:11 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Br_encounterreason_vstatus,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vBR_ENCOUNTERREASON_VSTATUS",gxz:"ZV48BR_EncounterReason_vStatus",gxold:"OV48BR_EncounterReason_vStatus",gxvar:"AV48BR_EncounterReason_vStatus",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV48BR_EncounterReason_vStatus=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV48BR_EncounterReason_vStatus=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("vBR_ENCOUNTERREASON_VSTATUS",gx.O.AV48BR_EncounterReason_vStatus)},c2v:function(){if(this.val()!==undefined)gx.O.AV48BR_EncounterReason_vStatus=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vBR_ENCOUNTERREASON_VSTATUS",',')},nac:gx.falseFn};
   GXValidFnc[12]={ id: 12, fld:"",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[18]={ id:18 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:17,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_REFUSEREASONID",gxz:"Z348BR_Encounter_RefuseReasonID",gxold:"O348BR_Encounter_RefuseReasonID",gxvar:"A348BR_Encounter_RefuseReasonID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A348BR_Encounter_RefuseReasonID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z348BR_Encounter_RefuseReasonID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_REFUSEREASONID",row || gx.fn.currentGridRowImpl(17),gx.O.A348BR_Encounter_RefuseReasonID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A348BR_Encounter_RefuseReasonID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTER_REFUSEREASONID",row || gx.fn.currentGridRowImpl(17),',')},nac:gx.falseFn};
   GXValidFnc[19]={ id:19 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:17,gxgrid:this.GridContainer,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(17),gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(17),',')},nac:gx.falseFn};
   GXValidFnc[20]={ id:20 ,lvl:2,type:"svchar",len:300,dec:0,sign:false,ro:1,isacc:0,grid:17,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_REFUSEREASON_REASON",gxz:"Z349BR_Encounter_RefuseReason_Reason",gxold:"O349BR_Encounter_RefuseReason_Reason",gxvar:"A349BR_Encounter_RefuseReason_Reason",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A349BR_Encounter_RefuseReason_Reason=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z349BR_Encounter_RefuseReason_Reason=Value},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_REFUSEREASON_REASON",row || gx.fn.currentGridRowImpl(17),gx.O.A349BR_Encounter_RefuseReason_Reason,0)},c2v:function(){if(this.val()!==undefined)gx.O.A349BR_Encounter_RefuseReason_Reason=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_REFUSEREASON_REASON",row || gx.fn.currentGridRowImpl(17))},nac:gx.falseFn};
   GXValidFnc[21]={ id:21 ,lvl:2,type:"dtime",len:10,dec:8,sign:false,ro:1,isacc:0,grid:17,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE",gxz:"Z350BR_Encounter_RefuseReason_NoApproveDate",gxold:"O350BR_Encounter_RefuseReason_NoApproveDate",gxvar:"A350BR_Encounter_RefuseReason_NoApproveDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A350BR_Encounter_RefuseReason_NoApproveDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z350BR_Encounter_RefuseReason_NoApproveDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE",row || gx.fn.currentGridRowImpl(17),gx.O.A350BR_Encounter_RefuseReason_NoApproveDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A350BR_Encounter_RefuseReason_NoApproveDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE",row || gx.fn.currentGridRowImpl(17))},nac:gx.falseFn};
   GXValidFnc[22]={ id:22 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:17,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_REFUSEREASON_STATUS",gxz:"Z351BR_Encounter_RefuseReason_Status",gxold:"O351BR_Encounter_RefuseReason_Status",gxvar:"A351BR_Encounter_RefuseReason_Status",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A351BR_Encounter_RefuseReason_Status=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z351BR_Encounter_RefuseReason_Status=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridComboBoxValue("BR_ENCOUNTER_REFUSEREASON_STATUS",row || gx.fn.currentGridRowImpl(17),gx.O.A351BR_Encounter_RefuseReason_Status);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A351BR_Encounter_RefuseReason_Status=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTER_REFUSEREASON_STATUS",row || gx.fn.currentGridRowImpl(17),',')},nac:gx.falseFn};
   GXValidFnc[23]={ id:23 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:17,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_REFUSEREASON_APPROVER",gxz:"Z352BR_Encounter_RefuseReason_Approver",gxold:"O352BR_Encounter_RefuseReason_Approver",gxvar:"A352BR_Encounter_RefuseReason_Approver",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A352BR_Encounter_RefuseReason_Approver=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z352BR_Encounter_RefuseReason_Approver=Value},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_REFUSEREASON_APPROVER",row || gx.fn.currentGridRowImpl(17),gx.O.A352BR_Encounter_RefuseReason_Approver,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A352BR_Encounter_RefuseReason_Approver=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_REFUSEREASON_APPROVER",row || gx.fn.currentGridRowImpl(17))},nac:gx.falseFn};
   GXValidFnc[24]={ id:24 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:1,isacc:0,grid:17,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERREASON_ISAPPROVE",gxz:"Z353BR_EncounterReason_IsApprove",gxold:"O353BR_EncounterReason_IsApprove",gxvar:"A353BR_EncounterReason_IsApprove",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A353BR_EncounterReason_IsApprove=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z353BR_EncounterReason_IsApprove=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("BR_ENCOUNTERREASON_ISAPPROVE",row || gx.fn.currentGridRowImpl(17),gx.O.A353BR_EncounterReason_IsApprove,true)},c2v:function(){if(this.val()!==undefined)gx.O.A353BR_EncounterReason_IsApprove=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTERREASON_ISAPPROVE",row || gx.fn.currentGridRowImpl(17))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[25]={ id:25 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:17,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_ID",gxz:"Z85BR_Information_ID",gxold:"O85BR_Information_ID",gxvar:"A85BR_Information_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A85BR_Information_ID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z85BR_Information_ID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_INFORMATION_ID",row || gx.fn.currentGridRowImpl(17),gx.O.A85BR_Information_ID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A85BR_Information_ID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_INFORMATION_ID",row || gx.fn.currentGridRowImpl(17),',')},nac:gx.falseFn};
   GXValidFnc[26]={ id:26 ,lvl:2,type:"svchar",len:300,dec:0,sign:false,ro:1,isacc:0,grid:17,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_REFUSEREASON_FREASON",gxz:"Z355BR_Encounter_RefuseReason_FReason",gxold:"O355BR_Encounter_RefuseReason_FReason",gxvar:"A355BR_Encounter_RefuseReason_FReason",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A355BR_Encounter_RefuseReason_FReason=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z355BR_Encounter_RefuseReason_FReason=Value},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_REFUSEREASON_FREASON",row || gx.fn.currentGridRowImpl(17),gx.O.A355BR_Encounter_RefuseReason_FReason,0)},c2v:function(){if(this.val()!==undefined)gx.O.A355BR_Encounter_RefuseReason_FReason=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_REFUSEREASON_FREASON",row || gx.fn.currentGridRowImpl(17))},nac:gx.falseFn};
   GXValidFnc[27]={ id:27 ,lvl:2,type:"dtime",len:10,dec:8,sign:false,ro:1,isacc:0,grid:17,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE",gxz:"Z354BR_Encounter_RefuseReason_FApproveDate",gxold:"O354BR_Encounter_RefuseReason_FApproveDate",gxvar:"A354BR_Encounter_RefuseReason_FApproveDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A354BR_Encounter_RefuseReason_FApproveDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z354BR_Encounter_RefuseReason_FApproveDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE",row || gx.fn.currentGridRowImpl(17),gx.O.A354BR_Encounter_RefuseReason_FApproveDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A354BR_Encounter_RefuseReason_FApproveDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE",row || gx.fn.currentGridRowImpl(17))},nac:gx.falseFn};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[36]={ id:36 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE",gxz:"ZV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace",gxold:"OV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace",gxvar:"AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE",gx.O.AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE",gxz:"ZV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace",gxold:"OV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace",gxvar:"AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE",gx.O.AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE",gxz:"ZV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace",gxold:"OV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace",gxvar:"AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE",gx.O.AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[42]={ id:42 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE",gxz:"ZV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace",gxold:"OV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace",gxvar:"AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE",gx.O.AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV26OrderedBy",gxold:"OV26OrderedBy",gxvar:"AV26OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV26OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV26OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[45]={ id:45 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV27OrderedDsc",gxold:"OV27OrderedDsc",gxvar:"AV27OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV27OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV27OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASON_REASON",gxz:"ZV34TFBR_Encounter_RefuseReason_Reason",gxold:"OV34TFBR_Encounter_RefuseReason_Reason",gxvar:"AV34TFBR_Encounter_RefuseReason_Reason",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV34TFBR_Encounter_RefuseReason_Reason=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV34TFBR_Encounter_RefuseReason_Reason=Value},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASON_REASON",gx.O.AV34TFBR_Encounter_RefuseReason_Reason,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV34TFBR_Encounter_RefuseReason_Reason=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_ENCOUNTER_REFUSEREASON_REASON")},nac:gx.falseFn};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL",gxz:"ZV35TFBR_Encounter_RefuseReason_Reason_Sel",gxold:"OV35TFBR_Encounter_RefuseReason_Reason_Sel",gxvar:"AV35TFBR_Encounter_RefuseReason_Reason_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV35TFBR_Encounter_RefuseReason_Reason_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV35TFBR_Encounter_RefuseReason_Reason_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL",gx.O.AV35TFBR_Encounter_RefuseReason_Reason_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV35TFBR_Encounter_RefuseReason_Reason_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL")},nac:gx.falseFn};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_encounter_refusereason_noapprovedate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE",gxz:"ZV38TFBR_Encounter_RefuseReason_NoApproveDate",gxold:"OV38TFBR_Encounter_RefuseReason_NoApproveDate",gxvar:"AV38TFBR_Encounter_RefuseReason_NoApproveDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[48],ip:[48],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV38TFBR_Encounter_RefuseReason_NoApproveDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV38TFBR_Encounter_RefuseReason_NoApproveDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE",gx.O.AV38TFBR_Encounter_RefuseReason_NoApproveDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV38TFBR_Encounter_RefuseReason_NoApproveDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE")},nac:gx.falseFn};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_encounter_refusereason_noapprovedate_to,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO",gxz:"ZV39TFBR_Encounter_RefuseReason_NoApproveDate_To",gxold:"OV39TFBR_Encounter_RefuseReason_NoApproveDate_To",gxvar:"AV39TFBR_Encounter_RefuseReason_NoApproveDate_To",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[49],ip:[49],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV39TFBR_Encounter_RefuseReason_NoApproveDate_To=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV39TFBR_Encounter_RefuseReason_NoApproveDate_To=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO",gx.O.AV39TFBR_Encounter_RefuseReason_NoApproveDate_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV39TFBR_Encounter_RefuseReason_NoApproveDate_To=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO")},nac:gx.falseFn};
   GXValidFnc[50]={ id: 50, fld:"DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATES",grid:0};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_encounter_refusereason_noapprovedateauxdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE",gxz:"ZV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate",gxold:"OV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate",gxvar:"AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[51],ip:[51],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE",gx.O.AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_encounter_refusereason_noapprovedateauxdateto,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO",gxz:"ZV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo",gxold:"OV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo",gxvar:"AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[52],ip:[52],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO",gx.O.AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASON_FREASON",gxz:"ZV50TFBR_Encounter_RefuseReason_FReason",gxold:"OV50TFBR_Encounter_RefuseReason_FReason",gxvar:"AV50TFBR_Encounter_RefuseReason_FReason",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV50TFBR_Encounter_RefuseReason_FReason=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV50TFBR_Encounter_RefuseReason_FReason=Value},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASON_FREASON",gx.O.AV50TFBR_Encounter_RefuseReason_FReason,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV50TFBR_Encounter_RefuseReason_FReason=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_ENCOUNTER_REFUSEREASON_FREASON")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL",gxz:"ZV51TFBR_Encounter_RefuseReason_FReason_Sel",gxold:"OV51TFBR_Encounter_RefuseReason_FReason_Sel",gxvar:"AV51TFBR_Encounter_RefuseReason_FReason_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV51TFBR_Encounter_RefuseReason_FReason_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV51TFBR_Encounter_RefuseReason_FReason_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL",gx.O.AV51TFBR_Encounter_RefuseReason_FReason_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV51TFBR_Encounter_RefuseReason_FReason_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_encounter_refusereason_fapprovedate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE",gxz:"ZV54TFBR_Encounter_RefuseReason_FApproveDate",gxold:"OV54TFBR_Encounter_RefuseReason_FApproveDate",gxvar:"AV54TFBR_Encounter_RefuseReason_FApproveDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[55],ip:[55],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV54TFBR_Encounter_RefuseReason_FApproveDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV54TFBR_Encounter_RefuseReason_FApproveDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE",gx.O.AV54TFBR_Encounter_RefuseReason_FApproveDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV54TFBR_Encounter_RefuseReason_FApproveDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE")},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_encounter_refusereason_fapprovedate_to,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO",gxz:"ZV55TFBR_Encounter_RefuseReason_FApproveDate_To",gxold:"OV55TFBR_Encounter_RefuseReason_FApproveDate_To",gxvar:"AV55TFBR_Encounter_RefuseReason_FApproveDate_To",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[56],ip:[56],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV55TFBR_Encounter_RefuseReason_FApproveDate_To=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV55TFBR_Encounter_RefuseReason_FApproveDate_To=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO",gx.O.AV55TFBR_Encounter_RefuseReason_FApproveDate_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV55TFBR_Encounter_RefuseReason_FApproveDate_To=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO")},nac:gx.falseFn};
   GXValidFnc[57]={ id: 57, fld:"DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATES",grid:0};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_encounter_refusereason_fapprovedateauxdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATE",gxz:"ZV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate",gxold:"OV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate",gxvar:"AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[58],ip:[58],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATE",gx.O.AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATE")},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_encounter_refusereason_fapprovedateauxdateto,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATETO",gxz:"ZV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo",gxold:"OV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo",gxvar:"AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[59],ip:[59],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATETO",gx.O.AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATETO")},nac:gx.falseFn};
   this.AV48BR_EncounterReason_vStatus = 0 ;
   this.ZV48BR_EncounterReason_vStatus = 0 ;
   this.OV48BR_EncounterReason_vStatus = 0 ;
   this.Z348BR_Encounter_RefuseReasonID = 0 ;
   this.O348BR_Encounter_RefuseReasonID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.Z349BR_Encounter_RefuseReason_Reason = "" ;
   this.O349BR_Encounter_RefuseReason_Reason = "" ;
   this.Z350BR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.O350BR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.Z351BR_Encounter_RefuseReason_Status = 0 ;
   this.O351BR_Encounter_RefuseReason_Status = 0 ;
   this.Z352BR_Encounter_RefuseReason_Approver = "" ;
   this.O352BR_Encounter_RefuseReason_Approver = "" ;
   this.Z353BR_EncounterReason_IsApprove = false ;
   this.O353BR_EncounterReason_IsApprove = false ;
   this.Z85BR_Information_ID = 0 ;
   this.O85BR_Information_ID = 0 ;
   this.Z355BR_Encounter_RefuseReason_FReason = "" ;
   this.O355BR_Encounter_RefuseReason_FReason = "" ;
   this.Z354BR_Encounter_RefuseReason_FApproveDate = gx.date.nullDate() ;
   this.O354BR_Encounter_RefuseReason_FApproveDate = gx.date.nullDate() ;
   this.AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = "" ;
   this.ZV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = "" ;
   this.OV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = "" ;
   this.AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = "" ;
   this.ZV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = "" ;
   this.OV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = "" ;
   this.AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace = "" ;
   this.ZV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace = "" ;
   this.OV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace = "" ;
   this.AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace = "" ;
   this.ZV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace = "" ;
   this.OV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace = "" ;
   this.AV26OrderedBy = 0 ;
   this.ZV26OrderedBy = 0 ;
   this.OV26OrderedBy = 0 ;
   this.AV27OrderedDsc = false ;
   this.ZV27OrderedDsc = false ;
   this.OV27OrderedDsc = false ;
   this.AV34TFBR_Encounter_RefuseReason_Reason = "" ;
   this.ZV34TFBR_Encounter_RefuseReason_Reason = "" ;
   this.OV34TFBR_Encounter_RefuseReason_Reason = "" ;
   this.AV35TFBR_Encounter_RefuseReason_Reason_Sel = "" ;
   this.ZV35TFBR_Encounter_RefuseReason_Reason_Sel = "" ;
   this.OV35TFBR_Encounter_RefuseReason_Reason_Sel = "" ;
   this.AV38TFBR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.ZV38TFBR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.OV38TFBR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.AV39TFBR_Encounter_RefuseReason_NoApproveDate_To = gx.date.nullDate() ;
   this.ZV39TFBR_Encounter_RefuseReason_NoApproveDate_To = gx.date.nullDate() ;
   this.OV39TFBR_Encounter_RefuseReason_NoApproveDate_To = gx.date.nullDate() ;
   this.AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = gx.date.nullDate() ;
   this.ZV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = gx.date.nullDate() ;
   this.OV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = gx.date.nullDate() ;
   this.AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = gx.date.nullDate() ;
   this.ZV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = gx.date.nullDate() ;
   this.OV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = gx.date.nullDate() ;
   this.AV50TFBR_Encounter_RefuseReason_FReason = "" ;
   this.ZV50TFBR_Encounter_RefuseReason_FReason = "" ;
   this.OV50TFBR_Encounter_RefuseReason_FReason = "" ;
   this.AV51TFBR_Encounter_RefuseReason_FReason_Sel = "" ;
   this.ZV51TFBR_Encounter_RefuseReason_FReason_Sel = "" ;
   this.OV51TFBR_Encounter_RefuseReason_FReason_Sel = "" ;
   this.AV54TFBR_Encounter_RefuseReason_FApproveDate = gx.date.nullDate() ;
   this.ZV54TFBR_Encounter_RefuseReason_FApproveDate = gx.date.nullDate() ;
   this.OV54TFBR_Encounter_RefuseReason_FApproveDate = gx.date.nullDate() ;
   this.AV55TFBR_Encounter_RefuseReason_FApproveDate_To = gx.date.nullDate() ;
   this.ZV55TFBR_Encounter_RefuseReason_FApproveDate_To = gx.date.nullDate() ;
   this.OV55TFBR_Encounter_RefuseReason_FApproveDate_To = gx.date.nullDate() ;
   this.AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate = gx.date.nullDate() ;
   this.ZV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate = gx.date.nullDate() ;
   this.OV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate = gx.date.nullDate() ;
   this.AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo = gx.date.nullDate() ;
   this.ZV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo = gx.date.nullDate() ;
   this.OV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo = gx.date.nullDate() ;
   this.AV48BR_EncounterReason_vStatus = 0 ;
   this.AV17GridCurrentPage = 0 ;
   this.AV43DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = "" ;
   this.AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = "" ;
   this.AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace = "" ;
   this.AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace = "" ;
   this.AV26OrderedBy = 0 ;
   this.AV27OrderedDsc = false ;
   this.AV34TFBR_Encounter_RefuseReason_Reason = "" ;
   this.AV35TFBR_Encounter_RefuseReason_Reason_Sel = "" ;
   this.AV38TFBR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.AV39TFBR_Encounter_RefuseReason_NoApproveDate_To = gx.date.nullDate() ;
   this.AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = gx.date.nullDate() ;
   this.AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = gx.date.nullDate() ;
   this.AV50TFBR_Encounter_RefuseReason_FReason = "" ;
   this.AV51TFBR_Encounter_RefuseReason_FReason_Sel = "" ;
   this.AV54TFBR_Encounter_RefuseReason_FApproveDate = gx.date.nullDate() ;
   this.AV55TFBR_Encounter_RefuseReason_FApproveDate_To = gx.date.nullDate() ;
   this.AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate = gx.date.nullDate() ;
   this.AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo = gx.date.nullDate() ;
   this.AV13BR_EncounterID = 0 ;
   this.A356BR_EncounterReason_vStatus = 0 ;
   this.A348BR_Encounter_RefuseReasonID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A349BR_Encounter_RefuseReason_Reason = "" ;
   this.A350BR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.A351BR_Encounter_RefuseReason_Status = 0 ;
   this.A352BR_Encounter_RefuseReason_Approver = "" ;
   this.A353BR_EncounterReason_IsApprove = false ;
   this.A85BR_Information_ID = 0 ;
   this.A355BR_Encounter_RefuseReason_FReason = "" ;
   this.A354BR_Encounter_RefuseReason_FApproveDate = gx.date.nullDate() ;
   this.AV70Pgmname = "" ;
   this.AV20IsAuthorized_BR_Encounter_RefuseReason_Reason = false ;
   this.Events = {"e117d2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e127d2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e137d2_client": ["DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED", true] ,"e147d2_client": ["DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED", true] ,"e157d2_client": ["DDO_BR_ENCOUNTER_REFUSEREASON_FREASON.ONOPTIONCLICKED", true] ,"e167d2_client": ["DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE.ONOPTIONCLICKED", true] ,"e207d2_client": ["ENTER", true] ,"e217d2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTERREASON_VSTATUS'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true}],[{av:'AV33BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_RefuseReason_FReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_REASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_FREASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Title'},{av:'AV17GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV18GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV19GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV6BR_Encounter_RefuseReasonID',fld:'vBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{ctrl:'vBR_ENCOUNTERREASON_VSTATUS'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{ctrl:'vBR_ENCOUNTERREASON_VSTATUS'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASON_REASON","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASON_FREASON","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'TitleControlIdToReplace'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'TitleControlIdToReplace'},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'TitleControlIdToReplace'},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'TitleControlIdToReplace'},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV43DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATE',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'FilteredText_set'},{av:'AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATETO',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.FilteredTextTo_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'FilteredTextTo_set'},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.SelectedValue_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'SelectedValue_set'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'FilteredText_set'},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'FilteredText_set'},{av:'AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.FilteredTextTo_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'FilteredTextTo_set'},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SelectedValue_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SelectedValue_set'},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'FilteredText_set'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTERREASON_VSTATUS'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTERREASON_VSTATUS'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTERREASON_VSTATUS'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SelectedValue_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SelectedValue_get'}],[{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'SortedStatus'},{av:'AV33BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_RefuseReason_FReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_REASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_FREASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Title'},{av:'AV17GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV18GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV19GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTERREASON_VSTATUS'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.FilteredTextTo_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'FilteredTextTo_get'}],[{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'SortedStatus'},{av:'AV33BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_RefuseReason_FReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_REASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_FREASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Title'},{av:'AV17GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV18GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV19GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_REFUSEREASON_FREASON.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTERREASON_VSTATUS'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.SelectedValue_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'SelectedValue_get'}],[{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'SortedStatus'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'SortedStatus'},{av:'AV33BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_RefuseReason_FReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_REASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_FREASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Title'},{av:'AV17GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV18GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV19GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTERREASON_VSTATUS'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.FilteredTextTo_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'FilteredTextTo_get'}],[{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'SortedStatus'},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'SortedStatus'},{av:'AV33BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_RefuseReason_FReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_REASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_FREASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Title'},{av:'AV17GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV18GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV19GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'A348BR_Encounter_RefuseReasonID',fld:'BR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_REASON","Link")',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Link'}]];
   this.setVCMap("AV70Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV20IsAuthorized_BR_Encounter_RefuseReason_Reason", "vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON", 0, "boolean", 4, 0);
   this.setVCMap("AV13BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV13BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV70Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV20IsAuthorized_BR_Encounter_RefuseReason_Reason", "vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON", 0, "boolean", 4, 0);
   this.setVCMap("AV13BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV70Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV20IsAuthorized_BR_Encounter_RefuseReason_Reason", "vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[11]);
   GridContainer.addRefreshingVar(this.GXValidFnc[44]);
   GridContainer.addRefreshingVar(this.GXValidFnc[45]);
   GridContainer.addRefreshingVar(this.GXValidFnc[46]);
   GridContainer.addRefreshingVar(this.GXValidFnc[47]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[49]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[55]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar({rfrVar:"AV13BR_EncounterID"});
   GridContainer.addRefreshingVar(this.GXValidFnc[36]);
   GridContainer.addRefreshingVar(this.GXValidFnc[38]);
   GridContainer.addRefreshingVar(this.GXValidFnc[40]);
   GridContainer.addRefreshingVar(this.GXValidFnc[42]);
   GridContainer.addRefreshingVar({rfrVar:"AV70Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV20IsAuthorized_BR_Encounter_RefuseReason_Reason"});
   this.Initialize( );
});
gx.createParentObj(br_enteringsubmitdetail);
