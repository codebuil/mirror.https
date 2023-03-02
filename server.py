from http.server import BaseHTTPRequestHandler, HTTPServer
import urllib.request
import socket

class MyServer(BaseHTTPRequestHandler):
    def do_GET(self):
        # Configura a resposta HTTP
        PORTs = 8080
        self.send_response(200)
        self.send_header('Content-type', 'text/html')
        self.end_headers()
        hostname = socket.gethostname()
        ip_address = socket.gethostbyname(hostname)

        # Configura a resposta como uma string contendo código 
        link = self.path[1:]
        print (link)
        l1=""
        html=""
        url = link.split("&")
        if len(url)>1 :
              l1=url[1]
              with urllib.request.urlopen(l1) as response:
                   if l1.find(".png")<1 and l1.find(".jpg")<1 and l1.find(".bmp")<1:
                        html = response.read().decode()
                        html=html.replace("https://","rrr1234567890://"+ip_address+":"+str(PORTs)+"/&rrr1234567890s://")
                        html=html.replace("./","rrr1234567890://"+ip_address+":"+str(PORTs)+"/&rrr1234567890s://")
                        html=html.replace("rrr1234567890","http")
                   else:
                        html = response.read().decode()
        
        # Converte a string para bytes antes de enviá-la como resposta
        self.wfile.write(bytes(html, "utf8"))
        return

# Define a porta em que o servidor deve escutar
PORT = 8080
print ("\033c\033[44;30m\n")
# Cria um servidor que escuta na porta especificada e usa o manipulador de solicitações HTTP personalizado
with HTTPServer(("", PORT), MyServer) as httpd:
    print("Servidor rodando na porta:", PORT)
    # Aguarda indefinidamente por solicitações HTTP
    httpd.serve_forever()
