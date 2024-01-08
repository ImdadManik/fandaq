mkcert "fandaq.dev" "*.fandaq.dev" 
kubectl create namespace fandaq
kubectl create secret tls -n fandaq fandaq-tls --cert=./fandaq.dev+1.pem  --key=./fandaq.dev+1-key.pem