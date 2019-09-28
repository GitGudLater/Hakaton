import { Component, OnInit } from '@angular/core';
import { AccountService } from '../services/account.service';
import { HttpClient } from '@angular/common/http';
import { Logg } from '../Models/Logg';
import { Register } from '../Models/Register';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.sass']
})
export class AccountComponent implements OnInit {

  public account: Logg = new Logg;

  public regAccount: Register = new Register;

  registration: boolean = false;


  constructor(private loggService: AccountService, http: HttpClient) { }

  ngOnInit() {
  }

  toggleRegistrator() {
    this.registration = !this.registration;
  }

  dislog() {
    this.loggService.dislog();
  }

  postLog() {
    this.loggService.postLog(this.account);
  }

  putReg() {
    this.loggService.putLog(this.regAccount);
  }

}
