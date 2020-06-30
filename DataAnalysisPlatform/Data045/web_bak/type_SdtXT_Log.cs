/*
               File: type_SdtXT_Log
        Description: 系统日志
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:27.84
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "XT_Log" )]
   [XmlType(TypeName =  "XT_Log" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtXT_Log : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtXT_Log( )
      {
      }

      public SdtXT_Log( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( long AV173XT_LogID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV173XT_LogID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"XT_LogID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "XT_Log");
         metadata.Set("BT", "XT_Log");
         metadata.Set("PK", "[ \"XT_LogID\" ]");
         metadata.Set("PKAssigned", "[ \"XT_LogID\" ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Xt_logid_Z");
         state.Add("gxTpr_Xt_loguserid_Z");
         state.Add("gxTpr_Xt_logsecusername_Z");
         state.Add("gxTpr_Xt_logtime_Z_Nullable");
         state.Add("gxTpr_Xt_logpage_Z");
         state.Add("gxTpr_Xt_logbuttonname_Z");
         state.Add("gxTpr_Xt_logtype_Z");
         state.Add("gxTpr_Xt_logproviderid_Z");
         state.Add("gxTpr_Xt_logprovidername_Z");
         state.Add("gxTpr_Xt_logtarget_Z");
         state.Add("gxTpr_Xt_logsontarget_Z");
         state.Add("gxTpr_Xt_logtargetmodule_Z");
         state.Add("gxTpr_Xt_logtargetsonmodule_Z");
         state.Add("gxTpr_Xt_logtargetoperate_Z");
         state.Add("gxTpr_Xt_logdescription_Z");
         state.Add("gxTpr_Xt_loguserid_N");
         state.Add("gxTpr_Xt_logsecusername_N");
         state.Add("gxTpr_Xt_logtime_N");
         state.Add("gxTpr_Xt_logpage_N");
         state.Add("gxTpr_Xt_logbuttonname_N");
         state.Add("gxTpr_Xt_logtype_N");
         state.Add("gxTpr_Xt_logproviderid_N");
         state.Add("gxTpr_Xt_logprovidername_N");
         state.Add("gxTpr_Xt_logtarget_N");
         state.Add("gxTpr_Xt_logsontarget_N");
         state.Add("gxTpr_Xt_logtargetmodule_N");
         state.Add("gxTpr_Xt_logtargetsonmodule_N");
         state.Add("gxTpr_Xt_logtargetoperate_N");
         state.Add("gxTpr_Xt_logdescription_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtXT_Log sdt ;
         sdt = (SdtXT_Log)(source);
         gxTv_SdtXT_Log_Xt_logid = sdt.gxTv_SdtXT_Log_Xt_logid ;
         gxTv_SdtXT_Log_Xt_loguserid = sdt.gxTv_SdtXT_Log_Xt_loguserid ;
         gxTv_SdtXT_Log_Xt_logsecusername = sdt.gxTv_SdtXT_Log_Xt_logsecusername ;
         gxTv_SdtXT_Log_Xt_logtime = sdt.gxTv_SdtXT_Log_Xt_logtime ;
         gxTv_SdtXT_Log_Xt_logpage = sdt.gxTv_SdtXT_Log_Xt_logpage ;
         gxTv_SdtXT_Log_Xt_logbuttonname = sdt.gxTv_SdtXT_Log_Xt_logbuttonname ;
         gxTv_SdtXT_Log_Xt_logtype = sdt.gxTv_SdtXT_Log_Xt_logtype ;
         gxTv_SdtXT_Log_Xt_logproviderid = sdt.gxTv_SdtXT_Log_Xt_logproviderid ;
         gxTv_SdtXT_Log_Xt_logprovidername = sdt.gxTv_SdtXT_Log_Xt_logprovidername ;
         gxTv_SdtXT_Log_Xt_logtarget = sdt.gxTv_SdtXT_Log_Xt_logtarget ;
         gxTv_SdtXT_Log_Xt_logsontarget = sdt.gxTv_SdtXT_Log_Xt_logsontarget ;
         gxTv_SdtXT_Log_Xt_logtargetmodule = sdt.gxTv_SdtXT_Log_Xt_logtargetmodule ;
         gxTv_SdtXT_Log_Xt_logtargetsonmodule = sdt.gxTv_SdtXT_Log_Xt_logtargetsonmodule ;
         gxTv_SdtXT_Log_Xt_logtargetoperate = sdt.gxTv_SdtXT_Log_Xt_logtargetoperate ;
         gxTv_SdtXT_Log_Xt_logdescription = sdt.gxTv_SdtXT_Log_Xt_logdescription ;
         gxTv_SdtXT_Log_Mode = sdt.gxTv_SdtXT_Log_Mode ;
         gxTv_SdtXT_Log_Initialized = sdt.gxTv_SdtXT_Log_Initialized ;
         gxTv_SdtXT_Log_Xt_logid_Z = sdt.gxTv_SdtXT_Log_Xt_logid_Z ;
         gxTv_SdtXT_Log_Xt_loguserid_Z = sdt.gxTv_SdtXT_Log_Xt_loguserid_Z ;
         gxTv_SdtXT_Log_Xt_logsecusername_Z = sdt.gxTv_SdtXT_Log_Xt_logsecusername_Z ;
         gxTv_SdtXT_Log_Xt_logtime_Z = sdt.gxTv_SdtXT_Log_Xt_logtime_Z ;
         gxTv_SdtXT_Log_Xt_logpage_Z = sdt.gxTv_SdtXT_Log_Xt_logpage_Z ;
         gxTv_SdtXT_Log_Xt_logbuttonname_Z = sdt.gxTv_SdtXT_Log_Xt_logbuttonname_Z ;
         gxTv_SdtXT_Log_Xt_logtype_Z = sdt.gxTv_SdtXT_Log_Xt_logtype_Z ;
         gxTv_SdtXT_Log_Xt_logproviderid_Z = sdt.gxTv_SdtXT_Log_Xt_logproviderid_Z ;
         gxTv_SdtXT_Log_Xt_logprovidername_Z = sdt.gxTv_SdtXT_Log_Xt_logprovidername_Z ;
         gxTv_SdtXT_Log_Xt_logtarget_Z = sdt.gxTv_SdtXT_Log_Xt_logtarget_Z ;
         gxTv_SdtXT_Log_Xt_logsontarget_Z = sdt.gxTv_SdtXT_Log_Xt_logsontarget_Z ;
         gxTv_SdtXT_Log_Xt_logtargetmodule_Z = sdt.gxTv_SdtXT_Log_Xt_logtargetmodule_Z ;
         gxTv_SdtXT_Log_Xt_logtargetsonmodule_Z = sdt.gxTv_SdtXT_Log_Xt_logtargetsonmodule_Z ;
         gxTv_SdtXT_Log_Xt_logtargetoperate_Z = sdt.gxTv_SdtXT_Log_Xt_logtargetoperate_Z ;
         gxTv_SdtXT_Log_Xt_logdescription_Z = sdt.gxTv_SdtXT_Log_Xt_logdescription_Z ;
         gxTv_SdtXT_Log_Xt_loguserid_N = sdt.gxTv_SdtXT_Log_Xt_loguserid_N ;
         gxTv_SdtXT_Log_Xt_logsecusername_N = sdt.gxTv_SdtXT_Log_Xt_logsecusername_N ;
         gxTv_SdtXT_Log_Xt_logtime_N = sdt.gxTv_SdtXT_Log_Xt_logtime_N ;
         gxTv_SdtXT_Log_Xt_logpage_N = sdt.gxTv_SdtXT_Log_Xt_logpage_N ;
         gxTv_SdtXT_Log_Xt_logbuttonname_N = sdt.gxTv_SdtXT_Log_Xt_logbuttonname_N ;
         gxTv_SdtXT_Log_Xt_logtype_N = sdt.gxTv_SdtXT_Log_Xt_logtype_N ;
         gxTv_SdtXT_Log_Xt_logproviderid_N = sdt.gxTv_SdtXT_Log_Xt_logproviderid_N ;
         gxTv_SdtXT_Log_Xt_logprovidername_N = sdt.gxTv_SdtXT_Log_Xt_logprovidername_N ;
         gxTv_SdtXT_Log_Xt_logtarget_N = sdt.gxTv_SdtXT_Log_Xt_logtarget_N ;
         gxTv_SdtXT_Log_Xt_logsontarget_N = sdt.gxTv_SdtXT_Log_Xt_logsontarget_N ;
         gxTv_SdtXT_Log_Xt_logtargetmodule_N = sdt.gxTv_SdtXT_Log_Xt_logtargetmodule_N ;
         gxTv_SdtXT_Log_Xt_logtargetsonmodule_N = sdt.gxTv_SdtXT_Log_Xt_logtargetsonmodule_N ;
         gxTv_SdtXT_Log_Xt_logtargetoperate_N = sdt.gxTv_SdtXT_Log_Xt_logtargetoperate_N ;
         gxTv_SdtXT_Log_Xt_logdescription_N = sdt.gxTv_SdtXT_Log_Xt_logdescription_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_Log_Xt_logid), 18, 0)), false);
         AddObjectProperty("XT_LogUserID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_Log_Xt_loguserid), 18, 0)), false);
         AddObjectProperty("XT_LogUserID_N", gxTv_SdtXT_Log_Xt_loguserid_N, false);
         AddObjectProperty("XT_LogSecUserName", gxTv_SdtXT_Log_Xt_logsecusername, false);
         AddObjectProperty("XT_LogSecUserName_N", gxTv_SdtXT_Log_Xt_logsecusername_N, false);
         datetime_STZ = gxTv_SdtXT_Log_Xt_logtime;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("XT_LogTime", sDateCnv, false);
         AddObjectProperty("XT_LogTime_N", gxTv_SdtXT_Log_Xt_logtime_N, false);
         AddObjectProperty("XT_LogPage", gxTv_SdtXT_Log_Xt_logpage, false);
         AddObjectProperty("XT_LogPage_N", gxTv_SdtXT_Log_Xt_logpage_N, false);
         AddObjectProperty("XT_LogButtonName", gxTv_SdtXT_Log_Xt_logbuttonname, false);
         AddObjectProperty("XT_LogButtonName_N", gxTv_SdtXT_Log_Xt_logbuttonname_N, false);
         AddObjectProperty("XT_LogType", gxTv_SdtXT_Log_Xt_logtype, false);
         AddObjectProperty("XT_LogType_N", gxTv_SdtXT_Log_Xt_logtype_N, false);
         AddObjectProperty("XT_LogProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_Log_Xt_logproviderid), 18, 0)), false);
         AddObjectProperty("XT_LogProviderID_N", gxTv_SdtXT_Log_Xt_logproviderid_N, false);
         AddObjectProperty("XT_LogProviderName", gxTv_SdtXT_Log_Xt_logprovidername, false);
         AddObjectProperty("XT_LogProviderName_N", gxTv_SdtXT_Log_Xt_logprovidername_N, false);
         AddObjectProperty("XT_LogTarget", gxTv_SdtXT_Log_Xt_logtarget, false);
         AddObjectProperty("XT_LogTarget_N", gxTv_SdtXT_Log_Xt_logtarget_N, false);
         AddObjectProperty("XT_LogSonTarget", gxTv_SdtXT_Log_Xt_logsontarget, false);
         AddObjectProperty("XT_LogSonTarget_N", gxTv_SdtXT_Log_Xt_logsontarget_N, false);
         AddObjectProperty("XT_LogTargetModule", gxTv_SdtXT_Log_Xt_logtargetmodule, false);
         AddObjectProperty("XT_LogTargetModule_N", gxTv_SdtXT_Log_Xt_logtargetmodule_N, false);
         AddObjectProperty("XT_LogTargetSonModule", gxTv_SdtXT_Log_Xt_logtargetsonmodule, false);
         AddObjectProperty("XT_LogTargetSonModule_N", gxTv_SdtXT_Log_Xt_logtargetsonmodule_N, false);
         AddObjectProperty("XT_LogTargetOperate", gxTv_SdtXT_Log_Xt_logtargetoperate, false);
         AddObjectProperty("XT_LogTargetOperate_N", gxTv_SdtXT_Log_Xt_logtargetoperate_N, false);
         AddObjectProperty("XT_LogDescription", gxTv_SdtXT_Log_Xt_logdescription, false);
         AddObjectProperty("XT_LogDescription_N", gxTv_SdtXT_Log_Xt_logdescription_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtXT_Log_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtXT_Log_Initialized, false);
            AddObjectProperty("XT_LogID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_Log_Xt_logid_Z), 18, 0)), false);
            AddObjectProperty("XT_LogUserID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_Log_Xt_loguserid_Z), 18, 0)), false);
            AddObjectProperty("XT_LogSecUserName_Z", gxTv_SdtXT_Log_Xt_logsecusername_Z, false);
            datetime_STZ = gxTv_SdtXT_Log_Xt_logtime_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("XT_LogTime_Z", sDateCnv, false);
            AddObjectProperty("XT_LogPage_Z", gxTv_SdtXT_Log_Xt_logpage_Z, false);
            AddObjectProperty("XT_LogButtonName_Z", gxTv_SdtXT_Log_Xt_logbuttonname_Z, false);
            AddObjectProperty("XT_LogType_Z", gxTv_SdtXT_Log_Xt_logtype_Z, false);
            AddObjectProperty("XT_LogProviderID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_Log_Xt_logproviderid_Z), 18, 0)), false);
            AddObjectProperty("XT_LogProviderName_Z", gxTv_SdtXT_Log_Xt_logprovidername_Z, false);
            AddObjectProperty("XT_LogTarget_Z", gxTv_SdtXT_Log_Xt_logtarget_Z, false);
            AddObjectProperty("XT_LogSonTarget_Z", gxTv_SdtXT_Log_Xt_logsontarget_Z, false);
            AddObjectProperty("XT_LogTargetModule_Z", gxTv_SdtXT_Log_Xt_logtargetmodule_Z, false);
            AddObjectProperty("XT_LogTargetSonModule_Z", gxTv_SdtXT_Log_Xt_logtargetsonmodule_Z, false);
            AddObjectProperty("XT_LogTargetOperate_Z", gxTv_SdtXT_Log_Xt_logtargetoperate_Z, false);
            AddObjectProperty("XT_LogDescription_Z", gxTv_SdtXT_Log_Xt_logdescription_Z, false);
            AddObjectProperty("XT_LogUserID_N", gxTv_SdtXT_Log_Xt_loguserid_N, false);
            AddObjectProperty("XT_LogSecUserName_N", gxTv_SdtXT_Log_Xt_logsecusername_N, false);
            AddObjectProperty("XT_LogTime_N", gxTv_SdtXT_Log_Xt_logtime_N, false);
            AddObjectProperty("XT_LogPage_N", gxTv_SdtXT_Log_Xt_logpage_N, false);
            AddObjectProperty("XT_LogButtonName_N", gxTv_SdtXT_Log_Xt_logbuttonname_N, false);
            AddObjectProperty("XT_LogType_N", gxTv_SdtXT_Log_Xt_logtype_N, false);
            AddObjectProperty("XT_LogProviderID_N", gxTv_SdtXT_Log_Xt_logproviderid_N, false);
            AddObjectProperty("XT_LogProviderName_N", gxTv_SdtXT_Log_Xt_logprovidername_N, false);
            AddObjectProperty("XT_LogTarget_N", gxTv_SdtXT_Log_Xt_logtarget_N, false);
            AddObjectProperty("XT_LogSonTarget_N", gxTv_SdtXT_Log_Xt_logsontarget_N, false);
            AddObjectProperty("XT_LogTargetModule_N", gxTv_SdtXT_Log_Xt_logtargetmodule_N, false);
            AddObjectProperty("XT_LogTargetSonModule_N", gxTv_SdtXT_Log_Xt_logtargetsonmodule_N, false);
            AddObjectProperty("XT_LogTargetOperate_N", gxTv_SdtXT_Log_Xt_logtargetoperate_N, false);
            AddObjectProperty("XT_LogDescription_N", gxTv_SdtXT_Log_Xt_logdescription_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtXT_Log sdt )
      {
         if ( sdt.IsDirty("XT_LogID") )
         {
            gxTv_SdtXT_Log_Xt_logid = sdt.gxTv_SdtXT_Log_Xt_logid ;
         }
         if ( sdt.IsDirty("XT_LogUserID") )
         {
            gxTv_SdtXT_Log_Xt_loguserid = sdt.gxTv_SdtXT_Log_Xt_loguserid ;
         }
         if ( sdt.IsDirty("XT_LogSecUserName") )
         {
            gxTv_SdtXT_Log_Xt_logsecusername = sdt.gxTv_SdtXT_Log_Xt_logsecusername ;
         }
         if ( sdt.IsDirty("XT_LogTime") )
         {
            gxTv_SdtXT_Log_Xt_logtime = sdt.gxTv_SdtXT_Log_Xt_logtime ;
         }
         if ( sdt.IsDirty("XT_LogPage") )
         {
            gxTv_SdtXT_Log_Xt_logpage = sdt.gxTv_SdtXT_Log_Xt_logpage ;
         }
         if ( sdt.IsDirty("XT_LogButtonName") )
         {
            gxTv_SdtXT_Log_Xt_logbuttonname = sdt.gxTv_SdtXT_Log_Xt_logbuttonname ;
         }
         if ( sdt.IsDirty("XT_LogType") )
         {
            gxTv_SdtXT_Log_Xt_logtype = sdt.gxTv_SdtXT_Log_Xt_logtype ;
         }
         if ( sdt.IsDirty("XT_LogProviderID") )
         {
            gxTv_SdtXT_Log_Xt_logproviderid = sdt.gxTv_SdtXT_Log_Xt_logproviderid ;
         }
         if ( sdt.IsDirty("XT_LogProviderName") )
         {
            gxTv_SdtXT_Log_Xt_logprovidername = sdt.gxTv_SdtXT_Log_Xt_logprovidername ;
         }
         if ( sdt.IsDirty("XT_LogTarget") )
         {
            gxTv_SdtXT_Log_Xt_logtarget = sdt.gxTv_SdtXT_Log_Xt_logtarget ;
         }
         if ( sdt.IsDirty("XT_LogSonTarget") )
         {
            gxTv_SdtXT_Log_Xt_logsontarget = sdt.gxTv_SdtXT_Log_Xt_logsontarget ;
         }
         if ( sdt.IsDirty("XT_LogTargetModule") )
         {
            gxTv_SdtXT_Log_Xt_logtargetmodule = sdt.gxTv_SdtXT_Log_Xt_logtargetmodule ;
         }
         if ( sdt.IsDirty("XT_LogTargetSonModule") )
         {
            gxTv_SdtXT_Log_Xt_logtargetsonmodule = sdt.gxTv_SdtXT_Log_Xt_logtargetsonmodule ;
         }
         if ( sdt.IsDirty("XT_LogTargetOperate") )
         {
            gxTv_SdtXT_Log_Xt_logtargetoperate = sdt.gxTv_SdtXT_Log_Xt_logtargetoperate ;
         }
         if ( sdt.IsDirty("XT_LogDescription") )
         {
            gxTv_SdtXT_Log_Xt_logdescription = sdt.gxTv_SdtXT_Log_Xt_logdescription ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "XT_LogID" )]
      [  XmlElement( ElementName = "XT_LogID"   )]
      public long gxTpr_Xt_logid
      {
         get {
            return gxTv_SdtXT_Log_Xt_logid ;
         }

         set {
            if ( gxTv_SdtXT_Log_Xt_logid != value )
            {
               gxTv_SdtXT_Log_Mode = "INS";
               this.gxTv_SdtXT_Log_Xt_logid_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_loguserid_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_logsecusername_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_logtime_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_logpage_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_logbuttonname_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_logtype_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_logproviderid_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_logprovidername_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_logtarget_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_logsontarget_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_logtargetmodule_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_logtargetsonmodule_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_logtargetoperate_Z_SetNull( );
               this.gxTv_SdtXT_Log_Xt_logdescription_Z_SetNull( );
            }
            gxTv_SdtXT_Log_Xt_logid = value;
            SetDirty("Xt_logid");
         }

      }

      [  SoapElement( ElementName = "XT_LogUserID" )]
      [  XmlElement( ElementName = "XT_LogUserID"   )]
      public long gxTpr_Xt_loguserid
      {
         get {
            return gxTv_SdtXT_Log_Xt_loguserid ;
         }

         set {
            gxTv_SdtXT_Log_Xt_loguserid_N = 0;
            gxTv_SdtXT_Log_Xt_loguserid = value;
            SetDirty("Xt_loguserid");
         }

      }

      public void gxTv_SdtXT_Log_Xt_loguserid_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_loguserid_N = 1;
         gxTv_SdtXT_Log_Xt_loguserid = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_loguserid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogSecUserName" )]
      [  XmlElement( ElementName = "XT_LogSecUserName"   )]
      public String gxTpr_Xt_logsecusername
      {
         get {
            return gxTv_SdtXT_Log_Xt_logsecusername ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logsecusername_N = 0;
            gxTv_SdtXT_Log_Xt_logsecusername = value;
            SetDirty("Xt_logsecusername");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logsecusername_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logsecusername_N = 1;
         gxTv_SdtXT_Log_Xt_logsecusername = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logsecusername_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTime" )]
      [  XmlElement( ElementName = "XT_LogTime"  , IsNullable=true )]
      public string gxTpr_Xt_logtime_Nullable
      {
         get {
            if ( gxTv_SdtXT_Log_Xt_logtime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtXT_Log_Xt_logtime).value ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtime_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtXT_Log_Xt_logtime = DateTime.MinValue;
            else
               gxTv_SdtXT_Log_Xt_logtime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Xt_logtime
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtime ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtime_N = 0;
            gxTv_SdtXT_Log_Xt_logtime = value;
            SetDirty("Xt_logtime");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtime_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtime_N = 1;
         gxTv_SdtXT_Log_Xt_logtime = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtime_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogPage" )]
      [  XmlElement( ElementName = "XT_LogPage"   )]
      public String gxTpr_Xt_logpage
      {
         get {
            return gxTv_SdtXT_Log_Xt_logpage ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logpage_N = 0;
            gxTv_SdtXT_Log_Xt_logpage = value;
            SetDirty("Xt_logpage");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logpage_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logpage_N = 1;
         gxTv_SdtXT_Log_Xt_logpage = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logpage_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogButtonName" )]
      [  XmlElement( ElementName = "XT_LogButtonName"   )]
      public String gxTpr_Xt_logbuttonname
      {
         get {
            return gxTv_SdtXT_Log_Xt_logbuttonname ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logbuttonname_N = 0;
            gxTv_SdtXT_Log_Xt_logbuttonname = value;
            SetDirty("Xt_logbuttonname");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logbuttonname_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logbuttonname_N = 1;
         gxTv_SdtXT_Log_Xt_logbuttonname = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logbuttonname_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogType" )]
      [  XmlElement( ElementName = "XT_LogType"   )]
      public String gxTpr_Xt_logtype
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtype ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtype_N = 0;
            gxTv_SdtXT_Log_Xt_logtype = value;
            SetDirty("Xt_logtype");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtype_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtype_N = 1;
         gxTv_SdtXT_Log_Xt_logtype = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtype_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogProviderID" )]
      [  XmlElement( ElementName = "XT_LogProviderID"   )]
      public long gxTpr_Xt_logproviderid
      {
         get {
            return gxTv_SdtXT_Log_Xt_logproviderid ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logproviderid_N = 0;
            gxTv_SdtXT_Log_Xt_logproviderid = value;
            SetDirty("Xt_logproviderid");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logproviderid_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logproviderid_N = 1;
         gxTv_SdtXT_Log_Xt_logproviderid = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logproviderid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogProviderName" )]
      [  XmlElement( ElementName = "XT_LogProviderName"   )]
      public String gxTpr_Xt_logprovidername
      {
         get {
            return gxTv_SdtXT_Log_Xt_logprovidername ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logprovidername_N = 0;
            gxTv_SdtXT_Log_Xt_logprovidername = value;
            SetDirty("Xt_logprovidername");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logprovidername_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logprovidername_N = 1;
         gxTv_SdtXT_Log_Xt_logprovidername = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logprovidername_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTarget" )]
      [  XmlElement( ElementName = "XT_LogTarget"   )]
      public String gxTpr_Xt_logtarget
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtarget ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtarget_N = 0;
            gxTv_SdtXT_Log_Xt_logtarget = value;
            SetDirty("Xt_logtarget");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtarget_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtarget_N = 1;
         gxTv_SdtXT_Log_Xt_logtarget = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtarget_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogSonTarget" )]
      [  XmlElement( ElementName = "XT_LogSonTarget"   )]
      public String gxTpr_Xt_logsontarget
      {
         get {
            return gxTv_SdtXT_Log_Xt_logsontarget ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logsontarget_N = 0;
            gxTv_SdtXT_Log_Xt_logsontarget = value;
            SetDirty("Xt_logsontarget");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logsontarget_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logsontarget_N = 1;
         gxTv_SdtXT_Log_Xt_logsontarget = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logsontarget_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTargetModule" )]
      [  XmlElement( ElementName = "XT_LogTargetModule"   )]
      public String gxTpr_Xt_logtargetmodule
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtargetmodule ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtargetmodule_N = 0;
            gxTv_SdtXT_Log_Xt_logtargetmodule = value;
            SetDirty("Xt_logtargetmodule");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtargetmodule_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtargetmodule_N = 1;
         gxTv_SdtXT_Log_Xt_logtargetmodule = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtargetmodule_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTargetSonModule" )]
      [  XmlElement( ElementName = "XT_LogTargetSonModule"   )]
      public String gxTpr_Xt_logtargetsonmodule
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtargetsonmodule ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtargetsonmodule_N = 0;
            gxTv_SdtXT_Log_Xt_logtargetsonmodule = value;
            SetDirty("Xt_logtargetsonmodule");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtargetsonmodule_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtargetsonmodule_N = 1;
         gxTv_SdtXT_Log_Xt_logtargetsonmodule = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtargetsonmodule_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTargetOperate" )]
      [  XmlElement( ElementName = "XT_LogTargetOperate"   )]
      public String gxTpr_Xt_logtargetoperate
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtargetoperate ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtargetoperate_N = 0;
            gxTv_SdtXT_Log_Xt_logtargetoperate = value;
            SetDirty("Xt_logtargetoperate");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtargetoperate_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtargetoperate_N = 1;
         gxTv_SdtXT_Log_Xt_logtargetoperate = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtargetoperate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogDescription" )]
      [  XmlElement( ElementName = "XT_LogDescription"   )]
      public String gxTpr_Xt_logdescription
      {
         get {
            return gxTv_SdtXT_Log_Xt_logdescription ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logdescription_N = 0;
            gxTv_SdtXT_Log_Xt_logdescription = value;
            SetDirty("Xt_logdescription");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logdescription_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logdescription_N = 1;
         gxTv_SdtXT_Log_Xt_logdescription = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logdescription_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtXT_Log_Mode ;
         }

         set {
            gxTv_SdtXT_Log_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtXT_Log_Mode_SetNull( )
      {
         gxTv_SdtXT_Log_Mode = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtXT_Log_Initialized ;
         }

         set {
            gxTv_SdtXT_Log_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtXT_Log_Initialized_SetNull( )
      {
         gxTv_SdtXT_Log_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogID_Z" )]
      [  XmlElement( ElementName = "XT_LogID_Z"   )]
      public long gxTpr_Xt_logid_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logid_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logid_Z = value;
            SetDirty("Xt_logid_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logid_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogUserID_Z" )]
      [  XmlElement( ElementName = "XT_LogUserID_Z"   )]
      public long gxTpr_Xt_loguserid_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_loguserid_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_loguserid_Z = value;
            SetDirty("Xt_loguserid_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_loguserid_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_loguserid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_loguserid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogSecUserName_Z" )]
      [  XmlElement( ElementName = "XT_LogSecUserName_Z"   )]
      public String gxTpr_Xt_logsecusername_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logsecusername_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logsecusername_Z = value;
            SetDirty("Xt_logsecusername_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logsecusername_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logsecusername_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logsecusername_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTime_Z" )]
      [  XmlElement( ElementName = "XT_LogTime_Z"  , IsNullable=true )]
      public string gxTpr_Xt_logtime_Z_Nullable
      {
         get {
            if ( gxTv_SdtXT_Log_Xt_logtime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtXT_Log_Xt_logtime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtXT_Log_Xt_logtime_Z = DateTime.MinValue;
            else
               gxTv_SdtXT_Log_Xt_logtime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Xt_logtime_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtime_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtime_Z = value;
            SetDirty("Xt_logtime_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtime_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogPage_Z" )]
      [  XmlElement( ElementName = "XT_LogPage_Z"   )]
      public String gxTpr_Xt_logpage_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logpage_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logpage_Z = value;
            SetDirty("Xt_logpage_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logpage_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logpage_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logpage_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogButtonName_Z" )]
      [  XmlElement( ElementName = "XT_LogButtonName_Z"   )]
      public String gxTpr_Xt_logbuttonname_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logbuttonname_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logbuttonname_Z = value;
            SetDirty("Xt_logbuttonname_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logbuttonname_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logbuttonname_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logbuttonname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogType_Z" )]
      [  XmlElement( ElementName = "XT_LogType_Z"   )]
      public String gxTpr_Xt_logtype_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtype_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtype_Z = value;
            SetDirty("Xt_logtype_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtype_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtype_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtype_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogProviderID_Z" )]
      [  XmlElement( ElementName = "XT_LogProviderID_Z"   )]
      public long gxTpr_Xt_logproviderid_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logproviderid_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logproviderid_Z = value;
            SetDirty("Xt_logproviderid_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logproviderid_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logproviderid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logproviderid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogProviderName_Z" )]
      [  XmlElement( ElementName = "XT_LogProviderName_Z"   )]
      public String gxTpr_Xt_logprovidername_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logprovidername_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logprovidername_Z = value;
            SetDirty("Xt_logprovidername_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logprovidername_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logprovidername_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logprovidername_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTarget_Z" )]
      [  XmlElement( ElementName = "XT_LogTarget_Z"   )]
      public String gxTpr_Xt_logtarget_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtarget_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtarget_Z = value;
            SetDirty("Xt_logtarget_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtarget_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtarget_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtarget_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogSonTarget_Z" )]
      [  XmlElement( ElementName = "XT_LogSonTarget_Z"   )]
      public String gxTpr_Xt_logsontarget_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logsontarget_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logsontarget_Z = value;
            SetDirty("Xt_logsontarget_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logsontarget_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logsontarget_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logsontarget_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTargetModule_Z" )]
      [  XmlElement( ElementName = "XT_LogTargetModule_Z"   )]
      public String gxTpr_Xt_logtargetmodule_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtargetmodule_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtargetmodule_Z = value;
            SetDirty("Xt_logtargetmodule_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtargetmodule_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtargetmodule_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtargetmodule_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTargetSonModule_Z" )]
      [  XmlElement( ElementName = "XT_LogTargetSonModule_Z"   )]
      public String gxTpr_Xt_logtargetsonmodule_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtargetsonmodule_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtargetsonmodule_Z = value;
            SetDirty("Xt_logtargetsonmodule_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtargetsonmodule_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtargetsonmodule_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtargetsonmodule_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTargetOperate_Z" )]
      [  XmlElement( ElementName = "XT_LogTargetOperate_Z"   )]
      public String gxTpr_Xt_logtargetoperate_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtargetoperate_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtargetoperate_Z = value;
            SetDirty("Xt_logtargetoperate_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtargetoperate_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtargetoperate_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtargetoperate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogDescription_Z" )]
      [  XmlElement( ElementName = "XT_LogDescription_Z"   )]
      public String gxTpr_Xt_logdescription_Z
      {
         get {
            return gxTv_SdtXT_Log_Xt_logdescription_Z ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logdescription_Z = value;
            SetDirty("Xt_logdescription_Z");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logdescription_Z_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logdescription_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logdescription_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogUserID_N" )]
      [  XmlElement( ElementName = "XT_LogUserID_N"   )]
      public short gxTpr_Xt_loguserid_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_loguserid_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_loguserid_N = value;
            SetDirty("Xt_loguserid_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_loguserid_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_loguserid_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_loguserid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogSecUserName_N" )]
      [  XmlElement( ElementName = "XT_LogSecUserName_N"   )]
      public short gxTpr_Xt_logsecusername_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_logsecusername_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logsecusername_N = value;
            SetDirty("Xt_logsecusername_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logsecusername_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logsecusername_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logsecusername_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTime_N" )]
      [  XmlElement( ElementName = "XT_LogTime_N"   )]
      public short gxTpr_Xt_logtime_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtime_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtime_N = value;
            SetDirty("Xt_logtime_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtime_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtime_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtime_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogPage_N" )]
      [  XmlElement( ElementName = "XT_LogPage_N"   )]
      public short gxTpr_Xt_logpage_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_logpage_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logpage_N = value;
            SetDirty("Xt_logpage_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logpage_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logpage_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logpage_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogButtonName_N" )]
      [  XmlElement( ElementName = "XT_LogButtonName_N"   )]
      public short gxTpr_Xt_logbuttonname_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_logbuttonname_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logbuttonname_N = value;
            SetDirty("Xt_logbuttonname_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logbuttonname_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logbuttonname_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logbuttonname_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogType_N" )]
      [  XmlElement( ElementName = "XT_LogType_N"   )]
      public short gxTpr_Xt_logtype_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtype_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtype_N = value;
            SetDirty("Xt_logtype_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtype_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtype_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtype_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogProviderID_N" )]
      [  XmlElement( ElementName = "XT_LogProviderID_N"   )]
      public short gxTpr_Xt_logproviderid_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_logproviderid_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logproviderid_N = value;
            SetDirty("Xt_logproviderid_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logproviderid_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logproviderid_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logproviderid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogProviderName_N" )]
      [  XmlElement( ElementName = "XT_LogProviderName_N"   )]
      public short gxTpr_Xt_logprovidername_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_logprovidername_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logprovidername_N = value;
            SetDirty("Xt_logprovidername_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logprovidername_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logprovidername_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logprovidername_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTarget_N" )]
      [  XmlElement( ElementName = "XT_LogTarget_N"   )]
      public short gxTpr_Xt_logtarget_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtarget_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtarget_N = value;
            SetDirty("Xt_logtarget_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtarget_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtarget_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtarget_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogSonTarget_N" )]
      [  XmlElement( ElementName = "XT_LogSonTarget_N"   )]
      public short gxTpr_Xt_logsontarget_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_logsontarget_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logsontarget_N = value;
            SetDirty("Xt_logsontarget_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logsontarget_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logsontarget_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logsontarget_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTargetModule_N" )]
      [  XmlElement( ElementName = "XT_LogTargetModule_N"   )]
      public short gxTpr_Xt_logtargetmodule_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtargetmodule_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtargetmodule_N = value;
            SetDirty("Xt_logtargetmodule_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtargetmodule_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtargetmodule_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtargetmodule_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTargetSonModule_N" )]
      [  XmlElement( ElementName = "XT_LogTargetSonModule_N"   )]
      public short gxTpr_Xt_logtargetsonmodule_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtargetsonmodule_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtargetsonmodule_N = value;
            SetDirty("Xt_logtargetsonmodule_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtargetsonmodule_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtargetsonmodule_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtargetsonmodule_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogTargetOperate_N" )]
      [  XmlElement( ElementName = "XT_LogTargetOperate_N"   )]
      public short gxTpr_Xt_logtargetoperate_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_logtargetoperate_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logtargetoperate_N = value;
            SetDirty("Xt_logtargetoperate_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logtargetoperate_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logtargetoperate_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logtargetoperate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_LogDescription_N" )]
      [  XmlElement( ElementName = "XT_LogDescription_N"   )]
      public short gxTpr_Xt_logdescription_N
      {
         get {
            return gxTv_SdtXT_Log_Xt_logdescription_N ;
         }

         set {
            gxTv_SdtXT_Log_Xt_logdescription_N = value;
            SetDirty("Xt_logdescription_N");
         }

      }

      public void gxTv_SdtXT_Log_Xt_logdescription_N_SetNull( )
      {
         gxTv_SdtXT_Log_Xt_logdescription_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Log_Xt_logdescription_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtXT_Log_Xt_logsecusername = "";
         gxTv_SdtXT_Log_Xt_logtime = (DateTime)(DateTime.MinValue);
         gxTv_SdtXT_Log_Xt_logpage = "";
         gxTv_SdtXT_Log_Xt_logbuttonname = "";
         gxTv_SdtXT_Log_Xt_logtype = "";
         gxTv_SdtXT_Log_Xt_logprovidername = "";
         gxTv_SdtXT_Log_Xt_logtarget = "";
         gxTv_SdtXT_Log_Xt_logsontarget = "";
         gxTv_SdtXT_Log_Xt_logtargetmodule = "";
         gxTv_SdtXT_Log_Xt_logtargetsonmodule = "";
         gxTv_SdtXT_Log_Xt_logtargetoperate = "";
         gxTv_SdtXT_Log_Xt_logdescription = "";
         gxTv_SdtXT_Log_Mode = "";
         gxTv_SdtXT_Log_Xt_logsecusername_Z = "";
         gxTv_SdtXT_Log_Xt_logtime_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtXT_Log_Xt_logpage_Z = "";
         gxTv_SdtXT_Log_Xt_logbuttonname_Z = "";
         gxTv_SdtXT_Log_Xt_logtype_Z = "";
         gxTv_SdtXT_Log_Xt_logprovidername_Z = "";
         gxTv_SdtXT_Log_Xt_logtarget_Z = "";
         gxTv_SdtXT_Log_Xt_logsontarget_Z = "";
         gxTv_SdtXT_Log_Xt_logtargetmodule_Z = "";
         gxTv_SdtXT_Log_Xt_logtargetsonmodule_Z = "";
         gxTv_SdtXT_Log_Xt_logtargetoperate_Z = "";
         gxTv_SdtXT_Log_Xt_logdescription_Z = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "xt_log", "GeneXus.Programs.xt_log_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtXT_Log_Initialized ;
      private short gxTv_SdtXT_Log_Xt_loguserid_N ;
      private short gxTv_SdtXT_Log_Xt_logsecusername_N ;
      private short gxTv_SdtXT_Log_Xt_logtime_N ;
      private short gxTv_SdtXT_Log_Xt_logpage_N ;
      private short gxTv_SdtXT_Log_Xt_logbuttonname_N ;
      private short gxTv_SdtXT_Log_Xt_logtype_N ;
      private short gxTv_SdtXT_Log_Xt_logproviderid_N ;
      private short gxTv_SdtXT_Log_Xt_logprovidername_N ;
      private short gxTv_SdtXT_Log_Xt_logtarget_N ;
      private short gxTv_SdtXT_Log_Xt_logsontarget_N ;
      private short gxTv_SdtXT_Log_Xt_logtargetmodule_N ;
      private short gxTv_SdtXT_Log_Xt_logtargetsonmodule_N ;
      private short gxTv_SdtXT_Log_Xt_logtargetoperate_N ;
      private short gxTv_SdtXT_Log_Xt_logdescription_N ;
      private long gxTv_SdtXT_Log_Xt_logid ;
      private long gxTv_SdtXT_Log_Xt_loguserid ;
      private long gxTv_SdtXT_Log_Xt_logproviderid ;
      private long gxTv_SdtXT_Log_Xt_logid_Z ;
      private long gxTv_SdtXT_Log_Xt_loguserid_Z ;
      private long gxTv_SdtXT_Log_Xt_logproviderid_Z ;
      private String gxTv_SdtXT_Log_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtXT_Log_Xt_logtime ;
      private DateTime gxTv_SdtXT_Log_Xt_logtime_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_SdtXT_Log_Xt_logsecusername ;
      private String gxTv_SdtXT_Log_Xt_logpage ;
      private String gxTv_SdtXT_Log_Xt_logbuttonname ;
      private String gxTv_SdtXT_Log_Xt_logtype ;
      private String gxTv_SdtXT_Log_Xt_logprovidername ;
      private String gxTv_SdtXT_Log_Xt_logtarget ;
      private String gxTv_SdtXT_Log_Xt_logsontarget ;
      private String gxTv_SdtXT_Log_Xt_logtargetmodule ;
      private String gxTv_SdtXT_Log_Xt_logtargetsonmodule ;
      private String gxTv_SdtXT_Log_Xt_logtargetoperate ;
      private String gxTv_SdtXT_Log_Xt_logdescription ;
      private String gxTv_SdtXT_Log_Xt_logsecusername_Z ;
      private String gxTv_SdtXT_Log_Xt_logpage_Z ;
      private String gxTv_SdtXT_Log_Xt_logbuttonname_Z ;
      private String gxTv_SdtXT_Log_Xt_logtype_Z ;
      private String gxTv_SdtXT_Log_Xt_logprovidername_Z ;
      private String gxTv_SdtXT_Log_Xt_logtarget_Z ;
      private String gxTv_SdtXT_Log_Xt_logsontarget_Z ;
      private String gxTv_SdtXT_Log_Xt_logtargetmodule_Z ;
      private String gxTv_SdtXT_Log_Xt_logtargetsonmodule_Z ;
      private String gxTv_SdtXT_Log_Xt_logtargetoperate_Z ;
      private String gxTv_SdtXT_Log_Xt_logdescription_Z ;
   }

   [DataContract(Name = @"XT_Log", Namespace = "DataAnalysisPlatform")]
   public class SdtXT_Log_RESTInterface : GxGenericCollectionItem<SdtXT_Log>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtXT_Log_RESTInterface( ) : base()
      {
      }

      public SdtXT_Log_RESTInterface( SdtXT_Log psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "XT_LogID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Xt_logid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Xt_logid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Xt_logid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "XT_LogUserID" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Xt_loguserid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Xt_loguserid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Xt_loguserid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "XT_LogSecUserName" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Xt_logsecusername
      {
         get {
            return sdt.gxTpr_Xt_logsecusername ;
         }

         set {
            sdt.gxTpr_Xt_logsecusername = value;
         }

      }

      [DataMember( Name = "XT_LogTime" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Xt_logtime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Xt_logtime) ;
         }

         set {
            sdt.gxTpr_Xt_logtime = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "XT_LogPage" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Xt_logpage
      {
         get {
            return sdt.gxTpr_Xt_logpage ;
         }

         set {
            sdt.gxTpr_Xt_logpage = value;
         }

      }

      [DataMember( Name = "XT_LogButtonName" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Xt_logbuttonname
      {
         get {
            return sdt.gxTpr_Xt_logbuttonname ;
         }

         set {
            sdt.gxTpr_Xt_logbuttonname = value;
         }

      }

      [DataMember( Name = "XT_LogType" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Xt_logtype
      {
         get {
            return sdt.gxTpr_Xt_logtype ;
         }

         set {
            sdt.gxTpr_Xt_logtype = value;
         }

      }

      [DataMember( Name = "XT_LogProviderID" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Xt_logproviderid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Xt_logproviderid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Xt_logproviderid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "XT_LogProviderName" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Xt_logprovidername
      {
         get {
            return sdt.gxTpr_Xt_logprovidername ;
         }

         set {
            sdt.gxTpr_Xt_logprovidername = value;
         }

      }

      [DataMember( Name = "XT_LogTarget" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Xt_logtarget
      {
         get {
            return sdt.gxTpr_Xt_logtarget ;
         }

         set {
            sdt.gxTpr_Xt_logtarget = value;
         }

      }

      [DataMember( Name = "XT_LogSonTarget" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Xt_logsontarget
      {
         get {
            return sdt.gxTpr_Xt_logsontarget ;
         }

         set {
            sdt.gxTpr_Xt_logsontarget = value;
         }

      }

      [DataMember( Name = "XT_LogTargetModule" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Xt_logtargetmodule
      {
         get {
            return sdt.gxTpr_Xt_logtargetmodule ;
         }

         set {
            sdt.gxTpr_Xt_logtargetmodule = value;
         }

      }

      [DataMember( Name = "XT_LogTargetSonModule" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Xt_logtargetsonmodule
      {
         get {
            return sdt.gxTpr_Xt_logtargetsonmodule ;
         }

         set {
            sdt.gxTpr_Xt_logtargetsonmodule = value;
         }

      }

      [DataMember( Name = "XT_LogTargetOperate" , Order = 13 )]
      [GxSeudo()]
      public String gxTpr_Xt_logtargetoperate
      {
         get {
            return sdt.gxTpr_Xt_logtargetoperate ;
         }

         set {
            sdt.gxTpr_Xt_logtargetoperate = value;
         }

      }

      [DataMember( Name = "XT_LogDescription" , Order = 14 )]
      [GxSeudo()]
      public String gxTpr_Xt_logdescription
      {
         get {
            return sdt.gxTpr_Xt_logdescription ;
         }

         set {
            sdt.gxTpr_Xt_logdescription = value;
         }

      }

      public SdtXT_Log sdt
      {
         get {
            return (SdtXT_Log)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtXT_Log() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 15 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}
