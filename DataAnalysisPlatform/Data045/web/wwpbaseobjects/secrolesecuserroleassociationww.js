/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:11:22.79
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secrolesecuserroleassociationww', false, function () {
   this.ServerClass =  "wwpbaseobjects.secrolesecuserroleassociationww" ;
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
      this.AV8SecRoleId=gx.fn.getIntegerValue("vSECROLEID",',') ;
      this.A4SecRoleId=gx.fn.getIntegerValue("SECROLEID",',') ;
      this.AV20i=gx.fn.getIntegerValue("vI",',') ;
      this.AV11SecUserIdRemoved=gx.fn.getControlValue("vSECUSERIDREMOVED") ;
      this.AV13SecUserIdToFind=gx.fn.getIntegerValue("vSECUSERIDTOFIND",',') ;
      this.AV10SecUserIdAdded=gx.fn.getControlValue("vSECUSERIDADDED") ;
      this.AV9SecRoleIdParm=gx.fn.getIntegerValue("vSECROLEIDPARM",',') ;
      this.AV21SecUserRole=gx.fn.getControlValue("vSECUSERROLE") ;
      this.AV8SecRoleId=gx.fn.getIntegerValue("vSECROLEID",',') ;
      this.A4SecRoleId=gx.fn.getIntegerValue("SECROLEID",',') ;
      this.AV20i=gx.fn.getIntegerValue("vI",',') ;
      this.AV11SecUserIdRemoved=gx.fn.getControlValue("vSECUSERIDREMOVED") ;
      this.AV13SecUserIdToFind=gx.fn.getIntegerValue("vSECUSERIDTOFIND",',') ;
      this.AV10SecUserIdAdded=gx.fn.getControlValue("vSECUSERIDADDED") ;
      this.AV9SecRoleIdParm=gx.fn.getIntegerValue("vSECROLEIDPARM",',') ;
   };
   this.Valid_Secuserid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(25) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("SECUSERID", gx.fn.currentGridRowImpl(25));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.s122_client=function()
   {
      this.AV20i = gx.num.trunc( 1 ,0) ;
      this.AV38GXV4 = gx.num.trunc( 1 ,0) ;
      while ( this.AV38GXV4 <= this.AV11SecUserIdRemoved.length )
      {
         this.AV12SecUserId = gx.num.trunc( this.AV11SecUserIdRemoved[this.AV38GXV4 - 1] ,0) ;
         if ( this.AV12SecUserId == this.AV13SecUserIdToFind )
         {
            break;
         }
         this.AV20i = gx.num.trunc( this.AV20i + 1 ,0) ;
         this.AV38GXV4 = gx.num.trunc( this.AV38GXV4 + 1 ,0) ;
      }
      if ( this.AV20i > this.AV11SecUserIdRemoved.length )
      {
         this.AV20i = gx.num.trunc( 0 ,0) ;
      }
   };
   this.s132_client=function()
   {
      this.AV20i = gx.num.trunc( 1 ,0) ;
      this.AV37GXV3 = gx.num.trunc( 1 ,0) ;
      while ( this.AV37GXV3 <= this.AV10SecUserIdAdded.length )
      {
         this.AV12SecUserId = gx.num.trunc( this.AV10SecUserIdAdded[this.AV37GXV3 - 1] ,0) ;
         if ( this.AV12SecUserId == this.AV13SecUserIdToFind )
         {
            break;
         }
         this.AV20i = gx.num.trunc( this.AV20i + 1 ,0) ;
         this.AV37GXV3 = gx.num.trunc( this.AV37GXV3 + 1 ,0) ;
      }
      if ( this.AV20i > this.AV10SecUserIdAdded.length )
      {
         this.AV20i = gx.num.trunc( 0 ,0) ;
      }
   };
   this.e11442_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12442_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13442_client=function()
   {
      return this.executeServerEvent("DDO_SECUSERNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14442_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e18442_client=function()
   {
      return this.executeServerEvent("VISASSOCIATED.CLICK", true, arguments[0], false, false);
   };
   this.e19441_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,17,18,19,20,21,22,23,24,26,27,28,29,30,31,32,33,35,36,37,38,39,40,41,42,43,44,46,47,48,50];
   this.GXLastCtrlId =50;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwpbaseobjects.secrolesecuserroleassociationww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","增加空白行",true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addCheckBox("Isassociated",26,"vISASSOCIATED","","","IsAssociated","boolean","true","false","e18442_client",true,false,0,"px","");
   GridContainer.addCheckBox("Isassociatedold",27,"vISASSOCIATEDOLD","","","IsAssociatedOld","boolean","true","false",null,false,false,0,"px","");
   GridContainer.addSingleLineEdit(6,28,"SECUSERID","编号","","SecUserId","int",0,"px",4,4,"right",null,[],6,"SecUserId",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(14,29,"SECUSERNAME","","","SecUserName","svchar",0,"px",100,80,"left",null,[],14,"SecUserName",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(15,30,"SECUSERPASSWORD","密码","","SecUserPassword","svchar",0,"px",100,80,"left",null,[],15,"SecUserPassword",false,0,false,true,"Attribute",1,"WWColumn hidden-xs");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.DVPANEL_UNNAMEDTABLE1Container = gx.uc.getNew(this, 10, 0, "BootstrapPanel", "DVPANEL_UNNAMEDTABLE1Container", "Dvpanel_unnamedtable1", "DVPANEL_UNNAMEDTABLE1");
   var DVPANEL_UNNAMEDTABLE1Container = this.DVPANEL_UNNAMEDTABLE1Container;
   DVPANEL_UNNAMEDTABLE1Container.setProp("Class", "Class", "", "char");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Width", "Width", "100%", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Height", "Height", "100", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Cls", "Cls", "PanelNoHeader", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Title", "Title", "", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Collapsible", "Collapsible", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("IconPosition", "Iconposition", "left", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Visible", "Visible", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_UNNAMEDTABLE1Container);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 34, 19, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.setProp("Caption", "Caption", "<CURRENT_PAGE>页/<TOTAL_PAGES>页 记录：<TOTAL_RECORDS>条", "str");
   GRIDPAGINATIONBARContainer.setProp("EmptyGridCaption", "Emptygridcaption", "WWP_PagingEmptyGridCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageCaption", "Rowsperpagecaption", "WWP_PagingRowsPerPage", "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV29GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV29GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV29GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV31GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV31GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV31GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV30GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV30GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV30GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11442_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12442_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_SECUSERNAMEContainer = gx.uc.getNew(this, 45, 19, "BootstrapDropDownOptions", "DDO_SECUSERNAMEContainer", "Ddo_secusername", "DDO_SECUSERNAME");
   var DDO_SECUSERNAMEContainer = this.DDO_SECUSERNAMEContainer;
   DDO_SECUSERNAMEContainer.setProp("Class", "Class", "", "char");
   DDO_SECUSERNAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECUSERNAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECUSERNAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECUSERNAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECUSERNAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECUSERNAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SECUSERNAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SECUSERNAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SECUSERNAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SECUSERNAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SECUSERNAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SECUSERNAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SECUSERNAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SECUSERNAMEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_SECUSERNAMEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_SECUSERNAMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_SECUSERNAMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_SECUSERNAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_SECUSERNAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECUSERNAMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_SECUSERNAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_SECUSERNAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECUSERNAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECUSERNAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECUSERNAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECUSERNAMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_SECUSERNAMEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_SECUSERNAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECUSERNAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECUSERNAMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECUSERNAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECUSERNAMEContainer.addV2CFunction('AV27DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECUSERNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV27DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV27DDO_TitleSettingsIcons); });
   DDO_SECUSERNAMEContainer.addV2CFunction('AV25SecUserNameTitleFilterData', "vSECUSERNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECUSERNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25SecUserNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECUSERNAMETITLEFILTERDATA",UC.ParentObject.AV25SecUserNameTitleFilterData); });
   DDO_SECUSERNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECUSERNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECUSERNAMEContainer.addEventHandler("OnOptionClicked", this.e13442_client);
   this.setUserControl(DDO_SECUSERNAMEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 49, 19, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[9]={ id: 9, fld:"HTML_DVPANEL_UNNAMEDTABLE1",grid:0};
   GXValidFnc[12]={ id: 12, fld:"LAYOUT_UNNAMEDTABLE1",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id:19 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vSECUSERNAME",gxz:"ZV24SecUserName",gxold:"OV24SecUserName",gxvar:"AV24SecUserName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV24SecUserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24SecUserName=Value},v2c:function(){gx.fn.setControlValue("vSECUSERNAME",gx.O.AV24SecUserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV24SecUserName=this.val()},val:function(){return gx.fn.getControlValue("vSECUSERNAME")},nac:gx.falseFn};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:0,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vISASSOCIATED",gxz:"ZV18IsAssociated",gxold:"OV18IsAssociated",gxvar:"AV18IsAssociated",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV18IsAssociated=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18IsAssociated=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("vISASSOCIATED",row || gx.fn.currentGridRowImpl(25),gx.O.AV18IsAssociated,true)},c2v:function(){if(this.val()!==undefined)gx.O.AV18IsAssociated=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("vISASSOCIATED",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn,evt:"e18442_client",values:['true','false']};
   GXValidFnc[27]={ id:27 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:0,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vISASSOCIATEDOLD",gxz:"ZV19IsAssociatedOld",gxold:"OV19IsAssociatedOld",gxvar:"AV19IsAssociatedOld",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV19IsAssociatedOld=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV19IsAssociatedOld=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("vISASSOCIATEDOLD",row || gx.fn.currentGridRowImpl(25),gx.O.AV19IsAssociatedOld,true)},c2v:function(){if(this.val()!==undefined)gx.O.AV19IsAssociatedOld=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("vISASSOCIATEDOLD",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[28]={ id:28 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Secuserid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERID",gxz:"Z6SecUserId",gxold:"O6SecUserId",gxvar:"A6SecUserId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A6SecUserId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z6SecUserId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECUSERID",row || gx.fn.currentGridRowImpl(25),gx.O.A6SecUserId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A6SecUserId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECUSERID",row || gx.fn.currentGridRowImpl(25),',')},nac:gx.falseFn};
   GXValidFnc[29]={ id:29 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERNAME",gxz:"Z14SecUserName",gxold:"O14SecUserName",gxvar:"A14SecUserName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A14SecUserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z14SecUserName=Value},v2c:function(row){gx.fn.setGridControlValue("SECUSERNAME",row || gx.fn.currentGridRowImpl(25),gx.O.A14SecUserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A14SecUserName=this.val()},val:function(row){return gx.fn.getGridControlValue("SECUSERNAME",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,isPwd:true,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERPASSWORD",gxz:"Z15SecUserPassword",gxold:"O15SecUserPassword",gxvar:"A15SecUserPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A15SecUserPassword=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z15SecUserPassword=Value},v2c:function(row){gx.fn.setGridControlValue("SECUSERPASSWORD",row || gx.fn.currentGridRowImpl(25),gx.O.A15SecUserPassword,0)},c2v:function(){if(this.val()!==undefined)gx.O.A15SecUserPassword=this.val()},val:function(row){return gx.fn.getGridControlValue("SECUSERPASSWORD",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"BTNCONFIRM",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"BTNCANCEL",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",gxz:"ZV26ddo_SecUserNameTitleControlIdToReplace",gxold:"OV26ddo_SecUserNameTitleControlIdToReplace",gxvar:"AV26ddo_SecUserNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26ddo_SecUserNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26ddo_SecUserNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",gx.O.AV26ddo_SecUserNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26ddo_SecUserNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"vchar",len:2097152,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECUSERIDADDEDXML",gxz:"ZV14SecUserIdAddedXml",gxold:"OV14SecUserIdAddedXml",gxvar:"AV14SecUserIdAddedXml",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14SecUserIdAddedXml=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV14SecUserIdAddedXml=Value},v2c:function(){gx.fn.setControlValue("vSECUSERIDADDEDXML",gx.O.AV14SecUserIdAddedXml,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14SecUserIdAddedXml=this.val()},val:function(){return gx.fn.getControlValue("vSECUSERIDADDEDXML")},nac:gx.falseFn};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"vchar",len:2097152,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECUSERIDREMOVEDXML",gxz:"ZV15SecUserIdRemovedXml",gxold:"OV15SecUserIdRemovedXml",gxvar:"AV15SecUserIdRemovedXml",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15SecUserIdRemovedXml=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV15SecUserIdRemovedXml=Value},v2c:function(){gx.fn.setControlValue("vSECUSERIDREMOVEDXML",gx.O.AV15SecUserIdRemovedXml,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15SecUserIdRemovedXml=this.val()},val:function(){return gx.fn.getControlValue("vSECUSERIDREMOVEDXML")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV23OrderedDsc",gxold:"OV23OrderedDsc",gxvar:"AV23OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV23OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV23OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.AV24SecUserName = "" ;
   this.ZV24SecUserName = "" ;
   this.OV24SecUserName = "" ;
   this.ZV18IsAssociated = false ;
   this.OV18IsAssociated = false ;
   this.ZV19IsAssociatedOld = false ;
   this.OV19IsAssociatedOld = false ;
   this.Z6SecUserId = 0 ;
   this.O6SecUserId = 0 ;
   this.Z14SecUserName = "" ;
   this.O14SecUserName = "" ;
   this.Z15SecUserPassword = "" ;
   this.O15SecUserPassword = "" ;
   this.AV26ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.ZV26ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.OV26ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.AV14SecUserIdAddedXml = "" ;
   this.ZV14SecUserIdAddedXml = "" ;
   this.OV14SecUserIdAddedXml = "" ;
   this.AV15SecUserIdRemovedXml = "" ;
   this.ZV15SecUserIdRemovedXml = "" ;
   this.OV15SecUserIdRemovedXml = "" ;
   this.AV23OrderedDsc = false ;
   this.ZV23OrderedDsc = false ;
   this.OV23OrderedDsc = false ;
   this.AV24SecUserName = "" ;
   this.AV29GridCurrentPage = 0 ;
   this.AV27DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV26ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.AV14SecUserIdAddedXml = "" ;
   this.AV15SecUserIdRemovedXml = "" ;
   this.AV23OrderedDsc = false ;
   this.AV8SecRoleId = 0 ;
   this.AV18IsAssociated = false ;
   this.AV19IsAssociatedOld = false ;
   this.A6SecUserId = 0 ;
   this.A14SecUserName = "" ;
   this.A15SecUserPassword = "" ;
   this.A4SecRoleId = 0 ;
   this.AV20i = 0 ;
   this.AV11SecUserIdRemoved = [ ] ;
   this.AV13SecUserIdToFind = 0 ;
   this.AV10SecUserIdAdded = [ ] ;
   this.AV9SecRoleIdParm = 0 ;
   this.AV21SecUserRole = {SecUserId:0,SecRoleId:0,SecUserName:"",SecRoleName:"",SecRoleDescription:"",Mode:"",Initialized:0,SecUserId_Z:0,SecRoleId_Z:0,SecUserName_Z:"",SecRoleName_Z:"",SecRoleDescription_Z:""} ;
   this.AV12SecUserId = 0 ;
   this.AV38GXV4 = 0 ;
   this.AV37GXV3 = 0 ;
   this.Events = {"e11442_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12442_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13442_client": ["DDO_SECUSERNAME.ONOPTIONCLICKED", true] ,"e14442_client": ["ENTER", true] ,"e18442_client": ["VISASSOCIATED.CLICK", true] ,"e19441_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV24SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV9SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'AV26ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true}],[{av:'AV25SecUserNameTitleFilterData',fld:'vSECUSERNAMETITLEFILTERDATA',pic:''},{ctrl:'SECUSERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Title")',ctrl:'SECUSERNAME',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''}]];
   this.EvtParms["START"] = [[],[{ctrl:'GRID',prop:'Rows'},{av:'this.DDO_SECUSERNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_SECUSERNAME',prop:'TitleControlIdToReplace'},{av:'AV26ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vSECUSERIDADDEDXML","Visible")',ctrl:'vSECUSERIDADDEDXML',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vSECUSERIDREMOVEDXML","Visible")',ctrl:'vSECUSERIDREMOVEDXML',prop:'Visible'},{av:'AV27DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV24SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV26ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV9SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV24SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV26ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV9SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_SECUSERNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV24SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV26ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV9SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'this.DDO_SECUSERNAMEContainer.ActiveEventKey',ctrl:'DDO_SECUSERNAME',prop:'ActiveEventKey'}],[{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECUSERNAMEContainer.SortedStatus',ctrl:'DDO_SECUSERNAME',prop:'SortedStatus'},{av:'AV25SecUserNameTitleFilterData',fld:'vSECUSERNAMETITLEFILTERDATA',pic:''},{ctrl:'SECUSERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Title")',ctrl:'SECUSERNAME',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9',hsh:true},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV9SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'}],[{av:'AV9SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'AV19IsAssociatedOld',fld:'vISASSOCIATEDOLD',pic:'',hsh:true},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV18IsAssociated',fld:'vISASSOCIATED',pic:''},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["ENTER"] = [[{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV21SecUserRole',fld:'vSECUSERROLE',pic:''}],[{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV21SecUserRole',fld:'vSECUSERROLE',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''}]];
   this.EvtParms["VISASSOCIATED.CLICK"] = [[{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9',hsh:true},{av:'AV18IsAssociated',fld:'vISASSOCIATED',pic:''},{av:'AV19IsAssociatedOld',fld:'vISASSOCIATEDOLD',pic:'',hsh:true},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'}],[{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''}]];
   this.EnterCtrl = ["BTNCONFIRM"];
   this.setVCMap("AV8SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("A4SecRoleId", "SECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV20i", "vI", 0, "int", 10, 0);
   this.setVCMap("AV11SecUserIdRemoved", "vSECUSERIDREMOVED", 0, "Collint", 0, 0);
   this.setVCMap("AV13SecUserIdToFind", "vSECUSERIDTOFIND", 0, "int", 4, 0);
   this.setVCMap("AV10SecUserIdAdded", "vSECUSERIDADDED", 0, "Collint", 0, 0);
   this.setVCMap("AV9SecRoleIdParm", "vSECROLEIDPARM", 0, "int", 4, 0);
   this.setVCMap("AV21SecUserRole", "vSECUSERROLE", 0, "WWPBaseObjects\SecUserRole", 0, 0);
   this.setVCMap("AV8SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("A4SecRoleId", "SECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV20i", "vI", 0, "int", 10, 0);
   this.setVCMap("AV11SecUserIdRemoved", "vSECUSERIDREMOVED", 0, "Collint", 0, 0);
   this.setVCMap("AV13SecUserIdToFind", "vSECUSERIDTOFIND", 0, "int", 4, 0);
   this.setVCMap("AV10SecUserIdAdded", "vSECUSERIDADDED", 0, "Collint", 0, 0);
   this.setVCMap("AV9SecRoleIdParm", "vSECROLEIDPARM", 0, "int", 4, 0);
   this.setVCMap("AV8SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("A4SecRoleId", "SECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV20i", "vI", 0, "int", 10, 0);
   this.setVCMap("AV11SecUserIdRemoved", "vSECUSERIDREMOVED", 0, "Collint", 0, 0);
   this.setVCMap("AV13SecUserIdToFind", "vSECUSERIDTOFIND", 0, "int", 4, 0);
   this.setVCMap("AV10SecUserIdAdded", "vSECUSERIDADDED", 0, "Collint", 0, 0);
   this.setVCMap("AV9SecRoleIdParm", "vSECROLEIDPARM", 0, "int", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[19]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[46]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[47]);
   GridContainer.addRefreshingVar({rfrVar:"AV8SecRoleId"});
   GridContainer.addRefreshingVar({rfrVar:"A4SecRoleId"});
   GridContainer.addRefreshingVar({rfrVar:"AV20i"});
   GridContainer.addRefreshingVar({rfrVar:"AV11SecUserIdRemoved"});
   GridContainer.addRefreshingVar({rfrVar:"AV13SecUserIdToFind"});
   GridContainer.addRefreshingVar({rfrVar:"AV10SecUserIdAdded"});
   GridContainer.addRefreshingVar({rfrVar:"AV9SecRoleIdParm"});
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.secrolesecuserroleassociationww);
