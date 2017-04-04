import { Component } from '@angular/core';
import { MdDialogRef, MdDialog } from '@angular/material';
import { Observable } from 'rxjs/Rx';

import { Auth } from './services/auth/auth.service';
import { User } from './models/user';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  public currentUser: User;

  constructor(private auth: Auth) {
    
  }

  ngOnInit() {

  }

  promptLogin() {
  }
  
  login() {
    this.currentUser.loggedIn = true;
  }
  
  logout() {
    this.currentUser.loggedIn = false;
  }

}
