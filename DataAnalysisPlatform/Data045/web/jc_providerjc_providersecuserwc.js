/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:7:52.20
*/
gx.evt.autoSkip=!1;gx.define("jc_providerjc_providersecuserwc",!0,function(n){var r,e,f,u,t,i,o;this.ServerClass="jc_providerjc_providersecuserwc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV36Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV30IsAuthorized_SecUserName=gx.fn.getControlValue("vISAUTHORIZED_SECUSERNAME");this.AV8JC_ProviderID=gx.fn.getIntegerValue("vJC_PROVIDERID",",");this.AV8JC_ProviderID=gx.fn.getIntegerValue("vJC_PROVIDERID",",");this.AV36Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV30IsAuthorized_SecUserName=gx.fn.getControlValue("vISAUTHORIZED_SECUSERNAME")};this.Valid_Secuserid=function(){try{if(gx.fn.currentGridRowImpl(33)===0)return!0;var n=gx.util.balloon.getNew("SECUSERID",gx.fn.currentGridRowImpl(33));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e118l2_client=function(){return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE",!1,null,!0,!0)};this.e128l2_client=function(){return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",!1,null,!0,!0)};this.e138l2_client=function(){return this.executeServerEvent("DDO_SECUSERID.ONOPTIONCLICKED",!1,null,!0,!0)};this.e148l2_client=function(){return this.executeServerEvent("DDO_SECUSERNAME.ONOPTIONCLICKED",!1,null,!0,!0)};this.e158l2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e198l2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e208l2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];r=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,34,35,36,37,38,39,40,41,43,44,45,47,49,50,52,53];this.GXLastCtrlId=53;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",33,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"jc_providerjc_providersecuserwc",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px",0,"px","增加空白行",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);e=this.GridContainer;e.addBitmap("&Update","vUPDATE",34,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");e.addBitmap("&Delete","vDELETE",35,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");e.addBitmap("&Display","vDISPLAY",36,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");e.addSingleLineEdit(6,37,"SECUSERID","","","SecUserId","int",0,"px",4,4,"right",null,[],6,"SecUserId",!0,0,!1,!1,"Attribute",1,"WWColumn");e.addSingleLineEdit(14,38,"SECUSERNAME","","","SecUserName","svchar",0,"px",100,80,"left",null,[],14,"SecUserName",!0,0,!1,!1,"Attribute",1,"WWColumn hidden-xs");this.GridContainer.emptyText="";this.setGrid(e);this.DVPANEL_TABLEHEADERContainer=gx.uc.getNew(this,13,0,"BootstrapPanel",this.CmpContext+"DVPANEL_TABLEHEADERContainer","Dvpanel_tableheader","DVPANEL_TABLEHEADER");f=this.DVPANEL_TABLEHEADERContainer;f.setProp("Class","Class","","char");f.setProp("Enabled","Enabled",!0,"boolean");f.setProp("Width","Width","100%","str");f.setProp("Height","Height","100","str");f.setProp("AutoWidth","Autowidth",!1,"bool");f.setProp("AutoHeight","Autoheight",!0,"bool");f.setProp("Cls","Cls","PanelNoHeader","str");f.setProp("ShowHeader","Showheader",!0,"bool");f.setProp("Title","Title","选项","str");f.setProp("Collapsible","Collapsible",!0,"bool");f.setProp("Collapsed","Collapsed",!1,"bool");f.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");f.setProp("IconPosition","Iconposition","left","str");f.setProp("AutoScroll","Autoscroll",!1,"bool");f.setProp("Visible","Visible",!0,"bool");f.setC2ShowFunction(function(n){n.show()});this.setUserControl(f);this.GRIDPAGINATIONBARContainer=gx.uc.getNew(this,42,34,"DVelop_DVPaginationBar",this.CmpContext+"GRIDPAGINATIONBARContainer","Gridpaginationbar","GRIDPAGINATIONBAR");u=this.GRIDPAGINATIONBARContainer;u.setProp("Enabled","Enabled",!0,"boolean");u.setProp("Class","Class","PaginationBar","str");u.setProp("ShowFirst","Showfirst",!1,"bool");u.setProp("ShowPrevious","Showprevious",!0,"bool");u.setProp("ShowNext","Shownext",!0,"bool");u.setProp("ShowLast","Showlast",!1,"bool");u.setProp("PagesToShow","Pagestoshow",5,"num");u.setProp("PagingButtonsPosition","Pagingbuttonsposition","Right","str");u.setProp("PagingCaptionPosition","Pagingcaptionposition","Left","str");u.setProp("EmptyGridClass","Emptygridclass","PaginationBarEmptyGrid","str");u.setProp("SelectedPage","Selectedpage","","char");u.setProp("RowsPerPageSelector","Rowsperpageselector",!0,"bool");u.setDynProp("RowsPerPageSelectedValue","Rowsperpageselectedvalue",10,"num");u.setProp("RowsPerPageOptions","Rowsperpageoptions","5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50","str");u.setProp("First","First","First","str");u.setProp("Previous","Previous","WWP_PagingPreviousCaption","str");u.setProp("Next","Next","WWP_PagingNextCaption","str");u.setProp("Last","Last","Last","str");u.setProp("Caption","Caption","<CURRENT_PAGE>页/<TOTAL_PAGES>页 记录：<TOTAL_RECORDS>条","str");u.setProp("EmptyGridCaption","Emptygridcaption","WWP_PagingEmptyGridCaption","str");u.setProp("RowsPerPageCaption","Rowsperpagecaption","WWP_PagingRowsPerPage","str");u.addV2CFunction("AV24GridCurrentPage","vGRIDCURRENTPAGE","SetCurrentPage");u.addC2VFunction(function(n){n.ParentObject.AV24GridCurrentPage=n.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",n.ParentObject.AV24GridCurrentPage)});u.setProp("PageCount","Pagecount","","str");u.addV2CFunction("AV26GridRecordCount","vGRIDRECORDCOUNT","SetRecordCount");u.addC2VFunction(function(n){n.ParentObject.AV26GridRecordCount=n.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",n.ParentObject.AV26GridRecordCount)});u.addV2CFunction("AV25GridPageSize","vGRIDPAGESIZE","SetPage");u.addC2VFunction(function(n){n.ParentObject.AV25GridPageSize=n.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",n.ParentObject.AV25GridPageSize)});u.setProp("Visible","Visible",!0,"bool");u.setC2ShowFunction(function(n){n.show()});u.addEventHandler("ChangePage",this.e118l2_client);u.addEventHandler("ChangeRowsPerPage",this.e128l2_client);this.setUserControl(u);this.DDO_SECUSERIDContainer=gx.uc.getNew(this,46,34,"BootstrapDropDownOptions",this.CmpContext+"DDO_SECUSERIDContainer","Ddo_secuserid","DDO_SECUSERID");t=this.DDO_SECUSERIDContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Icon","Icon","","char");t.setProp("Caption","Caption","","str");t.setProp("Tooltip","Tooltip","WWP_TSColumnOptions","str");t.setProp("Cls","Cls","ColumnSettings","str");t.setProp("ActiveEventKey","Activeeventkey","","char");t.setProp("FilteredText_set","Filteredtext_set","","char");t.setProp("FilteredText_get","Filteredtext_get","","char");t.setProp("FilteredTextTo_set","Filteredtextto_set","","char");t.setProp("FilteredTextTo_get","Filteredtextto_get","","char");t.setProp("SelectedValue_set","Selectedvalue_set","","char");t.setProp("SelectedValue_get","Selectedvalue_get","","char");t.setProp("SelectedText_set","Selectedtext_set","","char");t.setProp("SelectedText_get","Selectedtext_get","","char");t.setProp("GAMOAuthToken","Gamoauthtoken","","char");t.setProp("TitleControlAlign","Titlecontrolalign","Automatic","str");t.setProp("DropDownOptionsType","Dropdownoptionstype","GridTitleSettings","str");t.setDynProp("TitleControlIdToReplace","Titlecontrolidtoreplace","","str");t.setProp("IncludeSortASC","Includesortasc",!0,"bool");t.setProp("IncludeSortDSC","Includesortdsc",!0,"bool");t.setDynProp("SortedStatus","Sortedstatus","","char");t.setProp("IncludeFilter","Includefilter",!1,"bool");t.setProp("FilterType","Filtertype","","char");t.setProp("FilterIsRange","Filterisrange",!1,"boolean");t.setProp("IncludeDataList","Includedatalist",!1,"bool");t.setProp("DataListType","Datalisttype","","char");t.setProp("AllowMultipleSelection","Allowmultipleselection",!1,"boolean");t.setProp("DataListFixedValues","Datalistfixedvalues","","char");t.setProp("DataListProc","Datalistproc","","char");t.setProp("DataListUpdateMinimumCharacters","Datalistupdateminimumcharacters","","int");t.setProp("FixedFilters","Fixedfilters","","str");t.setProp("SelectedFixedFilter","Selectedfixedfilter","","char");t.setProp("ColumnsSelectorValues","Columnsselectorvalues","","char");t.setProp("SortASC","Sortasc","WWP_TSSortASC","str");t.setProp("SortDSC","Sortdsc","WWP_TSSortDSC","str");t.setProp("LoadingData","Loadingdata","","char");t.setProp("CleanFilter","Cleanfilter","","char");t.setProp("RangeFilterFrom","Rangefilterfrom","","char");t.setProp("RangeFilterTo","Rangefilterto","","char");t.setProp("NoResultsFound","Noresultsfound","","char");t.setProp("SearchButtonText","Searchbuttontext","WWP_TSSearchButtonCaption","str");t.setProp("UpdateButtonText","Updatebuttontext","Update","str");t.addV2CFunction("AV21DDO_TitleSettingsIcons","vDDO_TITLESETTINGSICONS","SetDropDownOptionsTitleSettingsIcons");t.addC2VFunction(function(n){n.ParentObject.AV21DDO_TitleSettingsIcons=n.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",n.ParentObject.AV21DDO_TitleSettingsIcons)});t.addV2CFunction("AV17SecUserIdTitleFilterData","vSECUSERIDTITLEFILTERDATA","SetDropDownOptionsData");t.addC2VFunction(function(n){n.ParentObject.AV17SecUserIdTitleFilterData=n.GetDropDownOptionsData();gx.fn.setControlValue("vSECUSERIDTITLEFILTERDATA",n.ParentObject.AV17SecUserIdTitleFilterData)});t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});t.addEventHandler("OnOptionClicked",this.e138l2_client);this.setUserControl(t);this.DDO_SECUSERNAMEContainer=gx.uc.getNew(this,48,47,"BootstrapDropDownOptions",this.CmpContext+"DDO_SECUSERNAMEContainer","Ddo_secusername","DDO_SECUSERNAME");i=this.DDO_SECUSERNAMEContainer;i.setProp("Class","Class","","char");i.setProp("Enabled","Enabled",!0,"boolean");i.setProp("Icon","Icon","","char");i.setProp("Caption","Caption","","str");i.setProp("Tooltip","Tooltip","WWP_TSColumnOptions","str");i.setProp("Cls","Cls","ColumnSettings","str");i.setProp("ActiveEventKey","Activeeventkey","","char");i.setProp("FilteredText_set","Filteredtext_set","","char");i.setProp("FilteredText_get","Filteredtext_get","","char");i.setProp("FilteredTextTo_set","Filteredtextto_set","","char");i.setProp("FilteredTextTo_get","Filteredtextto_get","","char");i.setProp("SelectedValue_set","Selectedvalue_set","","char");i.setProp("SelectedValue_get","Selectedvalue_get","","char");i.setProp("SelectedText_set","Selectedtext_set","","char");i.setProp("SelectedText_get","Selectedtext_get","","char");i.setProp("GAMOAuthToken","Gamoauthtoken","","char");i.setProp("TitleControlAlign","Titlecontrolalign","Automatic","str");i.setProp("DropDownOptionsType","Dropdownoptionstype","GridTitleSettings","str");i.setDynProp("TitleControlIdToReplace","Titlecontrolidtoreplace","","str");i.setProp("IncludeSortASC","Includesortasc",!0,"bool");i.setProp("IncludeSortDSC","Includesortdsc",!0,"bool");i.setDynProp("SortedStatus","Sortedstatus","","char");i.setProp("IncludeFilter","Includefilter",!1,"bool");i.setProp("FilterType","Filtertype","","char");i.setProp("FilterIsRange","Filterisrange",!1,"boolean");i.setProp("IncludeDataList","Includedatalist",!1,"bool");i.setProp("DataListType","Datalisttype","","char");i.setProp("AllowMultipleSelection","Allowmultipleselection",!1,"boolean");i.setProp("DataListFixedValues","Datalistfixedvalues","","char");i.setProp("DataListProc","Datalistproc","","char");i.setProp("DataListUpdateMinimumCharacters","Datalistupdateminimumcharacters","","int");i.setProp("FixedFilters","Fixedfilters","","str");i.setProp("SelectedFixedFilter","Selectedfixedfilter","","char");i.setProp("ColumnsSelectorValues","Columnsselectorvalues","","char");i.setProp("SortASC","Sortasc","WWP_TSSortASC","str");i.setProp("SortDSC","Sortdsc","WWP_TSSortDSC","str");i.setProp("LoadingData","Loadingdata","","char");i.setProp("CleanFilter","Cleanfilter","","char");i.setProp("RangeFilterFrom","Rangefilterfrom","","char");i.setProp("RangeFilterTo","Rangefilterto","","char");i.setProp("NoResultsFound","Noresultsfound","","char");i.setProp("SearchButtonText","Searchbuttontext","WWP_TSSearchButtonCaption","str");i.setProp("UpdateButtonText","Updatebuttontext","Update","str");i.addV2CFunction("AV21DDO_TitleSettingsIcons","vDDO_TITLESETTINGSICONS","SetDropDownOptionsTitleSettingsIcons");i.addC2VFunction(function(n){n.ParentObject.AV21DDO_TitleSettingsIcons=n.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",n.ParentObject.AV21DDO_TitleSettingsIcons)});i.addV2CFunction("AV19SecUserNameTitleFilterData","vSECUSERNAMETITLEFILTERDATA","SetDropDownOptionsData");i.addC2VFunction(function(n){n.ParentObject.AV19SecUserNameTitleFilterData=n.GetDropDownOptionsData();gx.fn.setControlValue("vSECUSERNAMETITLEFILTERDATA",n.ParentObject.AV19SecUserNameTitleFilterData)});i.setProp("Visible","Visible",!0,"bool");i.setC2ShowFunction(function(n){n.show()});i.addEventHandler("OnOptionClicked",this.e148l2_client);this.setUserControl(i);this.WORKWITHPLUSUTILITIES1Container=gx.uc.getNew(this,51,47,"DVelop_WorkWithPlusUtilities",this.CmpContext+"WORKWITHPLUSUTILITIES1Container","Workwithplusutilities1","WORKWITHPLUSUTILITIES1");o=this.WORKWITHPLUSUTILITIES1Container;o.setProp("Class","Class","","char");o.setProp("Enabled","Enabled",!0,"boolean");o.setProp("Width","Width","100","str");o.setProp("Height","Height","100","str");o.setProp("Visible","Visible",!0,"bool");o.setC2ShowFunction(function(n){n.show()});this.setUserControl(o);r[2]={id:2,fld:"",grid:0};r[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};r[4]={id:4,fld:"",grid:0};r[5]={id:5,fld:"",grid:0};r[6]={id:6,fld:"TABLEGRIDHEADER",grid:0};r[7]={id:7,fld:"",grid:0};r[8]={id:8,fld:"",grid:0};r[10]={id:10,fld:"",grid:0};r[11]={id:11,fld:"",grid:0};r[12]={id:12,fld:"HTML_DVPANEL_TABLEHEADER",grid:0};r[15]={id:15,fld:"LAYOUT_TABLEHEADER",grid:0};r[16]={id:16,fld:"",grid:0};r[17]={id:17,fld:"TABLEHEADER",grid:0};r[18]={id:18,fld:"",grid:0};r[19]={id:19,fld:"",grid:0};r[20]={id:20,fld:"TABLEACTIONS",grid:0};r[21]={id:21,fld:"",grid:0};r[22]={id:22,fld:"",grid:0};r[23]={id:23,fld:"JC_PROVIDERSECUSERTITLE",format:0,grid:0};r[24]={id:24,fld:"",grid:0};r[25]={id:25,fld:"",grid:0};r[26]={id:26,fld:"",grid:0};r[27]={id:27,fld:"BTNINSERT",grid:0};r[28]={id:28,fld:"",grid:0};r[29]={id:29,fld:"",grid:0};r[30]={id:30,fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};r[31]={id:31,fld:"",grid:0};r[32]={id:32,fld:"",grid:0};r[34]={id:34,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV27Update",gxold:"OV27Update",gxvar:"AV27Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV27Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV27Update=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATE",n||gx.fn.currentGridRowImpl(33),gx.O.AV27Update,gx.O.AV33Update_GXI)},c2v:function(){gx.O.AV33Update_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV27Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(33))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATE_GXI",n||gx.fn.currentGridRowImpl(33))},gxvar_GXI:"AV33Update_GXI",nac:gx.falseFn};r[35]={id:35,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV28Delete",gxold:"OV28Delete",gxvar:"AV28Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV28Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV28Delete=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETE",n||gx.fn.currentGridRowImpl(33),gx.O.AV28Delete,gx.O.AV34Delete_GXI)},c2v:function(){gx.O.AV34Delete_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV28Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(33))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETE_GXI",n||gx.fn.currentGridRowImpl(33))},gxvar_GXI:"AV34Delete_GXI",nac:gx.falseFn};r[36]={id:36,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV29Display",gxold:"OV29Display",gxvar:"AV29Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV29Display=n)},v2z:function(n){n!==undefined&&(gx.O.ZV29Display=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDISPLAY",n||gx.fn.currentGridRowImpl(33),gx.O.AV29Display,gx.O.AV35Display_GXI)},c2v:function(){gx.O.AV35Display_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV29Display=this.val())},val:function(n){return gx.fn.getGridControlValue("vDISPLAY",n||gx.fn.currentGridRowImpl(33))},val_GXI:function(n){return gx.fn.getGridControlValue("vDISPLAY_GXI",n||gx.fn.currentGridRowImpl(33))},gxvar_GXI:"AV35Display_GXI",nac:gx.falseFn};r[37]={id:37,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:this.Valid_Secuserid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERID",gxz:"Z6SecUserId",gxold:"O6SecUserId",gxvar:"A6SecUserId",ucs:[],op:[38],ip:[38,37],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A6SecUserId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z6SecUserId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("SECUSERID",n||gx.fn.currentGridRowImpl(33),gx.O.A6SecUserId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A6SecUserId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("SECUSERID",n||gx.fn.currentGridRowImpl(33),",")},nac:gx.falseFn};r[38]={id:38,lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERNAME",gxz:"Z14SecUserName",gxold:"O14SecUserName",gxvar:"A14SecUserName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A14SecUserName=n)},v2z:function(n){n!==undefined&&(gx.O.Z14SecUserName=n)},v2c:function(n){gx.fn.setGridControlValue("SECUSERNAME",n||gx.fn.currentGridRowImpl(33),gx.O.A14SecUserName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A14SecUserName=this.val())},val:function(n){return gx.fn.getGridControlValue("SECUSERNAME",n||gx.fn.currentGridRowImpl(33))},nac:gx.falseFn};r[39]={id:39,fld:"",grid:0};r[40]={id:40,fld:"",grid:0};r[41]={id:41,fld:"HTML_GRIDPAGINATIONBAR",grid:0};r[43]={id:43,fld:"",grid:0};r[44]={id:44,fld:"",grid:0};r[45]={id:45,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};r[47]={id:47,lvl:0,type:"svchar",len:300,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECUSERIDTITLECONTROLIDTOREPLACE",gxz:"ZV18ddo_SecUserIdTitleControlIdToReplace",gxold:"OV18ddo_SecUserIdTitleControlIdToReplace",gxvar:"AV18ddo_SecUserIdTitleControlIdToReplace",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV18ddo_SecUserIdTitleControlIdToReplace=n)},v2z:function(n){n!==undefined&&(gx.O.ZV18ddo_SecUserIdTitleControlIdToReplace=n)},v2c:function(){gx.fn.setControlValue("vDDO_SECUSERIDTITLECONTROLIDTOREPLACE",gx.O.AV18ddo_SecUserIdTitleControlIdToReplace,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV18ddo_SecUserIdTitleControlIdToReplace=this.val())},val:function(){return gx.fn.getControlValue("vDDO_SECUSERIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};r[49]={id:49,lvl:0,type:"svchar",len:300,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",gxz:"ZV20ddo_SecUserNameTitleControlIdToReplace",gxold:"OV20ddo_SecUserNameTitleControlIdToReplace",gxvar:"AV20ddo_SecUserNameTitleControlIdToReplace",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV20ddo_SecUserNameTitleControlIdToReplace=n)},v2z:function(n){n!==undefined&&(gx.O.ZV20ddo_SecUserNameTitleControlIdToReplace=n)},v2c:function(){gx.fn.setControlValue("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",gx.O.AV20ddo_SecUserNameTitleControlIdToReplace,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV20ddo_SecUserNameTitleControlIdToReplace=this.val())},val:function(){return gx.fn.getControlValue("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};r[50]={id:50,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERID",gxz:"Z87JC_ProviderID",gxold:"O87JC_ProviderID",gxvar:"A87JC_ProviderID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A87JC_ProviderID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z87JC_ProviderID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("JC_PROVIDERID",gx.O.A87JC_ProviderID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A87JC_ProviderID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("JC_PROVIDERID",",")},nac:gx.falseFn};this.declareDomainHdlr(50,function(){});r[52]={id:52,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV14OrderedBy",gxold:"OV14OrderedBy",gxvar:"AV14OrderedBy",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV14OrderedBy=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV14OrderedBy=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV14OrderedBy,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV14OrderedBy=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",",")},nac:gx.falseFn};r[53]={id:53,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV15OrderedDsc",gxold:"OV15OrderedDsc",gxvar:"AV15OrderedDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV15OrderedDsc=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV15OrderedDsc=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV15OrderedDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15OrderedDsc=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};this.ZV27Update="";this.OV27Update="";this.ZV28Delete="";this.OV28Delete="";this.ZV29Display="";this.OV29Display="";this.Z6SecUserId=0;this.O6SecUserId=0;this.Z14SecUserName="";this.O14SecUserName="";this.AV18ddo_SecUserIdTitleControlIdToReplace="";this.ZV18ddo_SecUserIdTitleControlIdToReplace="";this.OV18ddo_SecUserIdTitleControlIdToReplace="";this.AV20ddo_SecUserNameTitleControlIdToReplace="";this.ZV20ddo_SecUserNameTitleControlIdToReplace="";this.OV20ddo_SecUserNameTitleControlIdToReplace="";this.A87JC_ProviderID=0;this.Z87JC_ProviderID=0;this.O87JC_ProviderID=0;this.AV14OrderedBy=0;this.ZV14OrderedBy=0;this.OV14OrderedBy=0;this.AV15OrderedDsc=!1;this.ZV15OrderedDsc=!1;this.OV15OrderedDsc=!1;this.AV24GridCurrentPage=0;this.AV21DDO_TitleSettingsIcons={Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""};this.AV18ddo_SecUserIdTitleControlIdToReplace="";this.AV20ddo_SecUserNameTitleControlIdToReplace="";this.A87JC_ProviderID=0;this.AV14OrderedBy=0;this.AV15OrderedDsc=!1;this.AV8JC_ProviderID=0;this.AV27Update="";this.AV28Delete="";this.AV29Display="";this.A6SecUserId=0;this.A14SecUserName="";this.AV36Pgmname="";this.AV30IsAuthorized_SecUserName=!1;this.Events={e118l2_client:["GRIDPAGINATIONBAR.CHANGEPAGE",!0],e128l2_client:["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",!0],e138l2_client:["DDO_SECUSERID.ONOPTIONCLICKED",!0],e148l2_client:["DDO_SECUSERNAME.ONOPTIONCLICKED",!0],e158l2_client:["'DOINSERT'",!0],e198l2_client:["ENTER",!0],e208l2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{av:"AV8JC_ProviderID",fld:"vJC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"sPrefix"},{av:"AV18ddo_SecUserIdTitleControlIdToReplace",fld:"vDDO_SECUSERIDTITLECONTROLIDTOREPLACE",pic:""},{av:"AV20ddo_SecUserNameTitleControlIdToReplace",fld:"vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",pic:""},{ctrl:"GRID",prop:"Rows"},{av:"AV36Pgmname",fld:"vPGMNAME",pic:""},{av:"AV14OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:"AV15OrderedDsc",fld:"vORDEREDDSC",pic:""},{av:"AV30IsAuthorized_SecUserName",fld:"vISAUTHORIZED_SECUSERNAME",pic:"",hsh:!0},{av:"A87JC_ProviderID",fld:"JC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[{av:"AV17SecUserIdTitleFilterData",fld:"vSECUSERIDTITLEFILTERDATA",pic:""},{av:"AV19SecUserNameTitleFilterData",fld:"vSECUSERNAMETITLEFILTERDATA",pic:""},{ctrl:"SECUSERID",prop:"Titleformat"},{av:'gx.fn.getCtrlProperty("SECUSERID","Title")',ctrl:"SECUSERID",prop:"Title"},{ctrl:"SECUSERNAME",prop:"Titleformat"},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Title")',ctrl:"SECUSERNAME",prop:"Title"},{av:"AV24GridCurrentPage",fld:"vGRIDCURRENTPAGE",pic:"ZZZZZZZZZ9"},{av:"AV25GridPageSize",fld:"vGRIDPAGESIZE",pic:"ZZZZZZZZZ9"},{av:"AV26GridRecordCount",fld:"vGRIDRECORDCOUNT",pic:"ZZZZZZZZZ9"}]];this.EvtParms.START=[[{av:"AV14OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:"AV36Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8JC_ProviderID",fld:"vJC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[{ctrl:"GRID",prop:"Rows"},{av:"AV30IsAuthorized_SecUserName",fld:"vISAUTHORIZED_SECUSERNAME",pic:"",hsh:!0},{av:"this.DDO_SECUSERIDContainer.TitleControlIdToReplace",ctrl:"DDO_SECUSERID",prop:"TitleControlIdToReplace"},{av:"AV18ddo_SecUserIdTitleControlIdToReplace",fld:"vDDO_SECUSERIDTITLECONTROLIDTOREPLACE",pic:""},{av:'gx.fn.getCtrlProperty("vDDO_SECUSERIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:"vDDO_SECUSERIDTITLECONTROLIDTOREPLACE",prop:"Visible"},{av:"this.DDO_SECUSERNAMEContainer.TitleControlIdToReplace",ctrl:"DDO_SECUSERNAME",prop:"TitleControlIdToReplace"},{av:"AV20ddo_SecUserNameTitleControlIdToReplace",fld:"vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",pic:""},{av:'gx.fn.getCtrlProperty("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:"vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",prop:"Visible"},{av:'gx.fn.getCtrlProperty("JC_PROVIDERID","Visible")',ctrl:"JC_PROVIDERID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:"vORDEREDBY",prop:"Visible"},{av:"AV14OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:"vORDEREDDSC",prop:"Visible"},{av:"AV21DDO_TitleSettingsIcons",fld:"vDDO_TITLESETTINGSICONS",pic:""},{av:"this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue",ctrl:"GRIDPAGINATIONBAR",prop:"RowsPerPageSelectedValue"},{av:"AV15OrderedDsc",fld:"vORDEREDDSC",pic:""}]];this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"]=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:"AV15OrderedDsc",fld:"vORDEREDDSC",pic:""},{av:"AV8JC_ProviderID",fld:"vJC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV18ddo_SecUserIdTitleControlIdToReplace",fld:"vDDO_SECUSERIDTITLECONTROLIDTOREPLACE",pic:""},{av:"AV20ddo_SecUserNameTitleControlIdToReplace",fld:"vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",pic:""},{av:"AV36Pgmname",fld:"vPGMNAME",pic:""},{av:"AV30IsAuthorized_SecUserName",fld:"vISAUTHORIZED_SECUSERNAME",pic:"",hsh:!0},{av:"A87JC_ProviderID",fld:"JC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"sPrefix"},{av:"this.GRIDPAGINATIONBARContainer.SelectedPage",ctrl:"GRIDPAGINATIONBAR",prop:"SelectedPage"}],[]];this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"]=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:"AV15OrderedDsc",fld:"vORDEREDDSC",pic:""},{av:"AV8JC_ProviderID",fld:"vJC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV18ddo_SecUserIdTitleControlIdToReplace",fld:"vDDO_SECUSERIDTITLECONTROLIDTOREPLACE",pic:""},{av:"AV20ddo_SecUserNameTitleControlIdToReplace",fld:"vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",pic:""},{av:"AV36Pgmname",fld:"vPGMNAME",pic:""},{av:"AV30IsAuthorized_SecUserName",fld:"vISAUTHORIZED_SECUSERNAME",pic:"",hsh:!0},{av:"A87JC_ProviderID",fld:"JC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"sPrefix"},{av:"this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue",ctrl:"GRIDPAGINATIONBAR",prop:"RowsPerPageSelectedValue"}],[{ctrl:"GRID",prop:"Rows"}]];this.EvtParms["DDO_SECUSERID.ONOPTIONCLICKED"]=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:"AV15OrderedDsc",fld:"vORDEREDDSC",pic:""},{av:"AV8JC_ProviderID",fld:"vJC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV18ddo_SecUserIdTitleControlIdToReplace",fld:"vDDO_SECUSERIDTITLECONTROLIDTOREPLACE",pic:""},{av:"AV20ddo_SecUserNameTitleControlIdToReplace",fld:"vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",pic:""},{av:"AV36Pgmname",fld:"vPGMNAME",pic:""},{av:"AV30IsAuthorized_SecUserName",fld:"vISAUTHORIZED_SECUSERNAME",pic:"",hsh:!0},{av:"A87JC_ProviderID",fld:"JC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"sPrefix"},{av:"this.DDO_SECUSERIDContainer.ActiveEventKey",ctrl:"DDO_SECUSERID",prop:"ActiveEventKey"}],[{av:"AV14OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:"AV15OrderedDsc",fld:"vORDEREDDSC",pic:""},{av:"this.DDO_SECUSERIDContainer.SortedStatus",ctrl:"DDO_SECUSERID",prop:"SortedStatus"},{av:"AV17SecUserIdTitleFilterData",fld:"vSECUSERIDTITLEFILTERDATA",pic:""},{av:"AV19SecUserNameTitleFilterData",fld:"vSECUSERNAMETITLEFILTERDATA",pic:""},{ctrl:"SECUSERID",prop:"Titleformat"},{av:'gx.fn.getCtrlProperty("SECUSERID","Title")',ctrl:"SECUSERID",prop:"Title"},{ctrl:"SECUSERNAME",prop:"Titleformat"},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Title")',ctrl:"SECUSERNAME",prop:"Title"},{av:"AV24GridCurrentPage",fld:"vGRIDCURRENTPAGE",pic:"ZZZZZZZZZ9"},{av:"AV25GridPageSize",fld:"vGRIDPAGESIZE",pic:"ZZZZZZZZZ9"},{av:"AV26GridRecordCount",fld:"vGRIDRECORDCOUNT",pic:"ZZZZZZZZZ9"}]];this.EvtParms["DDO_SECUSERNAME.ONOPTIONCLICKED"]=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:"AV15OrderedDsc",fld:"vORDEREDDSC",pic:""},{av:"AV8JC_ProviderID",fld:"vJC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV18ddo_SecUserIdTitleControlIdToReplace",fld:"vDDO_SECUSERIDTITLECONTROLIDTOREPLACE",pic:""},{av:"AV20ddo_SecUserNameTitleControlIdToReplace",fld:"vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",pic:""},{av:"AV36Pgmname",fld:"vPGMNAME",pic:""},{av:"AV30IsAuthorized_SecUserName",fld:"vISAUTHORIZED_SECUSERNAME",pic:"",hsh:!0},{av:"A87JC_ProviderID",fld:"JC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"sPrefix"},{av:"this.DDO_SECUSERNAMEContainer.ActiveEventKey",ctrl:"DDO_SECUSERNAME",prop:"ActiveEventKey"}],[{av:"AV14OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:"AV15OrderedDsc",fld:"vORDEREDDSC",pic:""},{av:"this.DDO_SECUSERNAMEContainer.SortedStatus",ctrl:"DDO_SECUSERNAME",prop:"SortedStatus"},{av:"AV17SecUserIdTitleFilterData",fld:"vSECUSERIDTITLEFILTERDATA",pic:""},{av:"AV19SecUserNameTitleFilterData",fld:"vSECUSERNAMETITLEFILTERDATA",pic:""},{ctrl:"SECUSERID",prop:"Titleformat"},{av:'gx.fn.getCtrlProperty("SECUSERID","Title")',ctrl:"SECUSERID",prop:"Title"},{ctrl:"SECUSERNAME",prop:"Titleformat"},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Title")',ctrl:"SECUSERNAME",prop:"Title"},{av:"AV24GridCurrentPage",fld:"vGRIDCURRENTPAGE",pic:"ZZZZZZZZZ9"},{av:"AV25GridPageSize",fld:"vGRIDPAGESIZE",pic:"ZZZZZZZZZ9"},{av:"AV26GridRecordCount",fld:"vGRIDRECORDCOUNT",pic:"ZZZZZZZZZ9"}]];this.EvtParms["GRID.LOAD"]=[[{av:"A6SecUserId",fld:"SECUSERID",pic:"ZZZ9"},{av:"A87JC_ProviderID",fld:"JC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV30IsAuthorized_SecUserName",fld:"vISAUTHORIZED_SECUSERNAME",pic:"",hsh:!0}],[{av:"AV27Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:"AV28Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:"AV29Display",fld:"vDISPLAY",pic:""},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:"vDISPLAY",prop:"Tooltiptext"},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:"vDISPLAY",prop:"Link"},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Link")',ctrl:"SECUSERNAME",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A6SecUserId",fld:"SECUSERID",pic:"ZZZ9"},{av:"AV8JC_ProviderID",fld:"vJC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[{av:"AV8JC_ProviderID",fld:"vJC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"A6SecUserId",fld:"SECUSERID",pic:"ZZZ9"}]];this.setVCMap("AV36Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV30IsAuthorized_SecUserName","vISAUTHORIZED_SECUSERNAME",0,"boolean",4,0);this.setVCMap("AV8JC_ProviderID","vJC_PROVIDERID",0,"int",18,0);this.setVCMap("AV8JC_ProviderID","vJC_PROVIDERID",0,"int",18,0);this.setVCMap("AV36Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV30IsAuthorized_SecUserName","vISAUTHORIZED_SECUSERNAME",0,"boolean",4,0);this.setVCMap("AV8JC_ProviderID","vJC_PROVIDERID",0,"int",18,0);this.setVCMap("AV36Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV30IsAuthorized_SecUserName","vISAUTHORIZED_SECUSERNAME",0,"boolean",4,0);e.addRefreshingVar(this.GXValidFnc[52]);e.addRefreshingVar(this.GXValidFnc[53]);e.addRefreshingVar({rfrVar:"AV8JC_ProviderID"});e.addRefreshingVar(this.GXValidFnc[47]);e.addRefreshingVar(this.GXValidFnc[49]);e.addRefreshingVar({rfrVar:"AV36Pgmname"});e.addRefreshingVar({rfrVar:"AV30IsAuthorized_SecUserName"});e.addRefreshingVar(this.GXValidFnc[50]);this.Initialize()})