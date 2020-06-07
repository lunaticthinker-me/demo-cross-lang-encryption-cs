#! /bin/bash

mkdir -p ./cert/x509

openssl req -newkey rsa:2048 -nodes -keyout cert/x509/key.pem -x509 -days 365 -out cert/x509/cert.pem

# make sure you don't set a password
openssl pkcs12 -export -out cert/x509/cert.pfx -inkey cert/x509/key.pem -in cert/x509/cert.pem