/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { InfoBlockComponent } from './info-block.component';

let component: InfoBlockComponent;
let fixture: ComponentFixture<InfoBlockComponent>;

describe('info-block component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ InfoBlockComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(InfoBlockComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});