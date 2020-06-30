/*
               File: type_SdtSYS_InstituteUser
        Description: SYS_Institute User
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:59.91
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
   [XmlRoot(ElementName = "SYS_InstituteUser" )]
   [XmlType(TypeName =  "SYS_InstituteUser" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSYS_InstituteUser : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_InstituteUser( )
      {
      }

      public SdtSYS_InstituteUser( IGxContext context )
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

      public void Load( String AV358InstituteCode ,
                        Guid AV359UserID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(String)AV358InstituteCode,(Guid)AV359UserID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"InstituteCode", typeof(String)}, new Object[]{"UserID", typeof(Guid)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "SYS_InstituteUser");
         metadata.Set("BT", "SYS_INSTITUTEUSER");
         metadata.Set("PK", "[ \"InstituteCode\",\"UserID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"InstituteCode\" ],\"FKMap\":[  ] },{ \"FK\":[ \"UserID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Institutecode_Z");
         state.Add("gxTpr_Userid_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSYS_InstituteUser sdt ;
         sdt = (SdtSYS_InstituteUser)(source);
         gxTv_SdtSYS_InstituteUser_Institutecode = sdt.gxTv_SdtSYS_InstituteUser_Institutecode ;
         gxTv_SdtSYS_InstituteUser_Userid = sdt.gxTv_SdtSYS_InstituteUser_Userid ;
         gxTv_SdtSYS_InstituteUser_Mode = sdt.gxTv_SdtSYS_InstituteUser_Mode ;
         gxTv_SdtSYS_InstituteUser_Initialized = sdt.gxTv_SdtSYS_InstituteUser_Initialized ;
         gxTv_SdtSYS_InstituteUser_Institutecode_Z = sdt.gxTv_SdtSYS_InstituteUser_Institutecode_Z ;
         gxTv_SdtSYS_InstituteUser_Userid_Z = sdt.gxTv_SdtSYS_InstituteUser_Userid_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("InstituteCode", gxTv_SdtSYS_InstituteUser_Institutecode, false);
         AddObjectProperty("UserID", gxTv_SdtSYS_InstituteUser_Userid, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSYS_InstituteUser_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSYS_InstituteUser_Initialized, false);
            AddObjectProperty("InstituteCode_Z", gxTv_SdtSYS_InstituteUser_Institutecode_Z, false);
            AddObjectProperty("UserID_Z", gxTv_SdtSYS_InstituteUser_Userid_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSYS_InstituteUser sdt )
      {
         if ( sdt.IsDirty("InstituteCode") )
         {
            gxTv_SdtSYS_InstituteUser_Institutecode = sdt.gxTv_SdtSYS_InstituteUser_Institutecode ;
         }
         if ( sdt.IsDirty("UserID") )
         {
            gxTv_SdtSYS_InstituteUser_Userid = sdt.gxTv_SdtSYS_InstituteUser_Userid ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "InstituteCode" )]
      [  XmlElement( ElementName = "InstituteCode"   )]
      public String gxTpr_Institutecode
      {
         get {
            return gxTv_SdtSYS_InstituteUser_Institutecode ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtSYS_InstituteUser_Institutecode, value) != 0 )
            {
               gxTv_SdtSYS_InstituteUser_Mode = "INS";
               this.gxTv_SdtSYS_InstituteUser_Institutecode_Z_SetNull( );
               this.gxTv_SdtSYS_InstituteUser_Userid_Z_SetNull( );
            }
            gxTv_SdtSYS_InstituteUser_Institutecode = value;
            SetDirty("Institutecode");
         }

      }

      [  SoapElement( ElementName = "UserID" )]
      [  XmlElement( ElementName = "UserID"   )]
      public Guid gxTpr_Userid
      {
         get {
            return gxTv_SdtSYS_InstituteUser_Userid ;
         }

         set {
            if ( gxTv_SdtSYS_InstituteUser_Userid != value )
            {
               gxTv_SdtSYS_InstituteUser_Mode = "INS";
               this.gxTv_SdtSYS_InstituteUser_Institutecode_Z_SetNull( );
               this.gxTv_SdtSYS_InstituteUser_Userid_Z_SetNull( );
            }
            gxTv_SdtSYS_InstituteUser_Userid = (Guid)(value);
            SetDirty("Userid");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSYS_InstituteUser_Mode ;
         }

         set {
            gxTv_SdtSYS_InstituteUser_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSYS_InstituteUser_Mode_SetNull( )
      {
         gxTv_SdtSYS_InstituteUser_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_InstituteUser_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSYS_InstituteUser_Initialized ;
         }

         set {
            gxTv_SdtSYS_InstituteUser_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSYS_InstituteUser_Initialized_SetNull( )
      {
         gxTv_SdtSYS_InstituteUser_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_InstituteUser_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "InstituteCode_Z" )]
      [  XmlElement( ElementName = "InstituteCode_Z"   )]
      public String gxTpr_Institutecode_Z
      {
         get {
            return gxTv_SdtSYS_InstituteUser_Institutecode_Z ;
         }

         set {
            gxTv_SdtSYS_InstituteUser_Institutecode_Z = value;
            SetDirty("Institutecode_Z");
         }

      }

      public void gxTv_SdtSYS_InstituteUser_Institutecode_Z_SetNull( )
      {
         gxTv_SdtSYS_InstituteUser_Institutecode_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_InstituteUser_Institutecode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UserID_Z" )]
      [  XmlElement( ElementName = "UserID_Z"   )]
      public Guid gxTpr_Userid_Z
      {
         get {
            return gxTv_SdtSYS_InstituteUser_Userid_Z ;
         }

         set {
            gxTv_SdtSYS_InstituteUser_Userid_Z = (Guid)(value);
            SetDirty("Userid_Z");
         }

      }

      public void gxTv_SdtSYS_InstituteUser_Userid_Z_SetNull( )
      {
         gxTv_SdtSYS_InstituteUser_Userid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_InstituteUser_Userid_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSYS_InstituteUser_Institutecode = "";
         gxTv_SdtSYS_InstituteUser_Userid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_InstituteUser_Mode = "";
         gxTv_SdtSYS_InstituteUser_Institutecode_Z = "";
         gxTv_SdtSYS_InstituteUser_Userid_Z = (Guid)(Guid.Empty);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "sys_instituteuser", "GeneXus.Programs.sys_instituteuser_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSYS_InstituteUser_Initialized ;
      private String gxTv_SdtSYS_InstituteUser_Mode ;
      private String gxTv_SdtSYS_InstituteUser_Institutecode ;
      private String gxTv_SdtSYS_InstituteUser_Institutecode_Z ;
      private Guid gxTv_SdtSYS_InstituteUser_Userid ;
      private Guid gxTv_SdtSYS_InstituteUser_Userid_Z ;
   }

   [DataContract(Name = @"SYS_InstituteUser", Namespace = "DataAnalysisPlatform")]
   public class SdtSYS_InstituteUser_RESTInterface : GxGenericCollectionItem<SdtSYS_InstituteUser>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_InstituteUser_RESTInterface( ) : base()
      {
      }

      public SdtSYS_InstituteUser_RESTInterface( SdtSYS_InstituteUser psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "InstituteCode" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Institutecode
      {
         get {
            return sdt.gxTpr_Institutecode ;
         }

         set {
            sdt.gxTpr_Institutecode = value;
         }

      }

      [DataMember( Name = "UserID" , Order = 1 )]
      [GxSeudo()]
      public Guid gxTpr_Userid
      {
         get {
            return sdt.gxTpr_Userid ;
         }

         set {
            sdt.gxTpr_Userid = (Guid)(value);
         }

      }

      public SdtSYS_InstituteUser sdt
      {
         get {
            return (SdtSYS_InstituteUser)Sdt ;
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
            sdt = new SdtSYS_InstituteUser() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 2 )]
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
