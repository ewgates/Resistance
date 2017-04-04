import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-game-creator',
    templateUrl: './game-creator.component.html',
    styleUrls: ['./game-creator.component.css']
})
export class GameCreatorComponent implements OnInit {

    players: string[] = [];
    creatingGame: boolean = true;

    constructor() {

    }

    ngOnInit() {

    }

    addPlayer(player: string) {
        this.players.push(player);
    }

    removePlayer(player: string) {
        this.players.splice(this.players.indexOf(player), 1);
    }

    createGame() {
        this.creatingGame = false;
    }

}
