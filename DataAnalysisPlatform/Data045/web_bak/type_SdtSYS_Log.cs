/*
               File: type_SdtSYS_Log
        Description: SYS_Log
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:5.42
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
   [XmlRoot(ElementName = "SYS_Log" )]
   [XmlType(TypeName =  "SYS_Log" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSYS_Log : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_Log( )
      {
      }

      public SdtSYS_Log( IGxContext context )
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

      public void Load( long AV442SYS_LogLogID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV442SYS_LogLogID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SYS_LogLogID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "SYS_Log");
         metadata.Set("BT", "SYS_LOG");
         metadata.Set("PK", "[ \"SYS_LogLogID\" ]");
         metadata.Set("PKAssigned", "[ \"SYS_LogLogID\" ]");
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
         state.Add("gxTpr_Sys_loglogid_Z");
         state.Add("gxTpr_Sys_logtenantcode_Z");
         state.Add("gxTpr_Sys_logtitle_Z");
         state.Add("gxTpr_Sys_logclientip_Z");
         state.Add("gxTpr_Sys_logmodulecode_Z");
         state.Add("gxTpr_Sys_loglogtype_Z");
         state.Add("gxTpr_Sys_logcreator_Z");
         state.Add("gxTpr_Sys_logcreatetime_Z_Nullable");
         state.Add("gxTpr_Sys_logtenantcode_N");
         state.Add("gxTpr_Sys_logcontent_N");
         state.Add("gxTpr_Sys_logclientip_N");
         state.Add("gxTpr_Sys_logmodulecode_N");
         state.Add("gxTpr_Sys_loglogtype_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSYS_Log sdt ;
         sdt = (SdtSYS_Log)(source);
         gxTv_SdtSYS_Log_Sys_loglogid = sdt.gxTv_SdtSYS_Log_Sys_loglogid ;
         gxTv_SdtSYS_Log_Sys_logtenantcode = sdt.gxTv_SdtSYS_Log_Sys_logtenantcode ;
         gxTv_SdtSYS_Log_Sys_logtitle = sdt.gxTv_SdtSYS_Log_Sys_logtitle ;
         gxTv_SdtSYS_Log_Sys_logcontent = sdt.gxTv_SdtSYS_Log_Sys_logcontent ;
         gxTv_SdtSYS_Log_Sys_logclientip = sdt.gxTv_SdtSYS_Log_Sys_logclientip ;
         gxTv_SdtSYS_Log_Sys_logmodulecode = sdt.gxTv_SdtSYS_Log_Sys_logmodulecode ;
         gxTv_SdtSYS_Log_Sys_loglogtype = sdt.gxTv_SdtSYS_Log_Sys_loglogtype ;
         gxTv_SdtSYS_Log_Sys_logcreator = sdt.gxTv_SdtSYS_Log_Sys_logcreator ;
         gxTv_SdtSYS_Log_Sys_logcreatetime = sdt.gxTv_SdtSYS_Log_Sys_logcreatetime ;
         gxTv_SdtSYS_Log_Mode = sdt.gxTv_SdtSYS_Log_Mode ;
         gxTv_SdtSYS_Log_Initialized = sdt.gxTv_SdtSYS_Log_Initialized ;
         gxTv_SdtSYS_Log_Sys_loglogid_Z = sdt.gxTv_SdtSYS_Log_Sys_loglogid_Z ;
         gxTv_SdtSYS_Log_Sys_logtenantcode_Z = sdt.gxTv_SdtSYS_Log_Sys_logtenantcode_Z ;
         gxTv_SdtSYS_Log_Sys_logtitle_Z = sdt.gxTv_SdtSYS_Log_Sys_logtitle_Z ;
         gxTv_SdtSYS_Log_Sys_logclientip_Z = sdt.gxTv_SdtSYS_Log_Sys_logclientip_Z ;
         gxTv_SdtSYS_Log_Sys_logmodulecode_Z = sdt.gxTv_SdtSYS_Log_Sys_logmodulecode_Z ;
         gxTv_SdtSYS_Log_Sys_loglogtype_Z = sdt.gxTv_SdtSYS_Log_Sys_loglogtype_Z ;
         gxTv_SdtSYS_Log_Sys_logcreator_Z = sdt.gxTv_SdtSYS_Log_Sys_logcreator_Z ;
         gxTv_SdtSYS_Log_Sys_logcreatetime_Z = sdt.gxTv_SdtSYS_Log_Sys_logcreatetime_Z ;
         gxTv_SdtSYS_Log_Sys_logtenantcode_N = sdt.gxTv_SdtSYS_Log_Sys_logtenantcode_N ;
         gxTv_SdtSYS_Log_Sys_logcontent_N = sdt.gxTv_SdtSYS_Log_Sys_logcontent_N ;
         gxTv_SdtSYS_Log_Sys_logclientip_N = sdt.gxTv_SdtSYS_Log_Sys_logclientip_N ;
         gxTv_SdtSYS_Log_Sys_logmodulecode_N = sdt.gxTv_SdtSYS_Log_Sys_logmodulecode_N ;
         gxTv_SdtSYS_Log_Sys_loglogtype_N = sdt.gxTv_SdtSYS_Log_Sys_loglogtype_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SYS_LogLogID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSYS_Log_Sys_loglogid), 18, 0)), false);
         AddObjectProperty("SYS_LogTenantCode", gxTv_SdtSYS_Log_Sys_logtenantcode, false);
         AddObjectProperty("SYS_LogTenantCode_N", gxTv_SdtSYS_Log_Sys_logtenantcode_N, false);
         AddObjectProperty("SYS_LogTitle", gxTv_SdtSYS_Log_Sys_logtitle, false);
         AddObjectProperty("SYS_LogContent", gxTv_SdtSYS_Log_Sys_logcontent, false);
         AddObjectProperty("SYS_LogContent_N", gxTv_SdtSYS_Log_Sys_logcontent_N, false);
         AddObjectProperty("SYS_LogClientIP", gxTv_SdtSYS_Log_Sys_logclientip, false);
         AddObjectProperty("SYS_LogClientIP_N", gxTv_SdtSYS_Log_Sys_logclientip_N, false);
         AddObjectProperty("SYS_LogModuleCode", gxTv_SdtSYS_Log_Sys_logmodulecode, false);
         AddObjectProperty("SYS_LogModuleCode_N", gxTv_SdtSYS_Log_Sys_logmodulecode_N, false);
         AddObjectProperty("SYS_LogLogType", gxTv_SdtSYS_Log_Sys_loglogtype, false);
         AddObjectProperty("SYS_LogLogType_N", gxTv_SdtSYS_Log_Sys_loglogtype_N, false);
         AddObjectProperty("SYS_LogCreator", gxTv_SdtSYS_Log_Sys_logcreator, false);
         datetime_STZ = gxTv_SdtSYS_Log_Sys_logcreatetime;
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
         AddObjectProperty("SYS_LogCreateTime", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSYS_Log_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSYS_Log_Initialized, false);
            AddObjectProperty("SYS_LogLogID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSYS_Log_Sys_loglogid_Z), 18, 0)), false);
            AddObjectProperty("SYS_LogTenantCode_Z", gxTv_SdtSYS_Log_Sys_logtenantcode_Z, false);
            AddObjectProperty("SYS_LogTitle_Z", gxTv_SdtSYS_Log_Sys_logtitle_Z, false);
            AddObjectProperty("SYS_LogClientIP_Z", gxTv_SdtSYS_Log_Sys_logclientip_Z, false);
            AddObjectProperty("SYS_LogModuleCode_Z", gxTv_SdtSYS_Log_Sys_logmodulecode_Z, false);
            AddObjectProperty("SYS_LogLogType_Z", gxTv_SdtSYS_Log_Sys_loglogtype_Z, false);
            AddObjectProperty("SYS_LogCreator_Z", gxTv_SdtSYS_Log_Sys_logcreator_Z, false);
            datetime_STZ = gxTv_SdtSYS_Log_Sys_logcreatetime_Z;
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
            AddObjectProperty("SYS_LogCreateTime_Z", sDateCnv, false);
            AddObjectProperty("SYS_LogTenantCode_N", gxTv_SdtSYS_Log_Sys_logtenantcode_N, false);
            AddObjectProperty("SYS_LogContent_N", gxTv_SdtSYS_Log_Sys_logcontent_N, false);
            AddObjectProperty("SYS_LogClientIP_N", gxTv_SdtSYS_Log_Sys_logclientip_N, false);
            AddObjectProperty("SYS_LogModuleCode_N", gxTv_SdtSYS_Log_Sys_logmodulecode_N, false);
            AddObjectProperty("SYS_LogLogType_N", gxTv_SdtSYS_Log_Sys_loglogtype_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSYS_Log sdt )
      {
         if ( sdt.IsDirty("SYS_LogLogID") )
         {
            gxTv_SdtSYS_Log_Sys_loglogid = sdt.gxTv_SdtSYS_Log_Sys_loglogid ;
         }
         if ( sdt.IsDirty("SYS_LogTenantCode") )
         {
            gxTv_SdtSYS_Log_Sys_logtenantcode = sdt.gxTv_SdtSYS_Log_Sys_logtenantcode ;
         }
         if ( sdt.IsDirty("SYS_LogTitle") )
         {
            gxTv_SdtSYS_Log_Sys_logtitle = sdt.gxTv_SdtSYS_Log_Sys_logtitle ;
         }
         if ( sdt.IsDirty("SYS_LogContent") )
         {
            gxTv_SdtSYS_Log_Sys_logcontent = sdt.gxTv_SdtSYS_Log_Sys_logcontent ;
         }
         if ( sdt.IsDirty("SYS_LogClientIP") )
         {
            gxTv_SdtSYS_Log_Sys_logclientip = sdt.gxTv_SdtSYS_Log_Sys_logclientip ;
         }
         if ( sdt.IsDirty("SYS_LogModuleCode") )
         {
            gxTv_SdtSYS_Log_Sys_logmodulecode = sdt.gxTv_SdtSYS_Log_Sys_logmodulecode ;
         }
         if ( sdt.IsDirty("SYS_LogLogType") )
         {
            gxTv_SdtSYS_Log_Sys_loglogtype = sdt.gxTv_SdtSYS_Log_Sys_loglogtype ;
         }
         if ( sdt.IsDirty("SYS_LogCreator") )
         {
            gxTv_SdtSYS_Log_Sys_logcreator = sdt.gxTv_SdtSYS_Log_Sys_logcreator ;
         }
         if ( sdt.IsDirty("SYS_LogCreateTime") )
         {
            gxTv_SdtSYS_Log_Sys_logcreatetime = sdt.gxTv_SdtSYS_Log_Sys_logcreatetime ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SYS_LogLogID" )]
      [  XmlElement( ElementName = "SYS_LogLogID"   )]
      public long gxTpr_Sys_loglogid
      {
         get {
            return gxTv_SdtSYS_Log_Sys_loglogid ;
         }

         set {
            if ( gxTv_SdtSYS_Log_Sys_loglogid != value )
            {
               gxTv_SdtSYS_Log_Mode = "INS";
               this.gxTv_SdtSYS_Log_Sys_loglogid_Z_SetNull( );
               this.gxTv_SdtSYS_Log_Sys_logtenantcode_Z_SetNull( );
               this.gxTv_SdtSYS_Log_Sys_logtitle_Z_SetNull( );
               this.gxTv_SdtSYS_Log_Sys_logclientip_Z_SetNull( );
               this.gxTv_SdtSYS_Log_Sys_logmodulecode_Z_SetNull( );
               this.gxTv_SdtSYS_Log_Sys_loglogtype_Z_SetNull( );
               this.gxTv_SdtSYS_Log_Sys_logcreator_Z_SetNull( );
               this.gxTv_SdtSYS_Log_Sys_logcreatetime_Z_SetNull( );
            }
            gxTv_SdtSYS_Log_Sys_loglogid = value;
            SetDirty("Sys_loglogid");
         }

      }

      [  SoapElement( ElementName = "SYS_LogTenantCode" )]
      [  XmlElement( ElementName = "SYS_LogTenantCode"   )]
      public String gxTpr_Sys_logtenantcode
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logtenantcode ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logtenantcode_N = 0;
            gxTv_SdtSYS_Log_Sys_logtenantcode = value;
            SetDirty("Sys_logtenantcode");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logtenantcode_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logtenantcode_N = 1;
         gxTv_SdtSYS_Log_Sys_logtenantcode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logtenantcode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogTitle" )]
      [  XmlElement( ElementName = "SYS_LogTitle"   )]
      public String gxTpr_Sys_logtitle
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logtitle ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logtitle = value;
            SetDirty("Sys_logtitle");
         }

      }

      [  SoapElement( ElementName = "SYS_LogContent" )]
      [  XmlElement( ElementName = "SYS_LogContent"   )]
      public String gxTpr_Sys_logcontent
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logcontent ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logcontent_N = 0;
            gxTv_SdtSYS_Log_Sys_logcontent = value;
            SetDirty("Sys_logcontent");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logcontent_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logcontent_N = 1;
         gxTv_SdtSYS_Log_Sys_logcontent = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logcontent_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogClientIP" )]
      [  XmlElement( ElementName = "SYS_LogClientIP"   )]
      public String gxTpr_Sys_logclientip
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logclientip ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logclientip_N = 0;
            gxTv_SdtSYS_Log_Sys_logclientip = value;
            SetDirty("Sys_logclientip");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logclientip_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logclientip_N = 1;
         gxTv_SdtSYS_Log_Sys_logclientip = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logclientip_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogModuleCode" )]
      [  XmlElement( ElementName = "SYS_LogModuleCode"   )]
      public String gxTpr_Sys_logmodulecode
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logmodulecode ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logmodulecode_N = 0;
            gxTv_SdtSYS_Log_Sys_logmodulecode = value;
            SetDirty("Sys_logmodulecode");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logmodulecode_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logmodulecode_N = 1;
         gxTv_SdtSYS_Log_Sys_logmodulecode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logmodulecode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogLogType" )]
      [  XmlElement( ElementName = "SYS_LogLogType"   )]
      public String gxTpr_Sys_loglogtype
      {
         get {
            return gxTv_SdtSYS_Log_Sys_loglogtype ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_loglogtype_N = 0;
            gxTv_SdtSYS_Log_Sys_loglogtype = value;
            SetDirty("Sys_loglogtype");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_loglogtype_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_loglogtype_N = 1;
         gxTv_SdtSYS_Log_Sys_loglogtype = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_loglogtype_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogCreator" )]
      [  XmlElement( ElementName = "SYS_LogCreator"   )]
      public String gxTpr_Sys_logcreator
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logcreator ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logcreator = value;
            SetDirty("Sys_logcreator");
         }

      }

      [  SoapElement( ElementName = "SYS_LogCreateTime" )]
      [  XmlElement( ElementName = "SYS_LogCreateTime"  , IsNullable=true )]
      public string gxTpr_Sys_logcreatetime_Nullable
      {
         get {
            if ( gxTv_SdtSYS_Log_Sys_logcreatetime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_Log_Sys_logcreatetime).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_Log_Sys_logcreatetime = DateTime.MinValue;
            else
               gxTv_SdtSYS_Log_Sys_logcreatetime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_logcreatetime
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logcreatetime ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logcreatetime = value;
            SetDirty("Sys_logcreatetime");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSYS_Log_Mode ;
         }

         set {
            gxTv_SdtSYS_Log_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSYS_Log_Mode_SetNull( )
      {
         gxTv_SdtSYS_Log_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSYS_Log_Initialized ;
         }

         set {
            gxTv_SdtSYS_Log_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSYS_Log_Initialized_SetNull( )
      {
         gxTv_SdtSYS_Log_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogLogID_Z" )]
      [  XmlElement( ElementName = "SYS_LogLogID_Z"   )]
      public long gxTpr_Sys_loglogid_Z
      {
         get {
            return gxTv_SdtSYS_Log_Sys_loglogid_Z ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_loglogid_Z = value;
            SetDirty("Sys_loglogid_Z");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_loglogid_Z_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_loglogid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_loglogid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogTenantCode_Z" )]
      [  XmlElement( ElementName = "SYS_LogTenantCode_Z"   )]
      public String gxTpr_Sys_logtenantcode_Z
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logtenantcode_Z ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logtenantcode_Z = value;
            SetDirty("Sys_logtenantcode_Z");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logtenantcode_Z_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logtenantcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logtenantcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogTitle_Z" )]
      [  XmlElement( ElementName = "SYS_LogTitle_Z"   )]
      public String gxTpr_Sys_logtitle_Z
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logtitle_Z ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logtitle_Z = value;
            SetDirty("Sys_logtitle_Z");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logtitle_Z_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logtitle_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logtitle_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogClientIP_Z" )]
      [  XmlElement( ElementName = "SYS_LogClientIP_Z"   )]
      public String gxTpr_Sys_logclientip_Z
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logclientip_Z ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logclientip_Z = value;
            SetDirty("Sys_logclientip_Z");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logclientip_Z_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logclientip_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logclientip_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogModuleCode_Z" )]
      [  XmlElement( ElementName = "SYS_LogModuleCode_Z"   )]
      public String gxTpr_Sys_logmodulecode_Z
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logmodulecode_Z ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logmodulecode_Z = value;
            SetDirty("Sys_logmodulecode_Z");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logmodulecode_Z_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logmodulecode_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logmodulecode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogLogType_Z" )]
      [  XmlElement( ElementName = "SYS_LogLogType_Z"   )]
      public String gxTpr_Sys_loglogtype_Z
      {
         get {
            return gxTv_SdtSYS_Log_Sys_loglogtype_Z ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_loglogtype_Z = value;
            SetDirty("Sys_loglogtype_Z");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_loglogtype_Z_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_loglogtype_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_loglogtype_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogCreator_Z" )]
      [  XmlElement( ElementName = "SYS_LogCreator_Z"   )]
      public String gxTpr_Sys_logcreator_Z
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logcreator_Z ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logcreator_Z = value;
            SetDirty("Sys_logcreator_Z");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logcreator_Z_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logcreator_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logcreator_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogCreateTime_Z" )]
      [  XmlElement( ElementName = "SYS_LogCreateTime_Z"  , IsNullable=true )]
      public string gxTpr_Sys_logcreatetime_Z_Nullable
      {
         get {
            if ( gxTv_SdtSYS_Log_Sys_logcreatetime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_Log_Sys_logcreatetime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_Log_Sys_logcreatetime_Z = DateTime.MinValue;
            else
               gxTv_SdtSYS_Log_Sys_logcreatetime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_logcreatetime_Z
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logcreatetime_Z ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logcreatetime_Z = value;
            SetDirty("Sys_logcreatetime_Z");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logcreatetime_Z_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logcreatetime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logcreatetime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogTenantCode_N" )]
      [  XmlElement( ElementName = "SYS_LogTenantCode_N"   )]
      public short gxTpr_Sys_logtenantcode_N
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logtenantcode_N ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logtenantcode_N = value;
            SetDirty("Sys_logtenantcode_N");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logtenantcode_N_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logtenantcode_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logtenantcode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogContent_N" )]
      [  XmlElement( ElementName = "SYS_LogContent_N"   )]
      public short gxTpr_Sys_logcontent_N
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logcontent_N ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logcontent_N = value;
            SetDirty("Sys_logcontent_N");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logcontent_N_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logcontent_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logcontent_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogClientIP_N" )]
      [  XmlElement( ElementName = "SYS_LogClientIP_N"   )]
      public short gxTpr_Sys_logclientip_N
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logclientip_N ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logclientip_N = value;
            SetDirty("Sys_logclientip_N");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logclientip_N_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logclientip_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logclientip_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogModuleCode_N" )]
      [  XmlElement( ElementName = "SYS_LogModuleCode_N"   )]
      public short gxTpr_Sys_logmodulecode_N
      {
         get {
            return gxTv_SdtSYS_Log_Sys_logmodulecode_N ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_logmodulecode_N = value;
            SetDirty("Sys_logmodulecode_N");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_logmodulecode_N_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_logmodulecode_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_logmodulecode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_LogLogType_N" )]
      [  XmlElement( ElementName = "SYS_LogLogType_N"   )]
      public short gxTpr_Sys_loglogtype_N
      {
         get {
            return gxTv_SdtSYS_Log_Sys_loglogtype_N ;
         }

         set {
            gxTv_SdtSYS_Log_Sys_loglogtype_N = value;
            SetDirty("Sys_loglogtype_N");
         }

      }

      public void gxTv_SdtSYS_Log_Sys_loglogtype_N_SetNull( )
      {
         gxTv_SdtSYS_Log_Sys_loglogtype_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Log_Sys_loglogtype_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSYS_Log_Sys_logtenantcode = "";
         gxTv_SdtSYS_Log_Sys_logtitle = "";
         gxTv_SdtSYS_Log_Sys_logcontent = "";
         gxTv_SdtSYS_Log_Sys_logclientip = "";
         gxTv_SdtSYS_Log_Sys_logmodulecode = "";
         gxTv_SdtSYS_Log_Sys_loglogtype = "";
         gxTv_SdtSYS_Log_Sys_logcreator = "";
         gxTv_SdtSYS_Log_Sys_logcreatetime = (DateTime)(DateTime.MinValue);
         gxTv_SdtSYS_Log_Mode = "";
         gxTv_SdtSYS_Log_Sys_logtenantcode_Z = "";
         gxTv_SdtSYS_Log_Sys_logtitle_Z = "";
         gxTv_SdtSYS_Log_Sys_logclientip_Z = "";
         gxTv_SdtSYS_Log_Sys_logmodulecode_Z = "";
         gxTv_SdtSYS_Log_Sys_loglogtype_Z = "";
         gxTv_SdtSYS_Log_Sys_logcreator_Z = "";
         gxTv_SdtSYS_Log_Sys_logcreatetime_Z = (DateTime)(DateTime.MinValue);
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "sys_log", "GeneXus.Programs.sys_log_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSYS_Log_Initialized ;
      private short gxTv_SdtSYS_Log_Sys_logtenantcode_N ;
      private short gxTv_SdtSYS_Log_Sys_logcontent_N ;
      private short gxTv_SdtSYS_Log_Sys_logclientip_N ;
      private short gxTv_SdtSYS_Log_Sys_logmodulecode_N ;
      private short gxTv_SdtSYS_Log_Sys_loglogtype_N ;
      private long gxTv_SdtSYS_Log_Sys_loglogid ;
      private long gxTv_SdtSYS_Log_Sys_loglogid_Z ;
      private String gxTv_SdtSYS_Log_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtSYS_Log_Sys_logcreatetime ;
      private DateTime gxTv_SdtSYS_Log_Sys_logcreatetime_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_SdtSYS_Log_Sys_logcontent ;
      private String gxTv_SdtSYS_Log_Sys_logtenantcode ;
      private String gxTv_SdtSYS_Log_Sys_logtitle ;
      private String gxTv_SdtSYS_Log_Sys_logclientip ;
      private String gxTv_SdtSYS_Log_Sys_logmodulecode ;
      private String gxTv_SdtSYS_Log_Sys_loglogtype ;
      private String gxTv_SdtSYS_Log_Sys_logcreator ;
      private String gxTv_SdtSYS_Log_Sys_logtenantcode_Z ;
      private String gxTv_SdtSYS_Log_Sys_logtitle_Z ;
      private String gxTv_SdtSYS_Log_Sys_logclientip_Z ;
      private String gxTv_SdtSYS_Log_Sys_logmodulecode_Z ;
      private String gxTv_SdtSYS_Log_Sys_loglogtype_Z ;
      private String gxTv_SdtSYS_Log_Sys_logcreator_Z ;
   }

   [DataContract(Name = @"SYS_Log", Namespace = "DataAnalysisPlatform")]
   public class SdtSYS_Log_RESTInterface : GxGenericCollectionItem<SdtSYS_Log>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_Log_RESTInterface( ) : base()
      {
      }

      public SdtSYS_Log_RESTInterface( SdtSYS_Log psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SYS_LogLogID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Sys_loglogid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Sys_loglogid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Sys_loglogid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "SYS_LogTenantCode" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Sys_logtenantcode
      {
         get {
            return sdt.gxTpr_Sys_logtenantcode ;
         }

         set {
            sdt.gxTpr_Sys_logtenantcode = value;
         }

      }

      [DataMember( Name = "SYS_LogTitle" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Sys_logtitle
      {
         get {
            return sdt.gxTpr_Sys_logtitle ;
         }

         set {
            sdt.gxTpr_Sys_logtitle = value;
         }

      }

      [DataMember( Name = "SYS_LogContent" , Order = 3 )]
      public String gxTpr_Sys_logcontent
      {
         get {
            return sdt.gxTpr_Sys_logcontent ;
         }

         set {
            sdt.gxTpr_Sys_logcontent = value;
         }

      }

      [DataMember( Name = "SYS_LogClientIP" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Sys_logclientip
      {
         get {
            return sdt.gxTpr_Sys_logclientip ;
         }

         set {
            sdt.gxTpr_Sys_logclientip = value;
         }

      }

      [DataMember( Name = "SYS_LogModuleCode" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Sys_logmodulecode
      {
         get {
            return sdt.gxTpr_Sys_logmodulecode ;
         }

         set {
            sdt.gxTpr_Sys_logmodulecode = value;
         }

      }

      [DataMember( Name = "SYS_LogLogType" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Sys_loglogtype
      {
         get {
            return sdt.gxTpr_Sys_loglogtype ;
         }

         set {
            sdt.gxTpr_Sys_loglogtype = value;
         }

      }

      [DataMember( Name = "SYS_LogCreator" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Sys_logcreator
      {
         get {
            return sdt.gxTpr_Sys_logcreator ;
         }

         set {
            sdt.gxTpr_Sys_logcreator = value;
         }

      }

      [DataMember( Name = "SYS_LogCreateTime" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Sys_logcreatetime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Sys_logcreatetime) ;
         }

         set {
            sdt.gxTpr_Sys_logcreatetime = DateTimeUtil.CToT2( value);
         }

      }

      public SdtSYS_Log sdt
      {
         get {
            return (SdtSYS_Log)Sdt ;
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
            sdt = new SdtSYS_Log() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 9 )]
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
