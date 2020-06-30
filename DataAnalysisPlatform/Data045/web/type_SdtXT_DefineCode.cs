/*
               File: type_SdtXT_DefineCode
        Description: 数据字典数据
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:7:39.80
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
   [XmlRoot(ElementName = "XT_DefineCode" )]
   [XmlType(TypeName =  "XT_DefineCode" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtXT_DefineCode : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtXT_DefineCode( )
      {
      }

      public SdtXT_DefineCode( IGxContext context )
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

      public void Load( long AV167XT_DefineCodeID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV167XT_DefineCodeID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"XT_DefineCodeID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "XT_DefineCode");
         metadata.Set("BT", "XT_DefineCode");
         metadata.Set("PK", "[ \"XT_DefineCodeID\" ]");
         metadata.Set("PKAssigned", "[ \"XT_DefineCodeID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"XT_DefindcodeTypeID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Xt_definecodeid_Z");
         state.Add("gxTpr_Xt_definecodename_Z");
         state.Add("gxTpr_Xt_defindcodetypeid_Z");
         state.Add("gxTpr_Xt_defindcodetypename_Z");
         state.Add("gxTpr_Xt_definecodeorder_Z");
         state.Add("gxTpr_Xt_typecode_Z");
         state.Add("gxTpr_Xt_tenantcode_Z");
         state.Add("gxTpr_Xt_definecodeintialtype_Z");
         state.Add("gxTpr_Xt_definecodename_N");
         state.Add("gxTpr_Xt_defindcodetypename_N");
         state.Add("gxTpr_Xt_definecodeorder_N");
         state.Add("gxTpr_Xt_typecode_N");
         state.Add("gxTpr_Xt_tenantcode_N");
         state.Add("gxTpr_Xt_definecodeintialtype_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtXT_DefineCode sdt ;
         sdt = (SdtXT_DefineCode)(source);
         gxTv_SdtXT_DefineCode_Xt_definecodeid = sdt.gxTv_SdtXT_DefineCode_Xt_definecodeid ;
         gxTv_SdtXT_DefineCode_Xt_definecodename = sdt.gxTv_SdtXT_DefineCode_Xt_definecodename ;
         gxTv_SdtXT_DefineCode_Xt_defindcodetypeid = sdt.gxTv_SdtXT_DefineCode_Xt_defindcodetypeid ;
         gxTv_SdtXT_DefineCode_Xt_defindcodetypename = sdt.gxTv_SdtXT_DefineCode_Xt_defindcodetypename ;
         gxTv_SdtXT_DefineCode_Xt_definecodeorder = sdt.gxTv_SdtXT_DefineCode_Xt_definecodeorder ;
         gxTv_SdtXT_DefineCode_Xt_typecode = sdt.gxTv_SdtXT_DefineCode_Xt_typecode ;
         gxTv_SdtXT_DefineCode_Xt_tenantcode = sdt.gxTv_SdtXT_DefineCode_Xt_tenantcode ;
         gxTv_SdtXT_DefineCode_Xt_definecodeintialtype = sdt.gxTv_SdtXT_DefineCode_Xt_definecodeintialtype ;
         gxTv_SdtXT_DefineCode_Mode = sdt.gxTv_SdtXT_DefineCode_Mode ;
         gxTv_SdtXT_DefineCode_Initialized = sdt.gxTv_SdtXT_DefineCode_Initialized ;
         gxTv_SdtXT_DefineCode_Xt_definecodeid_Z = sdt.gxTv_SdtXT_DefineCode_Xt_definecodeid_Z ;
         gxTv_SdtXT_DefineCode_Xt_definecodename_Z = sdt.gxTv_SdtXT_DefineCode_Xt_definecodename_Z ;
         gxTv_SdtXT_DefineCode_Xt_defindcodetypeid_Z = sdt.gxTv_SdtXT_DefineCode_Xt_defindcodetypeid_Z ;
         gxTv_SdtXT_DefineCode_Xt_defindcodetypename_Z = sdt.gxTv_SdtXT_DefineCode_Xt_defindcodetypename_Z ;
         gxTv_SdtXT_DefineCode_Xt_definecodeorder_Z = sdt.gxTv_SdtXT_DefineCode_Xt_definecodeorder_Z ;
         gxTv_SdtXT_DefineCode_Xt_typecode_Z = sdt.gxTv_SdtXT_DefineCode_Xt_typecode_Z ;
         gxTv_SdtXT_DefineCode_Xt_tenantcode_Z = sdt.gxTv_SdtXT_DefineCode_Xt_tenantcode_Z ;
         gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_Z = sdt.gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_Z ;
         gxTv_SdtXT_DefineCode_Xt_definecodename_N = sdt.gxTv_SdtXT_DefineCode_Xt_definecodename_N ;
         gxTv_SdtXT_DefineCode_Xt_defindcodetypename_N = sdt.gxTv_SdtXT_DefineCode_Xt_defindcodetypename_N ;
         gxTv_SdtXT_DefineCode_Xt_definecodeorder_N = sdt.gxTv_SdtXT_DefineCode_Xt_definecodeorder_N ;
         gxTv_SdtXT_DefineCode_Xt_typecode_N = sdt.gxTv_SdtXT_DefineCode_Xt_typecode_N ;
         gxTv_SdtXT_DefineCode_Xt_tenantcode_N = sdt.gxTv_SdtXT_DefineCode_Xt_tenantcode_N ;
         gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_N = sdt.gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_DefineCode_Xt_definecodeid), 18, 0)), false);
         AddObjectProperty("XT_DefineCodeName", gxTv_SdtXT_DefineCode_Xt_definecodename, false);
         AddObjectProperty("XT_DefineCodeName_N", gxTv_SdtXT_DefineCode_Xt_definecodename_N, false);
         AddObjectProperty("XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_DefineCode_Xt_defindcodetypeid), 18, 0)), false);
         AddObjectProperty("XT_DefindcodeTypeName", gxTv_SdtXT_DefineCode_Xt_defindcodetypename, false);
         AddObjectProperty("XT_DefindcodeTypeName_N", gxTv_SdtXT_DefineCode_Xt_defindcodetypename_N, false);
         AddObjectProperty("XT_DefineCodeOrder", gxTv_SdtXT_DefineCode_Xt_definecodeorder, false);
         AddObjectProperty("XT_DefineCodeOrder_N", gxTv_SdtXT_DefineCode_Xt_definecodeorder_N, false);
         AddObjectProperty("XT_TypeCode", gxTv_SdtXT_DefineCode_Xt_typecode, false);
         AddObjectProperty("XT_TypeCode_N", gxTv_SdtXT_DefineCode_Xt_typecode_N, false);
         AddObjectProperty("XT_TenantCode", gxTv_SdtXT_DefineCode_Xt_tenantcode, false);
         AddObjectProperty("XT_TenantCode_N", gxTv_SdtXT_DefineCode_Xt_tenantcode_N, false);
         AddObjectProperty("XT_DefineCodeIntialType", gxTv_SdtXT_DefineCode_Xt_definecodeintialtype, false);
         AddObjectProperty("XT_DefineCodeIntialType_N", gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtXT_DefineCode_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtXT_DefineCode_Initialized, false);
            AddObjectProperty("XT_DefineCodeID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_DefineCode_Xt_definecodeid_Z), 18, 0)), false);
            AddObjectProperty("XT_DefineCodeName_Z", gxTv_SdtXT_DefineCode_Xt_definecodename_Z, false);
            AddObjectProperty("XT_DefindcodeTypeID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_DefineCode_Xt_defindcodetypeid_Z), 18, 0)), false);
            AddObjectProperty("XT_DefindcodeTypeName_Z", gxTv_SdtXT_DefineCode_Xt_defindcodetypename_Z, false);
            AddObjectProperty("XT_DefineCodeOrder_Z", gxTv_SdtXT_DefineCode_Xt_definecodeorder_Z, false);
            AddObjectProperty("XT_TypeCode_Z", gxTv_SdtXT_DefineCode_Xt_typecode_Z, false);
            AddObjectProperty("XT_TenantCode_Z", gxTv_SdtXT_DefineCode_Xt_tenantcode_Z, false);
            AddObjectProperty("XT_DefineCodeIntialType_Z", gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_Z, false);
            AddObjectProperty("XT_DefineCodeName_N", gxTv_SdtXT_DefineCode_Xt_definecodename_N, false);
            AddObjectProperty("XT_DefindcodeTypeName_N", gxTv_SdtXT_DefineCode_Xt_defindcodetypename_N, false);
            AddObjectProperty("XT_DefineCodeOrder_N", gxTv_SdtXT_DefineCode_Xt_definecodeorder_N, false);
            AddObjectProperty("XT_TypeCode_N", gxTv_SdtXT_DefineCode_Xt_typecode_N, false);
            AddObjectProperty("XT_TenantCode_N", gxTv_SdtXT_DefineCode_Xt_tenantcode_N, false);
            AddObjectProperty("XT_DefineCodeIntialType_N", gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtXT_DefineCode sdt )
      {
         if ( sdt.IsDirty("XT_DefineCodeID") )
         {
            gxTv_SdtXT_DefineCode_Xt_definecodeid = sdt.gxTv_SdtXT_DefineCode_Xt_definecodeid ;
         }
         if ( sdt.IsDirty("XT_DefineCodeName") )
         {
            gxTv_SdtXT_DefineCode_Xt_definecodename = sdt.gxTv_SdtXT_DefineCode_Xt_definecodename ;
         }
         if ( sdt.IsDirty("XT_DefindcodeTypeID") )
         {
            gxTv_SdtXT_DefineCode_Xt_defindcodetypeid = sdt.gxTv_SdtXT_DefineCode_Xt_defindcodetypeid ;
         }
         if ( sdt.IsDirty("XT_DefindcodeTypeName") )
         {
            gxTv_SdtXT_DefineCode_Xt_defindcodetypename = sdt.gxTv_SdtXT_DefineCode_Xt_defindcodetypename ;
         }
         if ( sdt.IsDirty("XT_DefineCodeOrder") )
         {
            gxTv_SdtXT_DefineCode_Xt_definecodeorder = sdt.gxTv_SdtXT_DefineCode_Xt_definecodeorder ;
         }
         if ( sdt.IsDirty("XT_TypeCode") )
         {
            gxTv_SdtXT_DefineCode_Xt_typecode = sdt.gxTv_SdtXT_DefineCode_Xt_typecode ;
         }
         if ( sdt.IsDirty("XT_TenantCode") )
         {
            gxTv_SdtXT_DefineCode_Xt_tenantcode = sdt.gxTv_SdtXT_DefineCode_Xt_tenantcode ;
         }
         if ( sdt.IsDirty("XT_DefineCodeIntialType") )
         {
            gxTv_SdtXT_DefineCode_Xt_definecodeintialtype = sdt.gxTv_SdtXT_DefineCode_Xt_definecodeintialtype ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "XT_DefineCodeID" )]
      [  XmlElement( ElementName = "XT_DefineCodeID"   )]
      public long gxTpr_Xt_definecodeid
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_definecodeid ;
         }

         set {
            if ( gxTv_SdtXT_DefineCode_Xt_definecodeid != value )
            {
               gxTv_SdtXT_DefineCode_Mode = "INS";
               this.gxTv_SdtXT_DefineCode_Xt_definecodeid_Z_SetNull( );
               this.gxTv_SdtXT_DefineCode_Xt_definecodename_Z_SetNull( );
               this.gxTv_SdtXT_DefineCode_Xt_defindcodetypeid_Z_SetNull( );
               this.gxTv_SdtXT_DefineCode_Xt_defindcodetypename_Z_SetNull( );
               this.gxTv_SdtXT_DefineCode_Xt_definecodeorder_Z_SetNull( );
               this.gxTv_SdtXT_DefineCode_Xt_typecode_Z_SetNull( );
               this.gxTv_SdtXT_DefineCode_Xt_tenantcode_Z_SetNull( );
               this.gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_Z_SetNull( );
            }
            gxTv_SdtXT_DefineCode_Xt_definecodeid = value;
            SetDirty("Xt_definecodeid");
         }

      }

      [  SoapElement( ElementName = "XT_DefineCodeName" )]
      [  XmlElement( ElementName = "XT_DefineCodeName"   )]
      public String gxTpr_Xt_definecodename
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_definecodename ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_definecodename_N = 0;
            gxTv_SdtXT_DefineCode_Xt_definecodename = value;
            SetDirty("Xt_definecodename");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_definecodename_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_definecodename_N = 1;
         gxTv_SdtXT_DefineCode_Xt_definecodename = "";
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_definecodename_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefindcodeTypeID" )]
      [  XmlElement( ElementName = "XT_DefindcodeTypeID"   )]
      public long gxTpr_Xt_defindcodetypeid
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_defindcodetypeid ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_defindcodetypeid = value;
            SetDirty("Xt_defindcodetypeid");
         }

      }

      [  SoapElement( ElementName = "XT_DefindcodeTypeName" )]
      [  XmlElement( ElementName = "XT_DefindcodeTypeName"   )]
      public String gxTpr_Xt_defindcodetypename
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_defindcodetypename ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_defindcodetypename_N = 0;
            gxTv_SdtXT_DefineCode_Xt_defindcodetypename = value;
            SetDirty("Xt_defindcodetypename");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_defindcodetypename_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_defindcodetypename_N = 1;
         gxTv_SdtXT_DefineCode_Xt_defindcodetypename = "";
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_defindcodetypename_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefineCodeOrder" )]
      [  XmlElement( ElementName = "XT_DefineCodeOrder"   )]
      public short gxTpr_Xt_definecodeorder
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_definecodeorder ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_definecodeorder_N = 0;
            gxTv_SdtXT_DefineCode_Xt_definecodeorder = value;
            SetDirty("Xt_definecodeorder");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_definecodeorder_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_definecodeorder_N = 1;
         gxTv_SdtXT_DefineCode_Xt_definecodeorder = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_definecodeorder_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_TypeCode" )]
      [  XmlElement( ElementName = "XT_TypeCode"   )]
      public String gxTpr_Xt_typecode
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_typecode ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_typecode_N = 0;
            gxTv_SdtXT_DefineCode_Xt_typecode = value;
            SetDirty("Xt_typecode");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_typecode_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_typecode_N = 1;
         gxTv_SdtXT_DefineCode_Xt_typecode = "";
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_typecode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_TenantCode" )]
      [  XmlElement( ElementName = "XT_TenantCode"   )]
      public String gxTpr_Xt_tenantcode
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_tenantcode ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_tenantcode_N = 0;
            gxTv_SdtXT_DefineCode_Xt_tenantcode = value;
            SetDirty("Xt_tenantcode");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_tenantcode_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_tenantcode_N = 1;
         gxTv_SdtXT_DefineCode_Xt_tenantcode = "";
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_tenantcode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefineCodeIntialType" )]
      [  XmlElement( ElementName = "XT_DefineCodeIntialType"   )]
      public short gxTpr_Xt_definecodeintialtype
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_definecodeintialtype ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_N = 0;
            gxTv_SdtXT_DefineCode_Xt_definecodeintialtype = value;
            SetDirty("Xt_definecodeintialtype");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_N = 1;
         gxTv_SdtXT_DefineCode_Xt_definecodeintialtype = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtXT_DefineCode_Mode ;
         }

         set {
            gxTv_SdtXT_DefineCode_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtXT_DefineCode_Mode_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Mode = "";
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtXT_DefineCode_Initialized ;
         }

         set {
            gxTv_SdtXT_DefineCode_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtXT_DefineCode_Initialized_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefineCodeID_Z" )]
      [  XmlElement( ElementName = "XT_DefineCodeID_Z"   )]
      public long gxTpr_Xt_definecodeid_Z
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_definecodeid_Z ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_definecodeid_Z = value;
            SetDirty("Xt_definecodeid_Z");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_definecodeid_Z_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_definecodeid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_definecodeid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefineCodeName_Z" )]
      [  XmlElement( ElementName = "XT_DefineCodeName_Z"   )]
      public String gxTpr_Xt_definecodename_Z
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_definecodename_Z ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_definecodename_Z = value;
            SetDirty("Xt_definecodename_Z");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_definecodename_Z_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_definecodename_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_definecodename_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefindcodeTypeID_Z" )]
      [  XmlElement( ElementName = "XT_DefindcodeTypeID_Z"   )]
      public long gxTpr_Xt_defindcodetypeid_Z
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_defindcodetypeid_Z ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_defindcodetypeid_Z = value;
            SetDirty("Xt_defindcodetypeid_Z");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_defindcodetypeid_Z_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_defindcodetypeid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_defindcodetypeid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefindcodeTypeName_Z" )]
      [  XmlElement( ElementName = "XT_DefindcodeTypeName_Z"   )]
      public String gxTpr_Xt_defindcodetypename_Z
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_defindcodetypename_Z ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_defindcodetypename_Z = value;
            SetDirty("Xt_defindcodetypename_Z");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_defindcodetypename_Z_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_defindcodetypename_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_defindcodetypename_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefineCodeOrder_Z" )]
      [  XmlElement( ElementName = "XT_DefineCodeOrder_Z"   )]
      public short gxTpr_Xt_definecodeorder_Z
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_definecodeorder_Z ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_definecodeorder_Z = value;
            SetDirty("Xt_definecodeorder_Z");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_definecodeorder_Z_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_definecodeorder_Z = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_definecodeorder_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_TypeCode_Z" )]
      [  XmlElement( ElementName = "XT_TypeCode_Z"   )]
      public String gxTpr_Xt_typecode_Z
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_typecode_Z ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_typecode_Z = value;
            SetDirty("Xt_typecode_Z");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_typecode_Z_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_typecode_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_typecode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_TenantCode_Z" )]
      [  XmlElement( ElementName = "XT_TenantCode_Z"   )]
      public String gxTpr_Xt_tenantcode_Z
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_tenantcode_Z ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_tenantcode_Z = value;
            SetDirty("Xt_tenantcode_Z");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_tenantcode_Z_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_tenantcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_tenantcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefineCodeIntialType_Z" )]
      [  XmlElement( ElementName = "XT_DefineCodeIntialType_Z"   )]
      public short gxTpr_Xt_definecodeintialtype_Z
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_Z ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_Z = value;
            SetDirty("Xt_definecodeintialtype_Z");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_Z_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_Z = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefineCodeName_N" )]
      [  XmlElement( ElementName = "XT_DefineCodeName_N"   )]
      public short gxTpr_Xt_definecodename_N
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_definecodename_N ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_definecodename_N = value;
            SetDirty("Xt_definecodename_N");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_definecodename_N_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_definecodename_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_definecodename_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefindcodeTypeName_N" )]
      [  XmlElement( ElementName = "XT_DefindcodeTypeName_N"   )]
      public short gxTpr_Xt_defindcodetypename_N
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_defindcodetypename_N ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_defindcodetypename_N = value;
            SetDirty("Xt_defindcodetypename_N");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_defindcodetypename_N_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_defindcodetypename_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_defindcodetypename_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefineCodeOrder_N" )]
      [  XmlElement( ElementName = "XT_DefineCodeOrder_N"   )]
      public short gxTpr_Xt_definecodeorder_N
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_definecodeorder_N ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_definecodeorder_N = value;
            SetDirty("Xt_definecodeorder_N");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_definecodeorder_N_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_definecodeorder_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_definecodeorder_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_TypeCode_N" )]
      [  XmlElement( ElementName = "XT_TypeCode_N"   )]
      public short gxTpr_Xt_typecode_N
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_typecode_N ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_typecode_N = value;
            SetDirty("Xt_typecode_N");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_typecode_N_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_typecode_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_typecode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_TenantCode_N" )]
      [  XmlElement( ElementName = "XT_TenantCode_N"   )]
      public short gxTpr_Xt_tenantcode_N
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_tenantcode_N ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_tenantcode_N = value;
            SetDirty("Xt_tenantcode_N");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_tenantcode_N_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_tenantcode_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_tenantcode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefineCodeIntialType_N" )]
      [  XmlElement( ElementName = "XT_DefineCodeIntialType_N"   )]
      public short gxTpr_Xt_definecodeintialtype_N
      {
         get {
            return gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_N ;
         }

         set {
            gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_N = value;
            SetDirty("Xt_definecodeintialtype_N");
         }

      }

      public void gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_N_SetNull( )
      {
         gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtXT_DefineCode_Xt_definecodename = "";
         gxTv_SdtXT_DefineCode_Xt_defindcodetypename = "";
         gxTv_SdtXT_DefineCode_Xt_typecode = "";
         gxTv_SdtXT_DefineCode_Xt_tenantcode = "";
         gxTv_SdtXT_DefineCode_Mode = "";
         gxTv_SdtXT_DefineCode_Xt_definecodename_Z = "";
         gxTv_SdtXT_DefineCode_Xt_defindcodetypename_Z = "";
         gxTv_SdtXT_DefineCode_Xt_typecode_Z = "";
         gxTv_SdtXT_DefineCode_Xt_tenantcode_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "xt_definecode", "GeneXus.Programs.xt_definecode_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtXT_DefineCode_Xt_definecodeorder ;
      private short gxTv_SdtXT_DefineCode_Xt_definecodeintialtype ;
      private short gxTv_SdtXT_DefineCode_Initialized ;
      private short gxTv_SdtXT_DefineCode_Xt_definecodeorder_Z ;
      private short gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_Z ;
      private short gxTv_SdtXT_DefineCode_Xt_definecodename_N ;
      private short gxTv_SdtXT_DefineCode_Xt_defindcodetypename_N ;
      private short gxTv_SdtXT_DefineCode_Xt_definecodeorder_N ;
      private short gxTv_SdtXT_DefineCode_Xt_typecode_N ;
      private short gxTv_SdtXT_DefineCode_Xt_tenantcode_N ;
      private short gxTv_SdtXT_DefineCode_Xt_definecodeintialtype_N ;
      private long gxTv_SdtXT_DefineCode_Xt_definecodeid ;
      private long gxTv_SdtXT_DefineCode_Xt_defindcodetypeid ;
      private long gxTv_SdtXT_DefineCode_Xt_definecodeid_Z ;
      private long gxTv_SdtXT_DefineCode_Xt_defindcodetypeid_Z ;
      private String gxTv_SdtXT_DefineCode_Mode ;
      private String gxTv_SdtXT_DefineCode_Xt_definecodename ;
      private String gxTv_SdtXT_DefineCode_Xt_defindcodetypename ;
      private String gxTv_SdtXT_DefineCode_Xt_typecode ;
      private String gxTv_SdtXT_DefineCode_Xt_tenantcode ;
      private String gxTv_SdtXT_DefineCode_Xt_definecodename_Z ;
      private String gxTv_SdtXT_DefineCode_Xt_defindcodetypename_Z ;
      private String gxTv_SdtXT_DefineCode_Xt_typecode_Z ;
      private String gxTv_SdtXT_DefineCode_Xt_tenantcode_Z ;
   }

   [DataContract(Name = @"XT_DefineCode", Namespace = "DataAnalysisPlatform")]
   public class SdtXT_DefineCode_RESTInterface : GxGenericCollectionItem<SdtXT_DefineCode>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtXT_DefineCode_RESTInterface( ) : base()
      {
      }

      public SdtXT_DefineCode_RESTInterface( SdtXT_DefineCode psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "XT_DefineCodeID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Xt_definecodeid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Xt_definecodeid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Xt_definecodeid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "XT_DefineCodeName" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Xt_definecodename
      {
         get {
            return sdt.gxTpr_Xt_definecodename ;
         }

         set {
            sdt.gxTpr_Xt_definecodename = value;
         }

      }

      [DataMember( Name = "XT_DefindcodeTypeID" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Xt_defindcodetypeid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Xt_defindcodetypeid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Xt_defindcodetypeid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "XT_DefindcodeTypeName" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Xt_defindcodetypename
      {
         get {
            return sdt.gxTpr_Xt_defindcodetypename ;
         }

         set {
            sdt.gxTpr_Xt_defindcodetypename = value;
         }

      }

      [DataMember( Name = "XT_DefineCodeOrder" , Order = 4 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Xt_definecodeorder
      {
         get {
            return sdt.gxTpr_Xt_definecodeorder ;
         }

         set {
            sdt.gxTpr_Xt_definecodeorder = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "XT_TypeCode" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Xt_typecode
      {
         get {
            return sdt.gxTpr_Xt_typecode ;
         }

         set {
            sdt.gxTpr_Xt_typecode = value;
         }

      }

      [DataMember( Name = "XT_TenantCode" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Xt_tenantcode
      {
         get {
            return sdt.gxTpr_Xt_tenantcode ;
         }

         set {
            sdt.gxTpr_Xt_tenantcode = value;
         }

      }

      [DataMember( Name = "XT_DefineCodeIntialType" , Order = 7 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Xt_definecodeintialtype
      {
         get {
            return sdt.gxTpr_Xt_definecodeintialtype ;
         }

         set {
            sdt.gxTpr_Xt_definecodeintialtype = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtXT_DefineCode sdt
      {
         get {
            return (SdtXT_DefineCode)Sdt ;
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
            sdt = new SdtXT_DefineCode() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 8 )]
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
