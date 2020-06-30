/*
               File: wwpbaseobjects.type_SdtSecRole
        Description: ½ÇÉ«
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:25.95
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
namespace GeneXus.Programs.wwpbaseobjects {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "SecRole" )]
   [XmlType(TypeName =  "SecRole" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSecRole : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSecRole( )
      {
      }

      public SdtSecRole( IGxContext context )
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

      public void Load( short AV4SecRoleId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV4SecRoleId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SecRoleId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "WWPBaseObjects\\SecRole");
         metadata.Set("BT", "SecRole");
         metadata.Set("PK", "[ \"SecRoleId\" ]");
         metadata.Set("PKAssigned", "[ \"SecRoleId\" ]");
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
         state.Add("gxTpr_Secroleid_Z");
         state.Add("gxTpr_Secrolename_Z");
         state.Add("gxTpr_Secroledescription_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         GeneXus.Programs.wwpbaseobjects.SdtSecRole sdt ;
         sdt = (GeneXus.Programs.wwpbaseobjects.SdtSecRole)(source);
         gxTv_SdtSecRole_Secroleid = sdt.gxTv_SdtSecRole_Secroleid ;
         gxTv_SdtSecRole_Secrolename = sdt.gxTv_SdtSecRole_Secrolename ;
         gxTv_SdtSecRole_Secroledescription = sdt.gxTv_SdtSecRole_Secroledescription ;
         gxTv_SdtSecRole_Mode = sdt.gxTv_SdtSecRole_Mode ;
         gxTv_SdtSecRole_Initialized = sdt.gxTv_SdtSecRole_Initialized ;
         gxTv_SdtSecRole_Secroleid_Z = sdt.gxTv_SdtSecRole_Secroleid_Z ;
         gxTv_SdtSecRole_Secrolename_Z = sdt.gxTv_SdtSecRole_Secrolename_Z ;
         gxTv_SdtSecRole_Secroledescription_Z = sdt.gxTv_SdtSecRole_Secroledescription_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SecRoleId", gxTv_SdtSecRole_Secroleid, false);
         AddObjectProperty("SecRoleName", gxTv_SdtSecRole_Secrolename, false);
         AddObjectProperty("SecRoleDescription", gxTv_SdtSecRole_Secroledescription, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSecRole_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSecRole_Initialized, false);
            AddObjectProperty("SecRoleId_Z", gxTv_SdtSecRole_Secroleid_Z, false);
            AddObjectProperty("SecRoleName_Z", gxTv_SdtSecRole_Secrolename_Z, false);
            AddObjectProperty("SecRoleDescription_Z", gxTv_SdtSecRole_Secroledescription_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( GeneXus.Programs.wwpbaseobjects.SdtSecRole sdt )
      {
         if ( sdt.IsDirty("SecRoleId") )
         {
            gxTv_SdtSecRole_Secroleid = sdt.gxTv_SdtSecRole_Secroleid ;
         }
         if ( sdt.IsDirty("SecRoleName") )
         {
            gxTv_SdtSecRole_Secrolename = sdt.gxTv_SdtSecRole_Secrolename ;
         }
         if ( sdt.IsDirty("SecRoleDescription") )
         {
            gxTv_SdtSecRole_Secroledescription = sdt.gxTv_SdtSecRole_Secroledescription ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SecRoleId" )]
      [  XmlElement( ElementName = "SecRoleId"   )]
      public short gxTpr_Secroleid
      {
         get {
            return gxTv_SdtSecRole_Secroleid ;
         }

         set {
            if ( gxTv_SdtSecRole_Secroleid != value )
            {
               gxTv_SdtSecRole_Mode = "INS";
               this.gxTv_SdtSecRole_Secroleid_Z_SetNull( );
               this.gxTv_SdtSecRole_Secrolename_Z_SetNull( );
               this.gxTv_SdtSecRole_Secroledescription_Z_SetNull( );
            }
            gxTv_SdtSecRole_Secroleid = value;
            SetDirty("Secroleid");
         }

      }

      [  SoapElement( ElementName = "SecRoleName" )]
      [  XmlElement( ElementName = "SecRoleName"   )]
      public String gxTpr_Secrolename
      {
         get {
            return gxTv_SdtSecRole_Secrolename ;
         }

         set {
            gxTv_SdtSecRole_Secrolename = value;
            SetDirty("Secrolename");
         }

      }

      [  SoapElement( ElementName = "SecRoleDescription" )]
      [  XmlElement( ElementName = "SecRoleDescription"   )]
      public String gxTpr_Secroledescription
      {
         get {
            return gxTv_SdtSecRole_Secroledescription ;
         }

         set {
            gxTv_SdtSecRole_Secroledescription = value;
            SetDirty("Secroledescription");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSecRole_Mode ;
         }

         set {
            gxTv_SdtSecRole_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSecRole_Mode_SetNull( )
      {
         gxTv_SdtSecRole_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSecRole_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSecRole_Initialized ;
         }

         set {
            gxTv_SdtSecRole_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSecRole_Initialized_SetNull( )
      {
         gxTv_SdtSecRole_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSecRole_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecRoleId_Z" )]
      [  XmlElement( ElementName = "SecRoleId_Z"   )]
      public short gxTpr_Secroleid_Z
      {
         get {
            return gxTv_SdtSecRole_Secroleid_Z ;
         }

         set {
            gxTv_SdtSecRole_Secroleid_Z = value;
            SetDirty("Secroleid_Z");
         }

      }

      public void gxTv_SdtSecRole_Secroleid_Z_SetNull( )
      {
         gxTv_SdtSecRole_Secroleid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSecRole_Secroleid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecRoleName_Z" )]
      [  XmlElement( ElementName = "SecRoleName_Z"   )]
      public String gxTpr_Secrolename_Z
      {
         get {
            return gxTv_SdtSecRole_Secrolename_Z ;
         }

         set {
            gxTv_SdtSecRole_Secrolename_Z = value;
            SetDirty("Secrolename_Z");
         }

      }

      public void gxTv_SdtSecRole_Secrolename_Z_SetNull( )
      {
         gxTv_SdtSecRole_Secrolename_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecRole_Secrolename_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecRoleDescription_Z" )]
      [  XmlElement( ElementName = "SecRoleDescription_Z"   )]
      public String gxTpr_Secroledescription_Z
      {
         get {
            return gxTv_SdtSecRole_Secroledescription_Z ;
         }

         set {
            gxTv_SdtSecRole_Secroledescription_Z = value;
            SetDirty("Secroledescription_Z");
         }

      }

      public void gxTv_SdtSecRole_Secroledescription_Z_SetNull( )
      {
         gxTv_SdtSecRole_Secroledescription_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecRole_Secroledescription_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSecRole_Secrolename = "";
         gxTv_SdtSecRole_Secroledescription = "";
         gxTv_SdtSecRole_Mode = "";
         gxTv_SdtSecRole_Secrolename_Z = "";
         gxTv_SdtSecRole_Secroledescription_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "secrole", "GeneXus.Programs.wwpbaseobjects.secrole_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSecRole_Secroleid ;
      private short gxTv_SdtSecRole_Initialized ;
      private short gxTv_SdtSecRole_Secroleid_Z ;
      private String gxTv_SdtSecRole_Mode ;
      private String gxTv_SdtSecRole_Secrolename ;
      private String gxTv_SdtSecRole_Secroledescription ;
      private String gxTv_SdtSecRole_Secrolename_Z ;
      private String gxTv_SdtSecRole_Secroledescription_Z ;
   }

   [DataContract(Name = @"WWPBaseObjects\SecRole", Namespace = "DataAnalysisPlatform")]
   public class SdtSecRole_RESTInterface : GxGenericCollectionItem<GeneXus.Programs.wwpbaseobjects.SdtSecRole>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSecRole_RESTInterface( ) : base()
      {
      }

      public SdtSecRole_RESTInterface( GeneXus.Programs.wwpbaseobjects.SdtSecRole psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SecRoleId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Secroleid
      {
         get {
            return sdt.gxTpr_Secroleid ;
         }

         set {
            sdt.gxTpr_Secroleid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "SecRoleName" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Secrolename
      {
         get {
            return sdt.gxTpr_Secrolename ;
         }

         set {
            sdt.gxTpr_Secrolename = value;
         }

      }

      [DataMember( Name = "SecRoleDescription" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Secroledescription
      {
         get {
            return sdt.gxTpr_Secroledescription ;
         }

         set {
            sdt.gxTpr_Secroledescription = value;
         }

      }

      public GeneXus.Programs.wwpbaseobjects.SdtSecRole sdt
      {
         get {
            return (GeneXus.Programs.wwpbaseobjects.SdtSecRole)Sdt ;
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
            sdt = new GeneXus.Programs.wwpbaseobjects.SdtSecRole() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 3 )]
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
