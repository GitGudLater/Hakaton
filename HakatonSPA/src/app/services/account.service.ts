import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Logg } from '../Models/Logg';
import { Register } from '../Models/Register';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  private url = "api/Account";

  constructor(private http: HttpClient) {
    this.url = 'http' + "api/Account";
  }

  postLog(login: Logg) {
    this.http.post(this.url, login).toPromise();
  }

  dislog() {
    var logout: string = "logout";
    this.http.post(this.url + '/' + logout, logout).toPromise();
  }

  putLog(reg: Register) {
    this.http.put(this.url, reg).toPromise();
  }

  getUserInformation() {
    return this.http.get(this.url);
  }
}
