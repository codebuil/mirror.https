from http.server import BaseHTTPRequestHandler, HTTPServer
import urllib.request

class MyServer(BaseHTTPRequestHandler):
    def do_GET(self):
        # Configura a resposta HTTP
        self.send_response(200)
        self.send_header('Content-type', 'text/html')
        self.end_headers()

        # Configura a resposta como uma string contendo código 
        link = self.path[1:]
        print (link)
        l1=""
        html=""
        url = link.split("&")
        if len(url)>1 :
              l1=url[1]
              with urllib.request.urlopen(l1) as response:
                   html = response.read().decode()

        
        # Converte a string para bytes antes de enviá-la como resposta
        self.wfile.write(bytes(html, "utf8"))
        return

# Define a porta em que o servidor deve escutar
PORT = 8000
print ("\033c\033[44;30m\n")
# Cria um servidor que escuta na porta especificada e usa o manipulador de solicitações HTTP personalizado
with HTTPServer(("", PORT), MyServer) as httpd:
    print("Servidor rodando na porta:", PORT)
    # Aguarda indefinidamente por solicitações HTTP
    httpd.serve_forever()
