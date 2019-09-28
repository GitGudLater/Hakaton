import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';

@Injectable()

export class SityRoutesService{

    private url:string;//restapi url controller

    constructor( private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.url = baseUrl;
      }

    getRoutes(){
        return this.http.get(this.url);//restapi url method controller (get cars)
    }

    
}