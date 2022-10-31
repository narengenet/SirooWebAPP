<div class="draw {{if isFinished}}finished{{/if}}">
    <div class="header">
        <div class="profile-link">
            <a class="profile-media" href="#">
                <img src="../${owner.profileMediaURL}" />
            </a>
            <a href="#" class="profile-fullname">${owner.name}</a>
            <a href="#" class="profile-date dates">${created}</a>
        </div>
    </div>
    <div class="contents">
        <span>دوره:</span><span>${name}</span>
    </div>
    <div class="contents">
        <span>تاریخ شروع:</span><span class="dates">${startDate}</span>
    </div>
    <div class="contents">
        <span>تاریخ پایان:</span><span class="dates">${endDate}</span>
    </div>
    <hr />

    <div class="contents">
        <div class="row">
            <h3>جوایز</h3>
        </div>
    </div>

    {{ each prizes }}
    <div class="contents">
        <span>${$index + 1}:</span> <span>${name}</span>، <span>${winnerCount} نفر</span>
    </div>
    {{/ each}}

    <hr />
    {{ if isFinished }}
    <div class="contents">
        <div class="row">
            <h3>برنده شدگان</h3>
        </div>
    </div>
    {{ else}}
    <div class="contents">
        <div class="row">
            <h3>تاکنون</h3>
        </div>
    </div>
    {{/if}}

    {{ each prizeWinners }}
    <div class="contents">
        <span>${$index + 1}:</span> <span>${username}</span>، <span>${points} امتیاز</span>
    </div>
    {{/ each}}

    <hr />


</div>