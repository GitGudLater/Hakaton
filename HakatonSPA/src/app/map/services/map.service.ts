import { Injectable } from '@angular/core';

//Исп. localstorage для сохранения данных в корзине

import { HttpClient,HttpHeaders,HttpResponse } from '@angular/common/http';
import { Car } from 'src/app/Models/car';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable()

export class MapService{
    private url:string;

    private _car: Car;
    private _carSubject: BehaviorSubject<Car> = new BehaviorSubject<Car>(this._car); 


    constructor( private http: HttpClient, /*@Inject('BASE_URL') baseUrl: string*/) {
        this.url = "http://examlple/api";//baseUrl;
      }

      public get cars$(): Observable<Car>{
        return this._carSubject;
      }

      public addPath(car:Car){
        this._car=car;
        this._carSubject.next(this._car);
        //this._carSubject.next(this._car);
        
        //this.http.put(this.webApiUrl+"/rest/all/V1/guest-carts/"+this.cartId+"/items/"+product.id,this.http.get(this.webApiUrl+"/rest/all/V1/products/"+product.sku)).toPromise();
  
     }

}