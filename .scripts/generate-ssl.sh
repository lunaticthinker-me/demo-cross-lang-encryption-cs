#! /bin/bash

mkdir -p ./cert/ssl

openssl req -newkey rsa:2048 -nodes -keyout cert/ssl/key.pem -x509 -days 365 -out cert/ssl/cert.pem

# make sure you don't set a password
openssl pkcs12 -export -out cert/ssl/cert.pfx -inkey cert/ssl/key.pem -in cert/ssl/cert.pem