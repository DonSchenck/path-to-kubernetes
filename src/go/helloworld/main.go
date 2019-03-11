package main

import (
	"fmt"
	"log"
	"net/http"

	"github.com/gorilla/mux"
)

// our main function
func main() {
	router := mux.NewRouter()
	router.HandleFunc("/", GetHelloWorld).Methods("GET")
	log.Fatal(http.ListenAndServe("0.0.0.0:3333", router))
}

func GetHelloWorld(w http.ResponseWriter, r *http.Request) {
	fmt.Fprintf(w, "Hello World!")
}