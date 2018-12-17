import { Component } from "@angular/core";

@Component({
    selector: "offices",
    templateUrl: "./office-list.component.html",
    styleUrls: ["./office-list.component.css"]
})

export class OfficeListComponent {
    pageTitle: string = "Office List";
    offices: any[] = [
        {
            "name": "Office1",
            "description": "Very Good"
        },
        {
            "name": "Office2",
            "description": "Good"
        },
        {
            "name": "Office2",
            "description": "Well"
        }
    ];
}
