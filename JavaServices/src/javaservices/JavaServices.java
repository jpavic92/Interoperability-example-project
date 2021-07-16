package javaservices;

import XmlRpcServices.FetchTemperature;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.server.PropertyHandlerMapping;
import org.apache.xmlrpc.webserver.WebServer;

/**
 *
 * @author Josip
 */
public class JavaServices {

    public static void main(String[] args) {
        try {
            System.err.println("Starting XML-RPC server ...");
            WebServer server = new WebServer(8080);
            PropertyHandlerMapping phm = new PropertyHandlerMapping();
            phm.addHandler("CityTemperature", FetchTemperature.class);
            server.getXmlRpcServer().setHandlerMapping(phm);
            
            server.start();
            
            System.err.println("XML-RPC server is running ...");
            System.err.println("XML-RPC server is listening ...");
        } catch (IOException | XmlRpcException ex) {
            Logger.getLogger(JavaServices.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

}
