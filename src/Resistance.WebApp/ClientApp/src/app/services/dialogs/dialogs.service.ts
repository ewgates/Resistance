import { Injectable } from '@angular/core';
import { MdDialogRef, MdDialog, MdDialogConfig } from '@angular/material';
import { Observable } from 'rxjs/Rx';

import { LoginModalComponent } from '../../login-modal/login-modal.component';
import { User } from '../../models/user';

@Injectable()
export class DialogsService {

    constructor(private dialog: MdDialog) { }

    public promptLogin(appComponent): Observable<User> {
         return this.dialog.open(LoginModalComponent, { disableClose : true }).afterClosed();
    }

}