import { Component, OnInit } from '@angular/core';
import { MdDialogRef } from '@angular/material';

import { User } from '../models/user';

@Component({
  selector: 'app-login-modal',
  templateUrl: './login-modal.component.html',
  styleUrls: ['./login-modal.component.css']
})
export class LoginModalComponent implements OnInit {

  public user: User;

  constructor(public dialogRef: MdDialogRef<LoginModalComponent>) {
    this.user = new User();
  }

  ngOnInit() {

  }

  login() {
    this.dialogRef.close(this.user);
  }

}
