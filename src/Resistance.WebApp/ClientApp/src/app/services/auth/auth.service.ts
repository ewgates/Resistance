import { Injectable } from '@angular/core';
import { tokenNotExpired } from 'angular2-jwt';

declare var Auth0Lock: any;

@Injectable()
export class Auth {

  lock = new Auth0Lock('4JjRgugSMpfPPoCIoTcCAM1MdGyuYlos', 'resistance.auth0.com', {});
  userProfile: Object;

  constructor() {

    this.userProfile = JSON.parse(localStorage.getItem('profile'));

    this.lock.on("authenticated", (authResult) => {

      localStorage.setItem('id_token', authResult.idToken);
      
      this.lock.getProfile(authResult.idToken, (error, profile) => {

        if (error) {
          alert(error);
          return;
        }

        localStorage.setItem('profile', JSON.stringify(profile));
        this.userProfile = profile;

      });

    });

  }

  public promptLogin() {
    this.lock.show();
  }

  public authenticated() {
    // This searches for an item in localStorage with key == 'id_token'
    return tokenNotExpired();
  }

  public logout() {
    localStorage.removeItem('id_token');
    localStorage.removeItem('profile');
  }

}
