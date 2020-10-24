/*
               File: Certificado
        Description: Certificado
             Author: GeneXus C# Generator version 16_0_1-129648
       Generated on: 10/17/2020 11:15:56.95
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
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class certificado : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false;
         gxfirstwebparm = GetNextPar( );
         gxfirstwebparm_bkp = gxfirstwebparm;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_14") == 0 )
         {
            A17ExamenId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_14( A17ExamenId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_17") == 0 )
         {
            A22ExamenCarrAsigCarreraId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_17( A22ExamenCarrAsigCarreraId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_18") == 0 )
         {
            A22ExamenCarrAsigCarreraId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
            A24ExamenCarrAsigAsignaturaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_18( A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_16") == 0 )
         {
            A17ExamenId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
            A15EstudianteId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_16( A17ExamenId, A15EstudianteId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_15") == 0 )
         {
            A15EstudianteId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_15( A15EstudianteId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
         {
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp;
         }
         if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7CertificadoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7CertificadoId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCERTIFICADOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7CertificadoId), "ZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_web_controls( ) ;
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_1-129648", 0) ;
            Form.Meta.addItem("description", "Certificado", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtCertificadoId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public certificado( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public certificado( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_CertificadoId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7CertificadoId = aP1_CertificadoId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Certificado", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 ToolbarCellClass", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCertificadoId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCertificadoId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCertificadoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A16CertificadoId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A16CertificadoId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCertificadoId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCertificadoId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCertificadoFecha_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCertificadoFecha_Internalname, "Fecha", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtCertificadoFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtCertificadoFecha_Internalname, context.localUtil.Format(A28CertificadoFecha, "99/99/99"), context.localUtil.Format( A28CertificadoFecha, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCertificadoFecha_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCertificadoFecha_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Certificado.htm");
            GxWebStd.gx_bitmap( context, edtCertificadoFecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtCertificadoFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Certificado.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenId_Internalname, "Examen Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtExamenId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17ExamenId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A17ExamenId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtExamenId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Certificado.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_17_Internalname, sImgUrl, imgprompt_17_Link, "", "", context.GetTheme( ), imgprompt_17_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenFecha_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenFecha_Internalname, "Examen Fecha", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtExamenFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtExamenFecha_Internalname, context.localUtil.Format(A26ExamenFecha, "99/99/99"), context.localUtil.Format( A26ExamenFecha, "99/99/99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenFecha_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtExamenFecha_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Certificado.htm");
            GxWebStd.gx_bitmap( context, edtExamenFecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtExamenFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Certificado.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenCarrAsigCarreraId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenCarrAsigCarreraId_Internalname, "Examen Carr Asig Carrera Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtExamenCarrAsigCarreraId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0, ".", "")), ((edtExamenCarrAsigCarreraId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A22ExamenCarrAsigCarreraId), "ZZZ9")) : context.localUtil.Format( (decimal)(A22ExamenCarrAsigCarreraId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenCarrAsigCarreraId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtExamenCarrAsigCarreraId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenCarrAsigCarreraNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenCarrAsigCarreraNombre_Internalname, "Examen Carr Asig Carrera Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtExamenCarrAsigCarreraNombre_Internalname, StringUtil.RTrim( A23ExamenCarrAsigCarreraNombre), StringUtil.RTrim( context.localUtil.Format( A23ExamenCarrAsigCarreraNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenCarrAsigCarreraNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtExamenCarrAsigCarreraNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenCarrAsigAsignaturaId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenCarrAsigAsignaturaId_Internalname, "Examen Carr Asig Asignatura Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtExamenCarrAsigAsignaturaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0, ".", "")), ((edtExamenCarrAsigAsignaturaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A24ExamenCarrAsigAsignaturaId), "ZZZ9")) : context.localUtil.Format( (decimal)(A24ExamenCarrAsigAsignaturaId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenCarrAsigAsignaturaId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtExamenCarrAsigAsignaturaId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenCarrAsigAsignaturaNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenCarrAsigAsignaturaNombre_Internalname, "Examen Carr Asig Asignatura Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtExamenCarrAsigAsignaturaNombre_Internalname, StringUtil.RTrim( A25ExamenCarrAsigAsignaturaNombre), StringUtil.RTrim( context.localUtil.Format( A25ExamenCarrAsigAsignaturaNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenCarrAsigAsignaturaNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtExamenCarrAsigAsignaturaNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstudianteId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEstudianteId_Internalname, "Estudiante Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEstudianteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A15EstudianteId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A15EstudianteId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEstudianteId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEstudianteId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Certificado.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_15_Internalname, sImgUrl, imgprompt_15_Link, "", "", context.GetTheme( ), imgprompt_15_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstudianteNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEstudianteNombre_Internalname, "Estudiante Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEstudianteNombre_Internalname, StringUtil.RTrim( A18EstudianteNombre), StringUtil.RTrim( context.localUtil.Format( A18EstudianteNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEstudianteNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEstudianteNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenEstudianteNota_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenEstudianteNota_Internalname, "Examen Estudiante Nota", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtExamenEstudianteNota_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ExamenEstudianteNota), 4, 0, ".", "")), ((edtExamenEstudianteNota_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A27ExamenEstudianteNota), "ZZZ9")) : context.localUtil.Format( (decimal)(A27ExamenEstudianteNota), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenEstudianteNota_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtExamenEstudianteNota_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Certificado.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11082 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtCertificadoId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCertificadoId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CERTIFICADOID");
                  AnyError = 1;
                  GX_FocusControl = edtCertificadoId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A16CertificadoId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
               }
               else
               {
                  A16CertificadoId = (short)(context.localUtil.CToN( cgiGet( edtCertificadoId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtCertificadoFecha_Internalname), 1) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Certificado Fecha"}), 1, "CERTIFICADOFECHA");
                  AnyError = 1;
                  GX_FocusControl = edtCertificadoFecha_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A28CertificadoFecha = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28CertificadoFecha", context.localUtil.Format(A28CertificadoFecha, "99/99/99"));
               }
               else
               {
                  A28CertificadoFecha = context.localUtil.CToD( cgiGet( edtCertificadoFecha_Internalname), 1);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28CertificadoFecha", context.localUtil.Format(A28CertificadoFecha, "99/99/99"));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtExamenId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtExamenId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EXAMENID");
                  AnyError = 1;
                  GX_FocusControl = edtExamenId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A17ExamenId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
               }
               else
               {
                  A17ExamenId = (short)(context.localUtil.CToN( cgiGet( edtExamenId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
               }
               A26ExamenFecha = context.localUtil.CToD( cgiGet( edtExamenFecha_Internalname), 1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
               A22ExamenCarrAsigCarreraId = (short)(context.localUtil.CToN( cgiGet( edtExamenCarrAsigCarreraId_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
               A23ExamenCarrAsigCarreraNombre = cgiGet( edtExamenCarrAsigCarreraNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
               A24ExamenCarrAsigAsignaturaId = (short)(context.localUtil.CToN( cgiGet( edtExamenCarrAsigAsignaturaId_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
               A25ExamenCarrAsigAsignaturaNombre = cgiGet( edtExamenCarrAsigAsignaturaNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
               if ( ( ( context.localUtil.CToN( cgiGet( edtEstudianteId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEstudianteId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ESTUDIANTEID");
                  AnyError = 1;
                  GX_FocusControl = edtEstudianteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A15EstudianteId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
               }
               else
               {
                  A15EstudianteId = (short)(context.localUtil.CToN( cgiGet( edtEstudianteId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
               }
               A18EstudianteNombre = cgiGet( edtEstudianteNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18EstudianteNombre", A18EstudianteNombre);
               A27ExamenEstudianteNota = (short)(context.localUtil.CToN( cgiGet( edtExamenEstudianteNota_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ExamenEstudianteNota", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ExamenEstudianteNota), 4, 0)));
               /* Read saved values. */
               Z16CertificadoId = (short)(context.localUtil.CToN( cgiGet( "Z16CertificadoId"), ".", ","));
               Z28CertificadoFecha = context.localUtil.CToD( cgiGet( "Z28CertificadoFecha"), 0);
               Z17ExamenId = (short)(context.localUtil.CToN( cgiGet( "Z17ExamenId"), ".", ","));
               Z15EstudianteId = (short)(context.localUtil.CToN( cgiGet( "Z15EstudianteId"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N17ExamenId = (short)(context.localUtil.CToN( cgiGet( "N17ExamenId"), ".", ","));
               N15EstudianteId = (short)(context.localUtil.CToN( cgiGet( "N15EstudianteId"), ".", ","));
               AV7CertificadoId = (short)(context.localUtil.CToN( cgiGet( "vCERTIFICADOID"), ".", ","));
               AV11Insert_ExamenId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_EXAMENID"), ".", ","));
               AV12Insert_EstudianteId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_ESTUDIANTEID"), ".", ","));
               AV14Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Certificado";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_ExamenId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_EstudianteId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A16CertificadoId != Z16CertificadoId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("certificado:[SecurityCheckFailed value for]"+"Insert_ExamenId:"+context.localUtil.Format( (decimal)(AV11Insert_ExamenId), "ZZZ9"));
                  GXUtil.WriteLog("certificado:[SecurityCheckFailed value for]"+"Insert_EstudianteId:"+context.localUtil.Format( (decimal)(AV12Insert_EstudianteId), "ZZZ9"));
                  GXUtil.WriteLog("certificado:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A16CertificadoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode6 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode6;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound6 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_080( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "CERTIFICADOID");
                        AnyError = 1;
                        GX_FocusControl = edtCertificadoId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName");
            EvtGridId = cgiGet( "_EventGridId");
            EvtRowId = cgiGet( "_EventRowId");
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1);
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11082 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12082 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12082 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll086( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         bttBtn_first_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)), true);
         bttBtn_previous_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)), true);
         bttBtn_next_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)), true);
         bttBtn_last_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)), true);
         bttBtn_select_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes086( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_080( )
      {
         BeforeValidate086( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls086( ) ;
            }
            else
            {
               CheckExtendedTable086( ) ;
               CloseExtendedTableCursors086( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption080( )
      {
      }

      protected void E11082( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV14Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "UniApp");
         AV11Insert_ExamenId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_ExamenId), 4, 0)));
         AV12Insert_EstudianteId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_EstudianteId), 4, 0)));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV14Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV15GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GXV1), 8, 0)));
            while ( AV15GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV13TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV15GXV1));
               if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "ExamenId") == 0 )
               {
                  AV11Insert_ExamenId = (short)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_ExamenId), 4, 0)));
               }
               else if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "EstudianteId") == 0 )
               {
                  AV12Insert_EstudianteId = (short)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_EstudianteId), 4, 0)));
               }
               AV15GXV1 = (int)(AV15GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GXV1), 8, 0)));
            }
         }
      }

      protected void E12082( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwcertificado.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM086( short GX_JID )
      {
         if ( ( GX_JID == 13 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z28CertificadoFecha = T00083_A28CertificadoFecha[0];
               Z17ExamenId = T00083_A17ExamenId[0];
               Z15EstudianteId = T00083_A15EstudianteId[0];
            }
            else
            {
               Z28CertificadoFecha = A28CertificadoFecha;
               Z17ExamenId = A17ExamenId;
               Z15EstudianteId = A15EstudianteId;
            }
         }
         if ( GX_JID == -13 )
         {
            Z16CertificadoId = A16CertificadoId;
            Z28CertificadoFecha = A28CertificadoFecha;
            Z17ExamenId = A17ExamenId;
            Z15EstudianteId = A15EstudianteId;
            Z26ExamenFecha = A26ExamenFecha;
            Z22ExamenCarrAsigCarreraId = A22ExamenCarrAsigCarreraId;
            Z24ExamenCarrAsigAsignaturaId = A24ExamenCarrAsigAsignaturaId;
            Z23ExamenCarrAsigCarreraNombre = A23ExamenCarrAsigCarreraNombre;
            Z25ExamenCarrAsigAsignaturaNombre = A25ExamenCarrAsigAsignaturaNombre;
            Z18EstudianteNombre = A18EstudianteNombre;
            Z27ExamenEstudianteNota = A27ExamenEstudianteNota;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_17_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0070.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EXAMENID"+"'), id:'"+"EXAMENID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_15_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0091.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EXAMENID"+"'), id:'"+"EXAMENID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"ESTUDIANTEID"+"'), id:'"+"ESTUDIANTEID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7CertificadoId) )
         {
            A16CertificadoId = AV7CertificadoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
         }
         if ( ! (0==AV7CertificadoId) )
         {
            edtCertificadoId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCertificadoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCertificadoId_Enabled), 5, 0)), true);
         }
         else
         {
            edtCertificadoId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCertificadoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCertificadoId_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7CertificadoId) )
         {
            edtCertificadoId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCertificadoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCertificadoId_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_ExamenId) )
         {
            edtExamenId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenId_Enabled), 5, 0)), true);
         }
         else
         {
            edtExamenId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenId_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_EstudianteId) )
         {
            edtEstudianteId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteId_Enabled), 5, 0)), true);
         }
         else
         {
            edtEstudianteId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_EstudianteId) )
         {
            A15EstudianteId = AV12Insert_EstudianteId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_ExamenId) )
         {
            A17ExamenId = AV11Insert_ExamenId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV14Pgmname = "Certificado";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T00085 */
            pr_default.execute(3, new Object[] {A15EstudianteId});
            A18EstudianteNombre = T00085_A18EstudianteNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18EstudianteNombre", A18EstudianteNombre);
            pr_default.close(3);
            /* Using cursor T00084 */
            pr_default.execute(2, new Object[] {A17ExamenId});
            A26ExamenFecha = T00084_A26ExamenFecha[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
            A22ExamenCarrAsigCarreraId = T00084_A22ExamenCarrAsigCarreraId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
            A24ExamenCarrAsigAsignaturaId = T00084_A24ExamenCarrAsigAsignaturaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
            pr_default.close(2);
            /* Using cursor T00087 */
            pr_default.execute(5, new Object[] {A22ExamenCarrAsigCarreraId});
            A23ExamenCarrAsigCarreraNombre = T00087_A23ExamenCarrAsigCarreraNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
            pr_default.close(5);
            /* Using cursor T00088 */
            pr_default.execute(6, new Object[] {A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId});
            A25ExamenCarrAsigAsignaturaNombre = T00088_A25ExamenCarrAsigAsignaturaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
            pr_default.close(6);
            /* Using cursor T00086 */
            pr_default.execute(4, new Object[] {A17ExamenId, A15EstudianteId});
            A27ExamenEstudianteNota = T00086_A27ExamenEstudianteNota[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ExamenEstudianteNota", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ExamenEstudianteNota), 4, 0)));
            pr_default.close(4);
         }
      }

      protected void Load086( )
      {
         /* Using cursor T00089 */
         pr_default.execute(7, new Object[] {A16CertificadoId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound6 = 1;
            A28CertificadoFecha = T00089_A28CertificadoFecha[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28CertificadoFecha", context.localUtil.Format(A28CertificadoFecha, "99/99/99"));
            A26ExamenFecha = T00089_A26ExamenFecha[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
            A23ExamenCarrAsigCarreraNombre = T00089_A23ExamenCarrAsigCarreraNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
            A18EstudianteNombre = T00089_A18EstudianteNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18EstudianteNombre", A18EstudianteNombre);
            A27ExamenEstudianteNota = T00089_A27ExamenEstudianteNota[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ExamenEstudianteNota", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ExamenEstudianteNota), 4, 0)));
            A17ExamenId = T00089_A17ExamenId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
            A15EstudianteId = T00089_A15EstudianteId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
            A22ExamenCarrAsigCarreraId = T00089_A22ExamenCarrAsigCarreraId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
            A24ExamenCarrAsigAsignaturaId = T00089_A24ExamenCarrAsigAsignaturaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
            A25ExamenCarrAsigAsignaturaNombre = T00089_A25ExamenCarrAsigAsignaturaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
            ZM086( -13) ;
         }
         pr_default.close(7);
         OnLoadActions086( ) ;
      }

      protected void OnLoadActions086( )
      {
         AV14Pgmname = "Certificado";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
      }

      protected void CheckExtendedTable086( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV14Pgmname = "Certificado";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         if ( ! ( (DateTime.MinValue==A28CertificadoFecha) || ( A28CertificadoFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field Certificado Fecha is out of range", "OutOfRange", 1, "CERTIFICADOFECHA");
            AnyError = 1;
            GX_FocusControl = edtCertificadoFecha_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00084 */
         pr_default.execute(2, new Object[] {A17ExamenId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen'.", "ForeignKeyNotFound", 1, "EXAMENID");
            AnyError = 1;
            GX_FocusControl = edtExamenId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A26ExamenFecha = T00084_A26ExamenFecha[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
         A22ExamenCarrAsigCarreraId = T00084_A22ExamenCarrAsigCarreraId[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
         A24ExamenCarrAsigAsignaturaId = T00084_A24ExamenCarrAsigAsignaturaId[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
         pr_default.close(2);
         /* Using cursor T00087 */
         pr_default.execute(5, new Object[] {A22ExamenCarrAsigCarreraId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen Carr Asig'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A23ExamenCarrAsigCarreraNombre = T00087_A23ExamenCarrAsigCarreraNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
         pr_default.close(5);
         /* Using cursor T00088 */
         pr_default.execute(6, new Object[] {A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen Carr Asig'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A25ExamenCarrAsigAsignaturaNombre = T00088_A25ExamenCarrAsigAsignaturaNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
         pr_default.close(6);
         /* Using cursor T00086 */
         pr_default.execute(4, new Object[] {A17ExamenId, A15EstudianteId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Estudiiante'.", "ForeignKeyNotFound", 1, "EXAMENID");
            AnyError = 1;
            GX_FocusControl = edtExamenId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A27ExamenEstudianteNota = T00086_A27ExamenEstudianteNota[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ExamenEstudianteNota", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ExamenEstudianteNota), 4, 0)));
         pr_default.close(4);
         /* Using cursor T00085 */
         pr_default.execute(3, new Object[] {A15EstudianteId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No matching 'Estudiante'.", "ForeignKeyNotFound", 1, "ESTUDIANTEID");
            AnyError = 1;
            GX_FocusControl = edtEstudianteId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A18EstudianteNombre = T00085_A18EstudianteNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18EstudianteNombre", A18EstudianteNombre);
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors086( )
      {
         pr_default.close(2);
         pr_default.close(5);
         pr_default.close(6);
         pr_default.close(4);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_14( short A17ExamenId )
      {
         /* Using cursor T000810 */
         pr_default.execute(8, new Object[] {A17ExamenId});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen'.", "ForeignKeyNotFound", 1, "EXAMENID");
            AnyError = 1;
            GX_FocusControl = edtExamenId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A26ExamenFecha = T000810_A26ExamenFecha[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
         A22ExamenCarrAsigCarreraId = T000810_A22ExamenCarrAsigCarreraId[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
         A24ExamenCarrAsigAsignaturaId = T000810_A24ExamenCarrAsigAsignaturaId[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( context.localUtil.Format(A26ExamenFecha, "99/99/99"))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(8);
      }

      protected void gxLoad_17( short A22ExamenCarrAsigCarreraId )
      {
         /* Using cursor T000811 */
         pr_default.execute(9, new Object[] {A22ExamenCarrAsigCarreraId});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen Carr Asig'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A23ExamenCarrAsigCarreraNombre = T000811_A23ExamenCarrAsigCarreraNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A23ExamenCarrAsigCarreraNombre))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(9) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(9);
      }

      protected void gxLoad_18( short A22ExamenCarrAsigCarreraId ,
                                short A24ExamenCarrAsigAsignaturaId )
      {
         /* Using cursor T000812 */
         pr_default.execute(10, new Object[] {A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen Carr Asig'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A25ExamenCarrAsigAsignaturaNombre = T000812_A25ExamenCarrAsigAsignaturaNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A25ExamenCarrAsigAsignaturaNombre))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(10);
      }

      protected void gxLoad_16( short A17ExamenId ,
                                short A15EstudianteId )
      {
         /* Using cursor T000813 */
         pr_default.execute(11, new Object[] {A17ExamenId, A15EstudianteId});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No matching 'Estudiiante'.", "ForeignKeyNotFound", 1, "EXAMENID");
            AnyError = 1;
            GX_FocusControl = edtExamenId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A27ExamenEstudianteNota = T000813_A27ExamenEstudianteNota[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ExamenEstudianteNota", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ExamenEstudianteNota), 4, 0)));
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ExamenEstudianteNota), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(11) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(11);
      }

      protected void gxLoad_15( short A15EstudianteId )
      {
         /* Using cursor T000814 */
         pr_default.execute(12, new Object[] {A15EstudianteId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No matching 'Estudiante'.", "ForeignKeyNotFound", 1, "ESTUDIANTEID");
            AnyError = 1;
            GX_FocusControl = edtEstudianteId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A18EstudianteNombre = T000814_A18EstudianteNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18EstudianteNombre", A18EstudianteNombre);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A18EstudianteNombre))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(12) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(12);
      }

      protected void GetKey086( )
      {
         /* Using cursor T000815 */
         pr_default.execute(13, new Object[] {A16CertificadoId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(13);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00083 */
         pr_default.execute(1, new Object[] {A16CertificadoId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM086( 13) ;
            RcdFound6 = 1;
            A16CertificadoId = T00083_A16CertificadoId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
            A28CertificadoFecha = T00083_A28CertificadoFecha[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28CertificadoFecha", context.localUtil.Format(A28CertificadoFecha, "99/99/99"));
            A17ExamenId = T00083_A17ExamenId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
            A15EstudianteId = T00083_A15EstudianteId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
            Z16CertificadoId = A16CertificadoId;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load086( ) ;
            if ( AnyError == 1 )
            {
               RcdFound6 = 0;
               InitializeNonKey086( ) ;
            }
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey086( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey086( ) ;
         if ( RcdFound6 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound6 = 0;
         /* Using cursor T000816 */
         pr_default.execute(14, new Object[] {A16CertificadoId});
         if ( (pr_default.getStatus(14) != 101) )
         {
            while ( (pr_default.getStatus(14) != 101) && ( ( T000816_A16CertificadoId[0] < A16CertificadoId ) ) )
            {
               pr_default.readNext(14);
            }
            if ( (pr_default.getStatus(14) != 101) && ( ( T000816_A16CertificadoId[0] > A16CertificadoId ) ) )
            {
               A16CertificadoId = T000816_A16CertificadoId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
               RcdFound6 = 1;
            }
         }
         pr_default.close(14);
      }

      protected void move_previous( )
      {
         RcdFound6 = 0;
         /* Using cursor T000817 */
         pr_default.execute(15, new Object[] {A16CertificadoId});
         if ( (pr_default.getStatus(15) != 101) )
         {
            while ( (pr_default.getStatus(15) != 101) && ( ( T000817_A16CertificadoId[0] > A16CertificadoId ) ) )
            {
               pr_default.readNext(15);
            }
            if ( (pr_default.getStatus(15) != 101) && ( ( T000817_A16CertificadoId[0] < A16CertificadoId ) ) )
            {
               A16CertificadoId = T000817_A16CertificadoId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
               RcdFound6 = 1;
            }
         }
         pr_default.close(15);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey086( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtCertificadoId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert086( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound6 == 1 )
            {
               if ( A16CertificadoId != Z16CertificadoId )
               {
                  A16CertificadoId = Z16CertificadoId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "CERTIFICADOID");
                  AnyError = 1;
                  GX_FocusControl = edtCertificadoId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtCertificadoId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update086( ) ;
                  GX_FocusControl = edtCertificadoId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A16CertificadoId != Z16CertificadoId )
               {
                  /* Insert record */
                  GX_FocusControl = edtCertificadoId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert086( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "CERTIFICADOID");
                     AnyError = 1;
                     GX_FocusControl = edtCertificadoId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtCertificadoId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert086( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A16CertificadoId != Z16CertificadoId )
         {
            A16CertificadoId = Z16CertificadoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "CERTIFICADOID");
            AnyError = 1;
            GX_FocusControl = edtCertificadoId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtCertificadoId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency086( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00082 */
            pr_default.execute(0, new Object[] {A16CertificadoId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Certificado"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z28CertificadoFecha != T00082_A28CertificadoFecha[0] ) || ( Z17ExamenId != T00082_A17ExamenId[0] ) || ( Z15EstudianteId != T00082_A15EstudianteId[0] ) )
            {
               if ( Z28CertificadoFecha != T00082_A28CertificadoFecha[0] )
               {
                  GXUtil.WriteLog("certificado:[seudo value changed for attri]"+"CertificadoFecha");
                  GXUtil.WriteLogRaw("Old: ",Z28CertificadoFecha);
                  GXUtil.WriteLogRaw("Current: ",T00082_A28CertificadoFecha[0]);
               }
               if ( Z17ExamenId != T00082_A17ExamenId[0] )
               {
                  GXUtil.WriteLog("certificado:[seudo value changed for attri]"+"ExamenId");
                  GXUtil.WriteLogRaw("Old: ",Z17ExamenId);
                  GXUtil.WriteLogRaw("Current: ",T00082_A17ExamenId[0]);
               }
               if ( Z15EstudianteId != T00082_A15EstudianteId[0] )
               {
                  GXUtil.WriteLog("certificado:[seudo value changed for attri]"+"EstudianteId");
                  GXUtil.WriteLogRaw("Old: ",Z15EstudianteId);
                  GXUtil.WriteLogRaw("Current: ",T00082_A15EstudianteId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Certificado"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert086( )
      {
         BeforeValidate086( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable086( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM086( 0) ;
            CheckOptimisticConcurrency086( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm086( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert086( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000818 */
                     pr_default.execute(16, new Object[] {A16CertificadoId, A28CertificadoFecha, A17ExamenId, A15EstudianteId});
                     pr_default.close(16);
                     dsDefault.SmartCacheProvider.SetUpdated("Certificado") ;
                     if ( (pr_default.getStatus(16) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption080( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load086( ) ;
            }
            EndLevel086( ) ;
         }
         CloseExtendedTableCursors086( ) ;
      }

      protected void Update086( )
      {
         BeforeValidate086( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable086( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency086( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm086( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate086( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000819 */
                     pr_default.execute(17, new Object[] {A28CertificadoFecha, A17ExamenId, A15EstudianteId, A16CertificadoId});
                     pr_default.close(17);
                     dsDefault.SmartCacheProvider.SetUpdated("Certificado") ;
                     if ( (pr_default.getStatus(17) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Certificado"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate086( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel086( ) ;
         }
         CloseExtendedTableCursors086( ) ;
      }

      protected void DeferredUpdate086( )
      {
      }

      protected void delete( )
      {
         BeforeValidate086( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency086( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls086( ) ;
            AfterConfirm086( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete086( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000820 */
                  pr_default.execute(18, new Object[] {A16CertificadoId});
                  pr_default.close(18);
                  dsDefault.SmartCacheProvider.SetUpdated("Certificado") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel086( ) ;
         Gx_mode = sMode6;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls086( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV14Pgmname = "Certificado";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T000821 */
            pr_default.execute(19, new Object[] {A17ExamenId});
            A26ExamenFecha = T000821_A26ExamenFecha[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
            A22ExamenCarrAsigCarreraId = T000821_A22ExamenCarrAsigCarreraId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
            A24ExamenCarrAsigAsignaturaId = T000821_A24ExamenCarrAsigAsignaturaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
            pr_default.close(19);
            /* Using cursor T000822 */
            pr_default.execute(20, new Object[] {A22ExamenCarrAsigCarreraId});
            A23ExamenCarrAsigCarreraNombre = T000822_A23ExamenCarrAsigCarreraNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
            pr_default.close(20);
            /* Using cursor T000823 */
            pr_default.execute(21, new Object[] {A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId});
            A25ExamenCarrAsigAsignaturaNombre = T000823_A25ExamenCarrAsigAsignaturaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
            pr_default.close(21);
            /* Using cursor T000824 */
            pr_default.execute(22, new Object[] {A15EstudianteId});
            A18EstudianteNombre = T000824_A18EstudianteNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18EstudianteNombre", A18EstudianteNombre);
            pr_default.close(22);
            /* Using cursor T000825 */
            pr_default.execute(23, new Object[] {A17ExamenId, A15EstudianteId});
            A27ExamenEstudianteNota = T000825_A27ExamenEstudianteNota[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ExamenEstudianteNota", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ExamenEstudianteNota), 4, 0)));
            pr_default.close(23);
         }
      }

      protected void EndLevel086( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete086( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(19);
            pr_default.close(22);
            pr_default.close(23);
            pr_default.close(20);
            pr_default.close(21);
            context.CommitDataStores("certificado",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues080( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(19);
            pr_default.close(22);
            pr_default.close(23);
            pr_default.close(20);
            pr_default.close(21);
            context.RollbackDataStores("certificado",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart086( )
      {
         /* Scan By routine */
         /* Using cursor T000826 */
         pr_default.execute(24);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound6 = 1;
            A16CertificadoId = T000826_A16CertificadoId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext086( )
      {
         /* Scan next routine */
         pr_default.readNext(24);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound6 = 1;
            A16CertificadoId = T000826_A16CertificadoId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
         }
      }

      protected void ScanEnd086( )
      {
         pr_default.close(24);
      }

      protected void AfterConfirm086( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert086( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate086( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete086( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete086( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate086( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes086( )
      {
         edtCertificadoId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCertificadoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCertificadoId_Enabled), 5, 0)), true);
         edtCertificadoFecha_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCertificadoFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCertificadoFecha_Enabled), 5, 0)), true);
         edtExamenId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenId_Enabled), 5, 0)), true);
         edtExamenFecha_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenFecha_Enabled), 5, 0)), true);
         edtExamenCarrAsigCarreraId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenCarrAsigCarreraId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenCarrAsigCarreraId_Enabled), 5, 0)), true);
         edtExamenCarrAsigCarreraNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenCarrAsigCarreraNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenCarrAsigCarreraNombre_Enabled), 5, 0)), true);
         edtExamenCarrAsigAsignaturaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenCarrAsigAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenCarrAsigAsignaturaId_Enabled), 5, 0)), true);
         edtExamenCarrAsigAsignaturaNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenCarrAsigAsignaturaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenCarrAsigAsignaturaNombre_Enabled), 5, 0)), true);
         edtEstudianteId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteId_Enabled), 5, 0)), true);
         edtEstudianteNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteNombre_Enabled), 5, 0)), true);
         edtExamenEstudianteNota_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenEstudianteNota_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenEstudianteNota_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes086( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues080( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 129648), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("gxcfg.js", "?2020101711155966", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("certificado.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7CertificadoId)+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "Certificado";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_ExamenId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_EstudianteId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("certificado:[SendSecurityCheck value for]"+"Insert_ExamenId:"+context.localUtil.Format( (decimal)(AV11Insert_ExamenId), "ZZZ9"));
         GXUtil.WriteLog("certificado:[SendSecurityCheck value for]"+"Insert_EstudianteId:"+context.localUtil.Format( (decimal)(AV12Insert_EstudianteId), "ZZZ9"));
         GXUtil.WriteLog("certificado:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z16CertificadoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16CertificadoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z28CertificadoFecha", context.localUtil.DToC( Z28CertificadoFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z17ExamenId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17ExamenId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z15EstudianteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15EstudianteId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N17ExamenId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17ExamenId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N15EstudianteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A15EstudianteId), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vCERTIFICADOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7CertificadoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vCERTIFICADOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7CertificadoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_EXAMENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_ExamenId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_ESTUDIANTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12Insert_EstudianteId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV14Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("certificado.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7CertificadoId) ;
      }

      public override String GetPgmname( )
      {
         return "Certificado" ;
      }

      public override String GetPgmdesc( )
      {
         return "Certificado" ;
      }

      protected void InitializeNonKey086( )
      {
         A17ExamenId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
         A15EstudianteId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
         A28CertificadoFecha = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28CertificadoFecha", context.localUtil.Format(A28CertificadoFecha, "99/99/99"));
         A26ExamenFecha = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
         A22ExamenCarrAsigCarreraId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
         A23ExamenCarrAsigCarreraNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
         A24ExamenCarrAsigAsignaturaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
         A25ExamenCarrAsigAsignaturaNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
         A18EstudianteNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18EstudianteNombre", A18EstudianteNombre);
         A27ExamenEstudianteNota = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ExamenEstudianteNota", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ExamenEstudianteNota), 4, 0)));
         Z28CertificadoFecha = DateTime.MinValue;
         Z17ExamenId = 0;
         Z15EstudianteId = 0;
      }

      protected void InitAll086( )
      {
         A16CertificadoId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
         InitializeNonKey086( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020101711155978", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("certificado.js", "?2020101711155979", false, true);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtCertificadoId_Internalname = "CERTIFICADOID";
         edtCertificadoFecha_Internalname = "CERTIFICADOFECHA";
         edtExamenId_Internalname = "EXAMENID";
         edtExamenFecha_Internalname = "EXAMENFECHA";
         edtExamenCarrAsigCarreraId_Internalname = "EXAMENCARRASIGCARRERAID";
         edtExamenCarrAsigCarreraNombre_Internalname = "EXAMENCARRASIGCARRERANOMBRE";
         edtExamenCarrAsigAsignaturaId_Internalname = "EXAMENCARRASIGASIGNATURAID";
         edtExamenCarrAsigAsignaturaNombre_Internalname = "EXAMENCARRASIGASIGNATURANOMBRE";
         edtEstudianteId_Internalname = "ESTUDIANTEID";
         edtEstudianteNombre_Internalname = "ESTUDIANTENOMBRE";
         edtExamenEstudianteNota_Internalname = "EXAMENESTUDIANTENOTA";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_17_Internalname = "PROMPT_17";
         imgprompt_15_Internalname = "PROMPT_15";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Certificado";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtExamenEstudianteNota_Jsonclick = "";
         edtExamenEstudianteNota_Enabled = 0;
         edtEstudianteNombre_Jsonclick = "";
         edtEstudianteNombre_Enabled = 0;
         imgprompt_15_Visible = 1;
         imgprompt_15_Link = "";
         edtEstudianteId_Jsonclick = "";
         edtEstudianteId_Enabled = 1;
         edtExamenCarrAsigAsignaturaNombre_Jsonclick = "";
         edtExamenCarrAsigAsignaturaNombre_Enabled = 0;
         edtExamenCarrAsigAsignaturaId_Jsonclick = "";
         edtExamenCarrAsigAsignaturaId_Enabled = 0;
         edtExamenCarrAsigCarreraNombre_Jsonclick = "";
         edtExamenCarrAsigCarreraNombre_Enabled = 0;
         edtExamenCarrAsigCarreraId_Jsonclick = "";
         edtExamenCarrAsigCarreraId_Enabled = 0;
         edtExamenFecha_Jsonclick = "";
         edtExamenFecha_Enabled = 0;
         imgprompt_17_Visible = 1;
         imgprompt_17_Link = "";
         edtExamenId_Jsonclick = "";
         edtExamenId_Enabled = 1;
         edtCertificadoFecha_Jsonclick = "";
         edtCertificadoFecha_Enabled = 1;
         edtCertificadoId_Jsonclick = "";
         edtCertificadoId_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public void Valid_Examenid( short GX_Parm1 ,
                                  short GX_Parm2 ,
                                  short GX_Parm3 ,
                                  DateTime GX_Parm4 ,
                                  String GX_Parm5 ,
                                  String GX_Parm6 )
      {
         A17ExamenId = GX_Parm1;
         A22ExamenCarrAsigCarreraId = GX_Parm2;
         A24ExamenCarrAsigAsignaturaId = GX_Parm3;
         A26ExamenFecha = GX_Parm4;
         A23ExamenCarrAsigCarreraNombre = GX_Parm5;
         A25ExamenCarrAsigAsignaturaNombre = GX_Parm6;
         /* Using cursor T000821 */
         pr_default.execute(19, new Object[] {A17ExamenId});
         if ( (pr_default.getStatus(19) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen'.", "ForeignKeyNotFound", 1, "EXAMENID");
            AnyError = 1;
            GX_FocusControl = edtExamenId_Internalname;
         }
         A26ExamenFecha = T000821_A26ExamenFecha[0];
         A22ExamenCarrAsigCarreraId = T000821_A22ExamenCarrAsigCarreraId[0];
         A24ExamenCarrAsigAsignaturaId = T000821_A24ExamenCarrAsigAsignaturaId[0];
         pr_default.close(19);
         /* Using cursor T000822 */
         pr_default.execute(20, new Object[] {A22ExamenCarrAsigCarreraId});
         if ( (pr_default.getStatus(20) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen Carr Asig'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A23ExamenCarrAsigCarreraNombre = T000822_A23ExamenCarrAsigCarreraNombre[0];
         pr_default.close(20);
         /* Using cursor T000823 */
         pr_default.execute(21, new Object[] {A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId});
         if ( (pr_default.getStatus(21) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen Carr Asig'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A25ExamenCarrAsigAsignaturaNombre = T000823_A25ExamenCarrAsigAsignaturaNombre[0];
         pr_default.close(21);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A26ExamenFecha = DateTime.MinValue;
            A22ExamenCarrAsigCarreraId = 0;
            A24ExamenCarrAsigAsignaturaId = 0;
            A23ExamenCarrAsigCarreraNombre = "";
            A25ExamenCarrAsigAsignaturaNombre = "";
         }
         isValidOutput.Add(context.localUtil.Format(A26ExamenFecha, "99/99/99"));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( A23ExamenCarrAsigCarreraNombre));
         isValidOutput.Add(StringUtil.RTrim( A25ExamenCarrAsigAsignaturaNombre));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Estudianteid( short GX_Parm1 ,
                                      short GX_Parm2 ,
                                      String GX_Parm3 ,
                                      short GX_Parm4 )
      {
         A15EstudianteId = GX_Parm1;
         A17ExamenId = GX_Parm2;
         A18EstudianteNombre = GX_Parm3;
         A27ExamenEstudianteNota = GX_Parm4;
         /* Using cursor T000824 */
         pr_default.execute(22, new Object[] {A15EstudianteId});
         if ( (pr_default.getStatus(22) == 101) )
         {
            GX_msglist.addItem("No matching 'Estudiante'.", "ForeignKeyNotFound", 1, "ESTUDIANTEID");
            AnyError = 1;
            GX_FocusControl = edtEstudianteId_Internalname;
         }
         A18EstudianteNombre = T000824_A18EstudianteNombre[0];
         pr_default.close(22);
         /* Using cursor T000825 */
         pr_default.execute(23, new Object[] {A17ExamenId, A15EstudianteId});
         if ( (pr_default.getStatus(23) == 101) )
         {
            GX_msglist.addItem("No matching 'Estudiiante'.", "ForeignKeyNotFound", 1, "EXAMENID");
            AnyError = 1;
            GX_FocusControl = edtExamenId_Internalname;
         }
         A27ExamenEstudianteNota = T000825_A27ExamenEstudianteNota[0];
         pr_default.close(23);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A18EstudianteNombre = "";
            A27ExamenEstudianteNota = 0;
         }
         isValidOutput.Add(StringUtil.RTrim( A18EstudianteNombre));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ExamenEstudianteNota), 4, 0, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7CertificadoId',fld:'vCERTIFICADOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7CertificadoId',fld:'vCERTIFICADOID',pic:'ZZZ9',hsh:true},{av:'AV11Insert_ExamenId',fld:'vINSERT_EXAMENID',pic:'ZZZ9'},{av:'AV12Insert_EstudianteId',fld:'vINSERT_ESTUDIANTEID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12082',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(19);
         pr_default.close(23);
         pr_default.close(22);
         pr_default.close(21);
         pr_default.close(20);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z28CertificadoFecha = DateTime.MinValue;
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A28CertificadoFecha = DateTime.MinValue;
         sImgUrl = "";
         A26ExamenFecha = DateTime.MinValue;
         A23ExamenCarrAsigCarreraNombre = "";
         A25ExamenCarrAsigAsignaturaNombre = "";
         A18EstudianteNombre = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV14Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode6 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV13TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z26ExamenFecha = DateTime.MinValue;
         Z23ExamenCarrAsigCarreraNombre = "";
         Z25ExamenCarrAsigAsignaturaNombre = "";
         Z18EstudianteNombre = "";
         T00085_A18EstudianteNombre = new String[] {""} ;
         T00084_A26ExamenFecha = new DateTime[] {DateTime.MinValue} ;
         T00084_A22ExamenCarrAsigCarreraId = new short[1] ;
         T00084_A24ExamenCarrAsigAsignaturaId = new short[1] ;
         T00087_A23ExamenCarrAsigCarreraNombre = new String[] {""} ;
         T00088_A25ExamenCarrAsigAsignaturaNombre = new String[] {""} ;
         T00086_A27ExamenEstudianteNota = new short[1] ;
         T00089_A16CertificadoId = new short[1] ;
         T00089_A28CertificadoFecha = new DateTime[] {DateTime.MinValue} ;
         T00089_A26ExamenFecha = new DateTime[] {DateTime.MinValue} ;
         T00089_A23ExamenCarrAsigCarreraNombre = new String[] {""} ;
         T00089_A18EstudianteNombre = new String[] {""} ;
         T00089_A27ExamenEstudianteNota = new short[1] ;
         T00089_A17ExamenId = new short[1] ;
         T00089_A15EstudianteId = new short[1] ;
         T00089_A22ExamenCarrAsigCarreraId = new short[1] ;
         T00089_A24ExamenCarrAsigAsignaturaId = new short[1] ;
         T00089_A25ExamenCarrAsigAsignaturaNombre = new String[] {""} ;
         T000810_A26ExamenFecha = new DateTime[] {DateTime.MinValue} ;
         T000810_A22ExamenCarrAsigCarreraId = new short[1] ;
         T000810_A24ExamenCarrAsigAsignaturaId = new short[1] ;
         T000811_A23ExamenCarrAsigCarreraNombre = new String[] {""} ;
         T000812_A25ExamenCarrAsigAsignaturaNombre = new String[] {""} ;
         T000813_A27ExamenEstudianteNota = new short[1] ;
         T000814_A18EstudianteNombre = new String[] {""} ;
         T000815_A16CertificadoId = new short[1] ;
         T00083_A16CertificadoId = new short[1] ;
         T00083_A28CertificadoFecha = new DateTime[] {DateTime.MinValue} ;
         T00083_A17ExamenId = new short[1] ;
         T00083_A15EstudianteId = new short[1] ;
         T000816_A16CertificadoId = new short[1] ;
         T000817_A16CertificadoId = new short[1] ;
         T00082_A16CertificadoId = new short[1] ;
         T00082_A28CertificadoFecha = new DateTime[] {DateTime.MinValue} ;
         T00082_A17ExamenId = new short[1] ;
         T00082_A15EstudianteId = new short[1] ;
         T000821_A26ExamenFecha = new DateTime[] {DateTime.MinValue} ;
         T000821_A22ExamenCarrAsigCarreraId = new short[1] ;
         T000821_A24ExamenCarrAsigAsignaturaId = new short[1] ;
         T000822_A23ExamenCarrAsigCarreraNombre = new String[] {""} ;
         T000823_A25ExamenCarrAsigAsignaturaNombre = new String[] {""} ;
         T000824_A18EstudianteNombre = new String[] {""} ;
         T000825_A27ExamenEstudianteNota = new short[1] ;
         T000826_A16CertificadoId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.certificado__default(),
            new Object[][] {
                new Object[] {
               T00082_A16CertificadoId, T00082_A28CertificadoFecha, T00082_A17ExamenId, T00082_A15EstudianteId
               }
               , new Object[] {
               T00083_A16CertificadoId, T00083_A28CertificadoFecha, T00083_A17ExamenId, T00083_A15EstudianteId
               }
               , new Object[] {
               T00084_A26ExamenFecha, T00084_A22ExamenCarrAsigCarreraId, T00084_A24ExamenCarrAsigAsignaturaId
               }
               , new Object[] {
               T00085_A18EstudianteNombre
               }
               , new Object[] {
               T00086_A27ExamenEstudianteNota
               }
               , new Object[] {
               T00087_A23ExamenCarrAsigCarreraNombre
               }
               , new Object[] {
               T00088_A25ExamenCarrAsigAsignaturaNombre
               }
               , new Object[] {
               T00089_A16CertificadoId, T00089_A28CertificadoFecha, T00089_A26ExamenFecha, T00089_A23ExamenCarrAsigCarreraNombre, T00089_A18EstudianteNombre, T00089_A27ExamenEstudianteNota, T00089_A17ExamenId, T00089_A15EstudianteId, T00089_A22ExamenCarrAsigCarreraId, T00089_A24ExamenCarrAsigAsignaturaId,
               T00089_A25ExamenCarrAsigAsignaturaNombre
               }
               , new Object[] {
               T000810_A26ExamenFecha, T000810_A22ExamenCarrAsigCarreraId, T000810_A24ExamenCarrAsigAsignaturaId
               }
               , new Object[] {
               T000811_A23ExamenCarrAsigCarreraNombre
               }
               , new Object[] {
               T000812_A25ExamenCarrAsigAsignaturaNombre
               }
               , new Object[] {
               T000813_A27ExamenEstudianteNota
               }
               , new Object[] {
               T000814_A18EstudianteNombre
               }
               , new Object[] {
               T000815_A16CertificadoId
               }
               , new Object[] {
               T000816_A16CertificadoId
               }
               , new Object[] {
               T000817_A16CertificadoId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000821_A26ExamenFecha, T000821_A22ExamenCarrAsigCarreraId, T000821_A24ExamenCarrAsigAsignaturaId
               }
               , new Object[] {
               T000822_A23ExamenCarrAsigCarreraNombre
               }
               , new Object[] {
               T000823_A25ExamenCarrAsigAsignaturaNombre
               }
               , new Object[] {
               T000824_A18EstudianteNombre
               }
               , new Object[] {
               T000825_A27ExamenEstudianteNota
               }
               , new Object[] {
               T000826_A16CertificadoId
               }
            }
         );
         AV14Pgmname = "Certificado";
      }

      private short wcpOAV7CertificadoId ;
      private short Z16CertificadoId ;
      private short Z17ExamenId ;
      private short Z15EstudianteId ;
      private short N17ExamenId ;
      private short N15EstudianteId ;
      private short GxWebError ;
      private short A17ExamenId ;
      private short A22ExamenCarrAsigCarreraId ;
      private short A24ExamenCarrAsigAsignaturaId ;
      private short A15EstudianteId ;
      private short AV7CertificadoId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A16CertificadoId ;
      private short A27ExamenEstudianteNota ;
      private short AV11Insert_ExamenId ;
      private short AV12Insert_EstudianteId ;
      private short RcdFound6 ;
      private short GX_JID ;
      private short Z22ExamenCarrAsigCarreraId ;
      private short Z24ExamenCarrAsigAsignaturaId ;
      private short Z27ExamenEstudianteNota ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtCertificadoId_Enabled ;
      private int edtCertificadoFecha_Enabled ;
      private int edtExamenId_Enabled ;
      private int imgprompt_17_Visible ;
      private int edtExamenFecha_Enabled ;
      private int edtExamenCarrAsigCarreraId_Enabled ;
      private int edtExamenCarrAsigCarreraNombre_Enabled ;
      private int edtExamenCarrAsigAsignaturaId_Enabled ;
      private int edtExamenCarrAsigAsignaturaNombre_Enabled ;
      private int edtEstudianteId_Enabled ;
      private int imgprompt_15_Visible ;
      private int edtEstudianteNombre_Enabled ;
      private int edtExamenEstudianteNota_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV15GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtCertificadoId_Internalname ;
      private String divMaintable_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String edtCertificadoId_Jsonclick ;
      private String edtCertificadoFecha_Internalname ;
      private String edtCertificadoFecha_Jsonclick ;
      private String edtExamenId_Internalname ;
      private String edtExamenId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_17_Internalname ;
      private String imgprompt_17_Link ;
      private String edtExamenFecha_Internalname ;
      private String edtExamenFecha_Jsonclick ;
      private String edtExamenCarrAsigCarreraId_Internalname ;
      private String edtExamenCarrAsigCarreraId_Jsonclick ;
      private String edtExamenCarrAsigCarreraNombre_Internalname ;
      private String A23ExamenCarrAsigCarreraNombre ;
      private String edtExamenCarrAsigCarreraNombre_Jsonclick ;
      private String edtExamenCarrAsigAsignaturaId_Internalname ;
      private String edtExamenCarrAsigAsignaturaId_Jsonclick ;
      private String edtExamenCarrAsigAsignaturaNombre_Internalname ;
      private String A25ExamenCarrAsigAsignaturaNombre ;
      private String edtExamenCarrAsigAsignaturaNombre_Jsonclick ;
      private String edtEstudianteId_Internalname ;
      private String edtEstudianteId_Jsonclick ;
      private String imgprompt_15_Internalname ;
      private String imgprompt_15_Link ;
      private String edtEstudianteNombre_Internalname ;
      private String A18EstudianteNombre ;
      private String edtEstudianteNombre_Jsonclick ;
      private String edtExamenEstudianteNota_Internalname ;
      private String edtExamenEstudianteNota_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV14Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode6 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z23ExamenCarrAsigCarreraNombre ;
      private String Z25ExamenCarrAsigAsignaturaNombre ;
      private String Z18EstudianteNombre ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z28CertificadoFecha ;
      private DateTime A28CertificadoFecha ;
      private DateTime A26ExamenFecha ;
      private DateTime Z26ExamenFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool returnInSub ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00085_A18EstudianteNombre ;
      private DateTime[] T00084_A26ExamenFecha ;
      private short[] T00084_A22ExamenCarrAsigCarreraId ;
      private short[] T00084_A24ExamenCarrAsigAsignaturaId ;
      private String[] T00087_A23ExamenCarrAsigCarreraNombre ;
      private String[] T00088_A25ExamenCarrAsigAsignaturaNombre ;
      private short[] T00086_A27ExamenEstudianteNota ;
      private short[] T00089_A16CertificadoId ;
      private DateTime[] T00089_A28CertificadoFecha ;
      private DateTime[] T00089_A26ExamenFecha ;
      private String[] T00089_A23ExamenCarrAsigCarreraNombre ;
      private String[] T00089_A18EstudianteNombre ;
      private short[] T00089_A27ExamenEstudianteNota ;
      private short[] T00089_A17ExamenId ;
      private short[] T00089_A15EstudianteId ;
      private short[] T00089_A22ExamenCarrAsigCarreraId ;
      private short[] T00089_A24ExamenCarrAsigAsignaturaId ;
      private String[] T00089_A25ExamenCarrAsigAsignaturaNombre ;
      private DateTime[] T000810_A26ExamenFecha ;
      private short[] T000810_A22ExamenCarrAsigCarreraId ;
      private short[] T000810_A24ExamenCarrAsigAsignaturaId ;
      private String[] T000811_A23ExamenCarrAsigCarreraNombre ;
      private String[] T000812_A25ExamenCarrAsigAsignaturaNombre ;
      private short[] T000813_A27ExamenEstudianteNota ;
      private String[] T000814_A18EstudianteNombre ;
      private short[] T000815_A16CertificadoId ;
      private short[] T00083_A16CertificadoId ;
      private DateTime[] T00083_A28CertificadoFecha ;
      private short[] T00083_A17ExamenId ;
      private short[] T00083_A15EstudianteId ;
      private short[] T000816_A16CertificadoId ;
      private short[] T000817_A16CertificadoId ;
      private short[] T00082_A16CertificadoId ;
      private DateTime[] T00082_A28CertificadoFecha ;
      private short[] T00082_A17ExamenId ;
      private short[] T00082_A15EstudianteId ;
      private DateTime[] T000821_A26ExamenFecha ;
      private short[] T000821_A22ExamenCarrAsigCarreraId ;
      private short[] T000821_A24ExamenCarrAsigAsignaturaId ;
      private String[] T000822_A23ExamenCarrAsigCarreraNombre ;
      private String[] T000823_A25ExamenCarrAsigAsignaturaNombre ;
      private String[] T000824_A18EstudianteNombre ;
      private short[] T000825_A27ExamenEstudianteNota ;
      private short[] T000826_A16CertificadoId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV13TrnContextAtt ;
   }

   public class certificado__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00089 ;
          prmT00089 = new Object[] {
          new Object[] {"@CertificadoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00084 ;
          prmT00084 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00087 ;
          prmT00087 = new Object[] {
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00088 ;
          prmT00088 = new Object[] {
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExamenCarrAsigAsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00086 ;
          prmT00086 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00085 ;
          prmT00085 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000810 ;
          prmT000810 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000811 ;
          prmT000811 = new Object[] {
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000812 ;
          prmT000812 = new Object[] {
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExamenCarrAsigAsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000813 ;
          prmT000813 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000814 ;
          prmT000814 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000815 ;
          prmT000815 = new Object[] {
          new Object[] {"@CertificadoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00083 ;
          prmT00083 = new Object[] {
          new Object[] {"@CertificadoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000816 ;
          prmT000816 = new Object[] {
          new Object[] {"@CertificadoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000817 ;
          prmT000817 = new Object[] {
          new Object[] {"@CertificadoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00082 ;
          prmT00082 = new Object[] {
          new Object[] {"@CertificadoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000818 ;
          prmT000818 = new Object[] {
          new Object[] {"@CertificadoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CertificadoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000819 ;
          prmT000819 = new Object[] {
          new Object[] {"@CertificadoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CertificadoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000820 ;
          prmT000820 = new Object[] {
          new Object[] {"@CertificadoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000826 ;
          prmT000826 = new Object[] {
          } ;
          Object[] prmT000821 ;
          prmT000821 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000822 ;
          prmT000822 = new Object[] {
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000823 ;
          prmT000823 = new Object[] {
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExamenCarrAsigAsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000824 ;
          prmT000824 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000825 ;
          prmT000825 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00082", "SELECT [CertificadoId], [CertificadoFecha], [ExamenId], [EstudianteId] FROM [Certificado] WITH (UPDLOCK) WHERE [CertificadoId] = @CertificadoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00082,1,0,true,false )
             ,new CursorDef("T00083", "SELECT [CertificadoId], [CertificadoFecha], [ExamenId], [EstudianteId] FROM [Certificado] WITH (NOLOCK) WHERE [CertificadoId] = @CertificadoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00083,1,0,true,false )
             ,new CursorDef("T00084", "SELECT [ExamenFecha], [ExamenCarrAsigCarreraId] AS ExamenCarrAsigCarreraId, [ExamenCarrAsigAsignaturaId] AS ExamenCarrAsigAsignaturaId FROM [Examen] WITH (NOLOCK) WHERE [ExamenId] = @ExamenId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00084,1,0,true,false )
             ,new CursorDef("T00085", "SELECT [EstudianteNombre] FROM [Estudiante] WITH (NOLOCK) WHERE [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00085,1,0,true,false )
             ,new CursorDef("T00086", "SELECT [ExamenEstudianteNota] FROM [ExamenEstudiiante] WITH (NOLOCK) WHERE [ExamenId] = @ExamenId AND [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00086,1,0,true,false )
             ,new CursorDef("T00087", "SELECT [CarreraNombre] AS ExamenCarrAsigCarreraNombre FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @ExamenCarrAsigCarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00087,1,0,true,false )
             ,new CursorDef("T00088", "SELECT [AsignaturaNombre] AS ExamenCarrAsigAsignaturaNombre FROM [CarreraAsignatura] WITH (NOLOCK) WHERE [CarreraId] = @ExamenCarrAsigCarreraId AND [AsignaturaId] = @ExamenCarrAsigAsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00088,1,0,true,false )
             ,new CursorDef("T00089", "SELECT TM1.[CertificadoId], TM1.[CertificadoFecha], T2.[ExamenFecha], T3.[CarreraNombre] AS ExamenCarrAsigCarreraNombre, T5.[EstudianteNombre], T6.[ExamenEstudianteNota], TM1.[ExamenId], TM1.[EstudianteId], T2.[ExamenCarrAsigCarreraId] AS ExamenCarrAsigCarreraId, T2.[ExamenCarrAsigAsignaturaId] AS ExamenCarrAsigAsignaturaId, T4.[AsignaturaNombre] AS ExamenCarrAsigAsignaturaNombre FROM ((((([Certificado] TM1 WITH (NOLOCK) INNER JOIN [Examen] T2 WITH (NOLOCK) ON T2.[ExamenId] = TM1.[ExamenId]) INNER JOIN [Carrera] T3 WITH (NOLOCK) ON T3.[CarreraId] = T2.[ExamenCarrAsigCarreraId]) INNER JOIN [CarreraAsignatura] T4 WITH (NOLOCK) ON T4.[CarreraId] = T2.[ExamenCarrAsigCarreraId] AND T4.[AsignaturaId] = T2.[ExamenCarrAsigAsignaturaId]) INNER JOIN [Estudiante] T5 WITH (NOLOCK) ON T5.[EstudianteId] = TM1.[EstudianteId]) INNER JOIN [ExamenEstudiiante] T6 WITH (NOLOCK) ON T6.[ExamenId] = TM1.[ExamenId] AND T6.[EstudianteId] = TM1.[EstudianteId]) WHERE TM1.[CertificadoId] = @CertificadoId ORDER BY TM1.[CertificadoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00089,100,0,true,false )
             ,new CursorDef("T000810", "SELECT [ExamenFecha], [ExamenCarrAsigCarreraId] AS ExamenCarrAsigCarreraId, [ExamenCarrAsigAsignaturaId] AS ExamenCarrAsigAsignaturaId FROM [Examen] WITH (NOLOCK) WHERE [ExamenId] = @ExamenId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000810,1,0,true,false )
             ,new CursorDef("T000811", "SELECT [CarreraNombre] AS ExamenCarrAsigCarreraNombre FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @ExamenCarrAsigCarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000811,1,0,true,false )
             ,new CursorDef("T000812", "SELECT [AsignaturaNombre] AS ExamenCarrAsigAsignaturaNombre FROM [CarreraAsignatura] WITH (NOLOCK) WHERE [CarreraId] = @ExamenCarrAsigCarreraId AND [AsignaturaId] = @ExamenCarrAsigAsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000812,1,0,true,false )
             ,new CursorDef("T000813", "SELECT [ExamenEstudianteNota] FROM [ExamenEstudiiante] WITH (NOLOCK) WHERE [ExamenId] = @ExamenId AND [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000813,1,0,true,false )
             ,new CursorDef("T000814", "SELECT [EstudianteNombre] FROM [Estudiante] WITH (NOLOCK) WHERE [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000814,1,0,true,false )
             ,new CursorDef("T000815", "SELECT [CertificadoId] FROM [Certificado] WITH (NOLOCK) WHERE [CertificadoId] = @CertificadoId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000815,1,0,true,false )
             ,new CursorDef("T000816", "SELECT TOP 1 [CertificadoId] FROM [Certificado] WITH (NOLOCK) WHERE ( [CertificadoId] > @CertificadoId) ORDER BY [CertificadoId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000816,1,0,true,true )
             ,new CursorDef("T000817", "SELECT TOP 1 [CertificadoId] FROM [Certificado] WITH (NOLOCK) WHERE ( [CertificadoId] < @CertificadoId) ORDER BY [CertificadoId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000817,1,0,true,true )
             ,new CursorDef("T000818", "INSERT INTO [Certificado]([CertificadoId], [CertificadoFecha], [ExamenId], [EstudianteId]) VALUES(@CertificadoId, @CertificadoFecha, @ExamenId, @EstudianteId)", GxErrorMask.GX_NOMASK,prmT000818)
             ,new CursorDef("T000819", "UPDATE [Certificado] SET [CertificadoFecha]=@CertificadoFecha, [ExamenId]=@ExamenId, [EstudianteId]=@EstudianteId  WHERE [CertificadoId] = @CertificadoId", GxErrorMask.GX_NOMASK,prmT000819)
             ,new CursorDef("T000820", "DELETE FROM [Certificado]  WHERE [CertificadoId] = @CertificadoId", GxErrorMask.GX_NOMASK,prmT000820)
             ,new CursorDef("T000821", "SELECT [ExamenFecha], [ExamenCarrAsigCarreraId] AS ExamenCarrAsigCarreraId, [ExamenCarrAsigAsignaturaId] AS ExamenCarrAsigAsignaturaId FROM [Examen] WITH (NOLOCK) WHERE [ExamenId] = @ExamenId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000821,1,0,true,false )
             ,new CursorDef("T000822", "SELECT [CarreraNombre] AS ExamenCarrAsigCarreraNombre FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @ExamenCarrAsigCarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000822,1,0,true,false )
             ,new CursorDef("T000823", "SELECT [AsignaturaNombre] AS ExamenCarrAsigAsignaturaNombre FROM [CarreraAsignatura] WITH (NOLOCK) WHERE [CarreraId] = @ExamenCarrAsigCarreraId AND [AsignaturaId] = @ExamenCarrAsigAsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000823,1,0,true,false )
             ,new CursorDef("T000824", "SELECT [EstudianteNombre] FROM [Estudiante] WITH (NOLOCK) WHERE [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000824,1,0,true,false )
             ,new CursorDef("T000825", "SELECT [ExamenEstudianteNota] FROM [ExamenEstudiiante] WITH (NOLOCK) WHERE [ExamenId] = @ExamenId AND [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000825,1,0,true,false )
             ,new CursorDef("T000826", "SELECT [CertificadoId] FROM [Certificado] WITH (NOLOCK) ORDER BY [CertificadoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000826,100,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 2 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((String[]) buf[10])[0] = rslt.getString(11, 20) ;
                return;
             case 8 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 19 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 23 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 24 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 17 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
