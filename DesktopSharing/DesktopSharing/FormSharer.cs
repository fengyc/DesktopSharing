using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RDPCOMAPILib;

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DesktopSharing
{
    public partial class FormSharer : Form
    {
        private RDPSession rdpSession;

        public FormSharer()
        {
            InitializeComponent();
        }

        private void init()
        {
            if (rdpSession != null)
            {
                rdpSession.Close();
            }

            rdpSession = new RDPSessionClass();
            
            /*TODO Too much "On..." code */
            rdpSession.OnApplicationOpen += new _IRDPSessionEvents_OnApplicationOpenEventHandler(rdpSession_OnApplicationOpen);
            rdpSession.OnApplicationClose += new _IRDPSessionEvents_OnApplicationCloseEventHandler(rdpSession_OnApplicationClose);
            rdpSession.OnApplicationUpdate += new _IRDPSessionEvents_OnApplicationUpdateEventHandler(rdpSession_OnApplicationUpdate);
            rdpSession.OnAttendeeConnected += new _IRDPSessionEvents_OnAttendeeConnectedEventHandler(rdpSession_OnAttendeeConnected);
            rdpSession.OnAttendeeDisconnected += new _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler(rdpSession_OnAttendeeDisconnected);
            rdpSession.OnAttendeeUpdate += new _IRDPSessionEvents_OnAttendeeUpdateEventHandler(rdpSession_OnAttendeeUpdate);
            rdpSession.OnChannelDataReceived += new _IRDPSessionEvents_OnChannelDataReceivedEventHandler(rdpSession_OnChannelDataReceived);
            rdpSession.OnChannelDataSent += new _IRDPSessionEvents_OnChannelDataSentEventHandler(rdpSession_OnChannelDataSent);
            rdpSession.OnConnectionAuthenticated += new _IRDPSessionEvents_OnConnectionAuthenticatedEventHandler(rdpSession_OnConnectionAuthenticated);
            rdpSession.OnConnectionEstablished += new _IRDPSessionEvents_OnConnectionEstablishedEventHandler(rdpSession_OnConnectionEstablished);
            rdpSession.OnConnectionFailed += new _IRDPSessionEvents_OnConnectionFailedEventHandler(rdpSession_OnConnectionFailed);
            rdpSession.OnConnectionTerminated += new _IRDPSessionEvents_OnConnectionTerminatedEventHandler(rdpSession_OnConnectionTerminated);
            rdpSession.OnControlLevelChangeRequest += new _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler(rdpSession_OnControlLevelChangeRequest);
            rdpSession.OnError += new _IRDPSessionEvents_OnErrorEventHandler(rdpSession_OnError);
            rdpSession.OnFocusReleased += new _IRDPSessionEvents_OnFocusReleasedEventHandler(rdpSession_OnFocusReleased);
            rdpSession.OnGraphicsStreamPaused += new _IRDPSessionEvents_OnGraphicsStreamPausedEventHandler(rdpSession_OnGraphicsStreamPaused);
            rdpSession.OnGraphicsStreamResumed += new _IRDPSessionEvents_OnGraphicsStreamResumedEventHandler(rdpSession_OnGraphicsStreamResumed);
            rdpSession.OnSharedDesktopSettingsChanged += new _IRDPSessionEvents_OnSharedDesktopSettingsChangedEventHandler(rdpSession_OnSharedDesktopSettingsChanged);
            rdpSession.OnSharedRectChanged += new _IRDPSessionEvents_OnSharedRectChangedEventHandler(rdpSession_OnSharedRectChanged);
            rdpSession.OnViewingSizeChanged += new _IRDPSessionEvents_OnViewingSizeChangedEventHandler(rdpSession_OnViewingSizeChanged);
            rdpSession.OnWindowClose += new _IRDPSessionEvents_OnWindowCloseEventHandler(rdpSession_OnWindowClose);
            rdpSession.OnWindowOpen += new _IRDPSessionEvents_OnWindowOpenEventHandler(rdpSession_OnWindowOpen);
            rdpSession.OnWindowUpdate += new _IRDPSessionEvents_OnWindowUpdateEventHandler(rdpSession_OnWindowUpdate);

            /*TODO Setup rdp session properties*/
            rdpSession.colordepth = 24;
            //rdpSession.Properties["DrvConAttach"]
            //rdpSession.Properties["PortId"] = 3386
            //rdpSession.Properties["PortProtocol"] = PortProtocol.AF_INET;
            /*TODO If we have an "IRDPSRAPITransportStream" */
            //rdpSession.Properties["SetNetworkStream"]
        }

        void rdpSession_OnWindowUpdate(object pWindow)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnWindowOpen(object pWindow)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnWindowClose(object pWindow)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnViewingSizeChanged(int left, int top, int right, int bottom)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnSharedRectChanged(int left, int top, int right, int bottom)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnSharedDesktopSettingsChanged(int width, int height, int colordepth)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnGraphicsStreamResumed()
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnGraphicsStreamPaused()
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnFocusReleased(int iDirection)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnError(object ErrorInfo)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnControlLevelChangeRequest(object pAttendee, CTRL_LEVEL RequestedLevel)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnConnectionTerminated(int discReason, int ExtendedInfo)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnConnectionFailed()
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnConnectionEstablished()
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnConnectionAuthenticated()
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnChannelDataSent(object pChannel, int lAttendeeId, int BytesSent)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnChannelDataReceived(object pChannel, int lAttendeeId, string bstrData)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnAttendeeUpdate(object pAttendee)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnAttendeeDisconnected(object pDisconnectInfo)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnAttendeeConnected(object pAttendee)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnApplicationUpdate(object pApplication)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnApplicationClose(object pApplication)
        {
            throw new NotImplementedException();
        }

        void rdpSession_OnApplicationOpen(object pApplication)
        {
            throw new NotImplementedException();
        }
    }
}
