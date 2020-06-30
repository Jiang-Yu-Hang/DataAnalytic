/*
               File: type_SdtSYS_Permission
        Description: SYS_Permission
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:53.14
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
   [XmlRoot(ElementName = "SYS_Permission" )]
   [XmlType(TypeName =  "SYS_Permission" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSYS_Permission : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_Permission( )
      {
      }

      public SdtSYS_Permission( IGxContext context )
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

      public void Load( String AV362PermissionCode )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(String)AV362PermissionCode});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"PermissionCode", typeof(String)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "SYS_Permission");
         metadata.Set("BT", "SYS_PERMISSION");
         metadata.Set("PK", "[ \"PermissionCode\" ]");
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
         state.Add("gxTpr_Permissioncode_Z");
         state.Add("gxTpr_Permissionname_Z");
         state.Add("gxTpr_Orderindex_Z");
         state.Add("gxTpr_Sys_permissionmodulecode_Z");
         state.Add("gxTpr_Sys_permissionisdeleted_Z");
         state.Add("gxTpr_Sys_permissiondescription_N");
         state.Add("gxTpr_Sys_permissionmodulecode_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSYS_Permission sdt ;
         sdt = (SdtSYS_Permission)(source);
         gxTv_SdtSYS_Permission_Permissioncode = sdt.gxTv_SdtSYS_Permission_Permissioncode ;
         gxTv_SdtSYS_Permission_Permissionname = sdt.gxTv_SdtSYS_Permission_Permissionname ;
         gxTv_SdtSYS_Permission_Orderindex = sdt.gxTv_SdtSYS_Permission_Orderindex ;
         gxTv_SdtSYS_Permission_Sys_permissiondescription = sdt.gxTv_SdtSYS_Permission_Sys_permissiondescription ;
         gxTv_SdtSYS_Permission_Sys_permissionmodulecode = sdt.gxTv_SdtSYS_Permission_Sys_permissionmodulecode ;
         gxTv_SdtSYS_Permission_Sys_permissionisdeleted = sdt.gxTv_SdtSYS_Permission_Sys_permissionisdeleted ;
         gxTv_SdtSYS_Permission_Mode = sdt.gxTv_SdtSYS_Permission_Mode ;
         gxTv_SdtSYS_Permission_Initialized = sdt.gxTv_SdtSYS_Permission_Initialized ;
         gxTv_SdtSYS_Permission_Permissioncode_Z = sdt.gxTv_SdtSYS_Permission_Permissioncode_Z ;
         gxTv_SdtSYS_Permission_Permissionname_Z = sdt.gxTv_SdtSYS_Permission_Permissionname_Z ;
         gxTv_SdtSYS_Permission_Orderindex_Z = sdt.gxTv_SdtSYS_Permission_Orderindex_Z ;
         gxTv_SdtSYS_Permission_Sys_permissionmodulecode_Z = sdt.gxTv_SdtSYS_Permission_Sys_permissionmodulecode_Z ;
         gxTv_SdtSYS_Permission_Sys_permissionisdeleted_Z = sdt.gxTv_SdtSYS_Permission_Sys_permissionisdeleted_Z ;
         gxTv_SdtSYS_Permission_Sys_permissiondescription_N = sdt.gxTv_SdtSYS_Permission_Sys_permissiondescription_N ;
         gxTv_SdtSYS_Permission_Sys_permissionmodulecode_N = sdt.gxTv_SdtSYS_Permission_Sys_permissionmodulecode_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("PermissionCode", gxTv_SdtSYS_Permission_Permissioncode, false);
         AddObjectProperty("PermissionName", gxTv_SdtSYS_Permission_Permissionname, false);
         AddObjectProperty("OrderIndex", gxTv_SdtSYS_Permission_Orderindex, false);
         AddObjectProperty("SYS_PermissionDescription", gxTv_SdtSYS_Permission_Sys_permissiondescription, false);
         AddObjectProperty("SYS_PermissionDescription_N", gxTv_SdtSYS_Permission_Sys_permissiondescription_N, false);
         AddObjectProperty("SYS_PermissionModuleCode", gxTv_SdtSYS_Permission_Sys_permissionmodulecode, false);
         AddObjectProperty("SYS_PermissionModuleCode_N", gxTv_SdtSYS_Permission_Sys_permissionmodulecode_N, false);
         AddObjectProperty("SYS_PermissionIsDeleted", gxTv_SdtSYS_Permission_Sys_permissionisdeleted, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSYS_Permission_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSYS_Permission_Initialized, false);
            AddObjectProperty("PermissionCode_Z", gxTv_SdtSYS_Permission_Permissioncode_Z, false);
            AddObjectProperty("PermissionName_Z", gxTv_SdtSYS_Permission_Permissionname_Z, false);
            AddObjectProperty("OrderIndex_Z", gxTv_SdtSYS_Permission_Orderindex_Z, false);
            AddObjectProperty("SYS_PermissionModuleCode_Z", gxTv_SdtSYS_Permission_Sys_permissionmodulecode_Z, false);
            AddObjectProperty("SYS_PermissionIsDeleted_Z", gxTv_SdtSYS_Permission_Sys_permissionisdeleted_Z, false);
            AddObjectProperty("SYS_PermissionDescription_N", gxTv_SdtSYS_Permission_Sys_permissiondescription_N, false);
            AddObjectProperty("SYS_PermissionModuleCode_N", gxTv_SdtSYS_Permission_Sys_permissionmodulecode_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSYS_Permission sdt )
      {
         if ( sdt.IsDirty("PermissionCode") )
         {
            gxTv_SdtSYS_Permission_Permissioncode = sdt.gxTv_SdtSYS_Permission_Permissioncode ;
         }
         if ( sdt.IsDirty("PermissionName") )
         {
            gxTv_SdtSYS_Permission_Permissionname = sdt.gxTv_SdtSYS_Permission_Permissionname ;
         }
         if ( sdt.IsDirty("OrderIndex") )
         {
            gxTv_SdtSYS_Permission_Orderindex = sdt.gxTv_SdtSYS_Permission_Orderindex ;
         }
         if ( sdt.IsDirty("SYS_PermissionDescription") )
         {
            gxTv_SdtSYS_Permission_Sys_permissiondescription = sdt.gxTv_SdtSYS_Permission_Sys_permissiondescription ;
         }
         if ( sdt.IsDirty("SYS_PermissionModuleCode") )
         {
            gxTv_SdtSYS_Permission_Sys_permissionmodulecode = sdt.gxTv_SdtSYS_Permission_Sys_permissionmodulecode ;
         }
         if ( sdt.IsDirty("SYS_PermissionIsDeleted") )
         {
            gxTv_SdtSYS_Permission_Sys_permissionisdeleted = sdt.gxTv_SdtSYS_Permission_Sys_permissionisdeleted ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "PermissionCode" )]
      [  XmlElement( ElementName = "PermissionCode"   )]
      public String gxTpr_Permissioncode
      {
         get {
            return gxTv_SdtSYS_Permission_Permissioncode ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtSYS_Permission_Permissioncode, value) != 0 )
            {
               gxTv_SdtSYS_Permission_Mode = "INS";
               this.gxTv_SdtSYS_Permission_Permissioncode_Z_SetNull( );
               this.gxTv_SdtSYS_Permission_Permissionname_Z_SetNull( );
               this.gxTv_SdtSYS_Permission_Orderindex_Z_SetNull( );
               this.gxTv_SdtSYS_Permission_Sys_permissionmodulecode_Z_SetNull( );
               this.gxTv_SdtSYS_Permission_Sys_permissionisdeleted_Z_SetNull( );
            }
            gxTv_SdtSYS_Permission_Permissioncode = value;
            SetDirty("Permissioncode");
         }

      }

      [  SoapElement( ElementName = "PermissionName" )]
      [  XmlElement( ElementName = "PermissionName"   )]
      public String gxTpr_Permissionname
      {
         get {
            return gxTv_SdtSYS_Permission_Permissionname ;
         }

         set {
            gxTv_SdtSYS_Permission_Permissionname = value;
            SetDirty("Permissionname");
         }

      }

      [  SoapElement( ElementName = "OrderIndex" )]
      [  XmlElement( ElementName = "OrderIndex"   )]
      public int gxTpr_Orderindex
      {
         get {
            return gxTv_SdtSYS_Permission_Orderindex ;
         }

         set {
            gxTv_SdtSYS_Permission_Orderindex = value;
            SetDirty("Orderindex");
         }

      }

      [  SoapElement( ElementName = "SYS_PermissionDescription" )]
      [  XmlElement( ElementName = "SYS_PermissionDescription"   )]
      public String gxTpr_Sys_permissiondescription
      {
         get {
            return gxTv_SdtSYS_Permission_Sys_permissiondescription ;
         }

         set {
            gxTv_SdtSYS_Permission_Sys_permissiondescription_N = 0;
            gxTv_SdtSYS_Permission_Sys_permissiondescription = value;
            SetDirty("Sys_permissiondescription");
         }

      }

      public void gxTv_SdtSYS_Permission_Sys_permissiondescription_SetNull( )
      {
         gxTv_SdtSYS_Permission_Sys_permissiondescription_N = 1;
         gxTv_SdtSYS_Permission_Sys_permissiondescription = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Permission_Sys_permissiondescription_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_PermissionModuleCode" )]
      [  XmlElement( ElementName = "SYS_PermissionModuleCode"   )]
      public String gxTpr_Sys_permissionmodulecode
      {
         get {
            return gxTv_SdtSYS_Permission_Sys_permissionmodulecode ;
         }

         set {
            gxTv_SdtSYS_Permission_Sys_permissionmodulecode_N = 0;
            gxTv_SdtSYS_Permission_Sys_permissionmodulecode = value;
            SetDirty("Sys_permissionmodulecode");
         }

      }

      public void gxTv_SdtSYS_Permission_Sys_permissionmodulecode_SetNull( )
      {
         gxTv_SdtSYS_Permission_Sys_permissionmodulecode_N = 1;
         gxTv_SdtSYS_Permission_Sys_permissionmodulecode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Permission_Sys_permissionmodulecode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_PermissionIsDeleted" )]
      [  XmlElement( ElementName = "SYS_PermissionIsDeleted"   )]
      public short gxTpr_Sys_permissionisdeleted
      {
         get {
            return gxTv_SdtSYS_Permission_Sys_permissionisdeleted ;
         }

         set {
            gxTv_SdtSYS_Permission_Sys_permissionisdeleted = value;
            SetDirty("Sys_permissionisdeleted");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSYS_Permission_Mode ;
         }

         set {
            gxTv_SdtSYS_Permission_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSYS_Permission_Mode_SetNull( )
      {
         gxTv_SdtSYS_Permission_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Permission_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSYS_Permission_Initialized ;
         }

         set {
            gxTv_SdtSYS_Permission_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSYS_Permission_Initialized_SetNull( )
      {
         gxTv_SdtSYS_Permission_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Permission_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "PermissionCode_Z" )]
      [  XmlElement( ElementName = "PermissionCode_Z"   )]
      public String gxTpr_Permissioncode_Z
      {
         get {
            return gxTv_SdtSYS_Permission_Permissioncode_Z ;
         }

         set {
            gxTv_SdtSYS_Permission_Permissioncode_Z = value;
            SetDirty("Permissioncode_Z");
         }

      }

      public void gxTv_SdtSYS_Permission_Permissioncode_Z_SetNull( )
      {
         gxTv_SdtSYS_Permission_Permissioncode_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Permission_Permissioncode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "PermissionName_Z" )]
      [  XmlElement( ElementName = "PermissionName_Z"   )]
      public String gxTpr_Permissionname_Z
      {
         get {
            return gxTv_SdtSYS_Permission_Permissionname_Z ;
         }

         set {
            gxTv_SdtSYS_Permission_Permissionname_Z = value;
            SetDirty("Permissionname_Z");
         }

      }

      public void gxTv_SdtSYS_Permission_Permissionname_Z_SetNull( )
      {
         gxTv_SdtSYS_Permission_Permissionname_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Permission_Permissionname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "OrderIndex_Z" )]
      [  XmlElement( ElementName = "OrderIndex_Z"   )]
      public int gxTpr_Orderindex_Z
      {
         get {
            return gxTv_SdtSYS_Permission_Orderindex_Z ;
         }

         set {
            gxTv_SdtSYS_Permission_Orderindex_Z = value;
            SetDirty("Orderindex_Z");
         }

      }

      public void gxTv_SdtSYS_Permission_Orderindex_Z_SetNull( )
      {
         gxTv_SdtSYS_Permission_Orderindex_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Permission_Orderindex_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_PermissionModuleCode_Z" )]
      [  XmlElement( ElementName = "SYS_PermissionModuleCode_Z"   )]
      public String gxTpr_Sys_permissionmodulecode_Z
      {
         get {
            return gxTv_SdtSYS_Permission_Sys_permissionmodulecode_Z ;
         }

         set {
            gxTv_SdtSYS_Permission_Sys_permissionmodulecode_Z = value;
            SetDirty("Sys_permissionmodulecode_Z");
         }

      }

      public void gxTv_SdtSYS_Permission_Sys_permissionmodulecode_Z_SetNull( )
      {
         gxTv_SdtSYS_Permission_Sys_permissionmodulecode_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Permission_Sys_permissionmodulecode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_PermissionIsDeleted_Z" )]
      [  XmlElement( ElementName = "SYS_PermissionIsDeleted_Z"   )]
      public short gxTpr_Sys_permissionisdeleted_Z
      {
         get {
            return gxTv_SdtSYS_Permission_Sys_permissionisdeleted_Z ;
         }

         set {
            gxTv_SdtSYS_Permission_Sys_permissionisdeleted_Z = value;
            SetDirty("Sys_permissionisdeleted_Z");
         }

      }

      public void gxTv_SdtSYS_Permission_Sys_permissionisdeleted_Z_SetNull( )
      {
         gxTv_SdtSYS_Permission_Sys_permissionisdeleted_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Permission_Sys_permissionisdeleted_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_PermissionDescription_N" )]
      [  XmlElement( ElementName = "SYS_PermissionDescription_N"   )]
      public short gxTpr_Sys_permissiondescription_N
      {
         get {
            return gxTv_SdtSYS_Permission_Sys_permissiondescription_N ;
         }

         set {
            gxTv_SdtSYS_Permission_Sys_permissiondescription_N = value;
            SetDirty("Sys_permissiondescription_N");
         }

      }

      public void gxTv_SdtSYS_Permission_Sys_permissiondescription_N_SetNull( )
      {
         gxTv_SdtSYS_Permission_Sys_permissiondescription_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Permission_Sys_permissiondescription_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_PermissionModuleCode_N" )]
      [  XmlElement( ElementName = "SYS_PermissionModuleCode_N"   )]
      public short gxTpr_Sys_permissionmodulecode_N
      {
         get {
            return gxTv_SdtSYS_Permission_Sys_permissionmodulecode_N ;
         }

         set {
            gxTv_SdtSYS_Permission_Sys_permissionmodulecode_N = value;
            SetDirty("Sys_permissionmodulecode_N");
         }

      }

      public void gxTv_SdtSYS_Permission_Sys_permissionmodulecode_N_SetNull( )
      {
         gxTv_SdtSYS_Permission_Sys_permissionmodulecode_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Permission_Sys_permissionmodulecode_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSYS_Permission_Permissioncode = "";
         gxTv_SdtSYS_Permission_Permissionname = "";
         gxTv_SdtSYS_Permission_Sys_permissiondescription = "";
         gxTv_SdtSYS_Permission_Sys_permissionmodulecode = "";
         gxTv_SdtSYS_Permission_Mode = "";
         gxTv_SdtSYS_Permission_Permissioncode_Z = "";
         gxTv_SdtSYS_Permission_Permissionname_Z = "";
         gxTv_SdtSYS_Permission_Sys_permissionmodulecode_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "sys_permission", "GeneXus.Programs.sys_permission_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSYS_Permission_Sys_permissionisdeleted ;
      private short gxTv_SdtSYS_Permission_Initialized ;
      private short gxTv_SdtSYS_Permission_Sys_permissionisdeleted_Z ;
      private short gxTv_SdtSYS_Permission_Sys_permissiondescription_N ;
      private short gxTv_SdtSYS_Permission_Sys_permissionmodulecode_N ;
      private int gxTv_SdtSYS_Permission_Orderindex ;
      private int gxTv_SdtSYS_Permission_Orderindex_Z ;
      private String gxTv_SdtSYS_Permission_Mode ;
      private String gxTv_SdtSYS_Permission_Sys_permissiondescription ;
      private String gxTv_SdtSYS_Permission_Permissioncode ;
      private String gxTv_SdtSYS_Permission_Permissionname ;
      private String gxTv_SdtSYS_Permission_Sys_permissionmodulecode ;
      private String gxTv_SdtSYS_Permission_Permissioncode_Z ;
      private String gxTv_SdtSYS_Permission_Permissionname_Z ;
      private String gxTv_SdtSYS_Permission_Sys_permissionmodulecode_Z ;
   }

   [DataContract(Name = @"SYS_Permission", Namespace = "DataAnalysisPlatform")]
   public class SdtSYS_Permission_RESTInterface : GxGenericCollectionItem<SdtSYS_Permission>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_Permission_RESTInterface( ) : base()
      {
      }

      public SdtSYS_Permission_RESTInterface( SdtSYS_Permission psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "PermissionCode" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Permissioncode
      {
         get {
            return sdt.gxTpr_Permissioncode ;
         }

         set {
            sdt.gxTpr_Permissioncode = value;
         }

      }

      [DataMember( Name = "PermissionName" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Permissionname
      {
         get {
            return sdt.gxTpr_Permissionname ;
         }

         set {
            sdt.gxTpr_Permissionname = value;
         }

      }

      [DataMember( Name = "OrderIndex" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Orderindex
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Orderindex), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Orderindex = (int)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "SYS_PermissionDescription" , Order = 3 )]
      public String gxTpr_Sys_permissiondescription
      {
         get {
            return sdt.gxTpr_Sys_permissiondescription ;
         }

         set {
            sdt.gxTpr_Sys_permissiondescription = value;
         }

      }

      [DataMember( Name = "SYS_PermissionModuleCode" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Sys_permissionmodulecode
      {
         get {
            return sdt.gxTpr_Sys_permissionmodulecode ;
         }

         set {
            sdt.gxTpr_Sys_permissionmodulecode = value;
         }

      }

      [DataMember( Name = "SYS_PermissionIsDeleted" , Order = 5 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Sys_permissionisdeleted
      {
         get {
            return sdt.gxTpr_Sys_permissionisdeleted ;
         }

         set {
            sdt.gxTpr_Sys_permissionisdeleted = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtSYS_Permission sdt
      {
         get {
            return (SdtSYS_Permission)Sdt ;
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
            sdt = new SdtSYS_Permission() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 6 )]
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
