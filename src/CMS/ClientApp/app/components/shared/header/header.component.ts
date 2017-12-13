import { Component } from 'angular/core';

@Component({
    selector: 'my-component',
    template: './header.component.ts'
})
export class ExampleComponent {
    constructor() {
        this.name = 'Sam';
    }
}
